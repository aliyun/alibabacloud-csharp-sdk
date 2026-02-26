// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Money : TeaModel {
        /// <summary>
        /// <para>amount</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// <para>amountAsString</para>
        /// </summary>
        [NameInMap("amountAsString")]
        [Validation(Required=false)]
        public string AmountAsString { get; set; }

        /// <summary>
        /// <para>amountString</para>
        /// </summary>
        [NameInMap("amountString")]
        [Validation(Required=false)]
        public string AmountString { get; set; }

        /// <summary>
        /// <para>cent</para>
        /// </summary>
        [NameInMap("cent")]
        [Validation(Required=false)]
        public long? Cent { get; set; }

        /// <summary>
        /// <para>currency</para>
        /// </summary>
        [NameInMap("currency")]
        [Validation(Required=false)]
        public MoneyCurrency Currency { get; set; }
        public class MoneyCurrency : TeaModel {
            /// <summary>
            /// <para>currencyCode</para>
            /// </summary>
            [NameInMap("currencyCode")]
            [Validation(Required=false)]
            public string CurrencyCode { get; set; }

            /// <summary>
            /// <para>defaultFractionDigits</para>
            /// </summary>
            [NameInMap("defaultFractionDigits")]
            [Validation(Required=false)]
            public int? DefaultFractionDigits { get; set; }

            /// <summary>
            /// <para>displayName</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>numericCode</para>
            /// </summary>
            [NameInMap("numericCode")]
            [Validation(Required=false)]
            public int? NumericCode { get; set; }

            /// <summary>
            /// <para>symbol</para>
            /// </summary>
            [NameInMap("symbol")]
            [Validation(Required=false)]
            public string Symbol { get; set; }

        }

        /// <summary>
        /// <para>currencyCode</para>
        /// </summary>
        [NameInMap("currencyCode")]
        [Validation(Required=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// <para>positive</para>
        /// </summary>
        [NameInMap("positive")]
        [Validation(Required=false)]
        public bool? Positive { get; set; }

    }

}
