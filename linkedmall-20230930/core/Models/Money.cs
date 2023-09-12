// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Money : TeaModel {
        [NameInMap("amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        [NameInMap("amountAsString")]
        [Validation(Required=false)]
        public string AmountAsString { get; set; }

        [NameInMap("amountString")]
        [Validation(Required=false)]
        public string AmountString { get; set; }

        [NameInMap("cent")]
        [Validation(Required=false)]
        public long? Cent { get; set; }

        [NameInMap("currency")]
        [Validation(Required=false)]
        public MoneyCurrency Currency { get; set; }
        public class MoneyCurrency : TeaModel {
            [NameInMap("currencyCode")]
            [Validation(Required=false)]
            public string CurrencyCode { get; set; }

            [NameInMap("defaultFractionDigits")]
            [Validation(Required=false)]
            public int? DefaultFractionDigits { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("numericCode")]
            [Validation(Required=false)]
            public int? NumericCode { get; set; }

            [NameInMap("symbol")]
            [Validation(Required=false)]
            public string Symbol { get; set; }

        }

        [NameInMap("currencyCode")]
        [Validation(Required=false)]
        public string CurrencyCode { get; set; }

        [NameInMap("positive")]
        [Validation(Required=false)]
        public bool? Positive { get; set; }

    }

}
