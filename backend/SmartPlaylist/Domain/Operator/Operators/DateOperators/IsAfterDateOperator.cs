﻿using SmartPlaylist.Domain.Values;

namespace SmartPlaylist.Domain.Operator.Operators.DateOperators
{
    public class IsAfterDateOperator : OperatorGen<DateValue, DateValue>
    {
        public override string Name => "is after";
        public override Value DefaultValue => DateValue.Default;

        public override bool Compare(Value itemValue, Value value)
        {
            return Compare(itemValue as DateValue, value as DateValue);
        }

        public override bool Compare(DateValue itemValue, DateValue value)
        {
            return itemValue.Value.Date > value.Value.Date;
        }
    }
}