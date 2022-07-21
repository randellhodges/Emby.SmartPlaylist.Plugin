import { toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import { version } from '~/emby/app.data';
import { Guid } from './guid';

export function utils_configure() {
    toast.configure();
}

export type ErrorProps = {
    label: string,
    content: any,
    modal: boolean,
    timeout?: number
}

export function showError(errorProps: ErrorProps): void {
    var m = `${errorProps.label}: ${(errorProps.content instanceof Error ? errorProps.content.message : errorProps.content)}`;
    toast.error(m, {
        containerId: errorProps.modal ? "modalToast" : "appToast",
        autoClose: errorProps.timeout ? errorProps.timeout : false,
        position: 'top-center',
        bodyStyle: {
            zIndex: 1000
        }
    });
}

export function showInfo(msg: string, modal: boolean) {
    toast(msg, {
        containerId: modal ? "modalToast" : "appToast"
    });
}

export function tryParseInt(i: any) {
    if (isNaN(i))
        throw Error(i + ' is not a valid number.');

    return parseInt(i);
}

export function openUrl(baseUrl: string, newWindow: boolean) {
    const url = `${baseUrl}?v=${version}&X-Emby-Client=${window.ApiClient.appName()}&X-Emby-Device-Name=${window.ApiClient.deviceName()}&X-Emby-Device-Id=${window.ApiClient.deviceId()}&X-Emby-Client-Version=${window.ApiClient.appVersion()}&X-Emby-Token=${window.ApiClient.accessToken()}`;
    if (newWindow)
        window.open(url, Guid.newGuid());
    else
        window.location.href = url;
}

export const toBase64 = file => new Promise((resolve, reject) => {
    const reader = new FileReader();
    reader.readAsDataURL(file);
    reader.onload = () => resolve(reader.result);
    reader.onerror = error => reject(error);
});