// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class GetUserConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AccountSufficient")]
        [Validation(Required=false)]
        public bool? AccountSufficient { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableEciDisk")]
        [Validation(Required=false)]
        public bool? EnableEciDisk { get; set; }

        [NameInMap("FreeTier")]
        [Validation(Required=false)]
        public GetUserConfigResponseBodyFreeTier FreeTier { get; set; }
        public class GetUserConfigResponseBodyFreeTier : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-11-08T15:00:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>个</para>
            /// </summary>
            [NameInMap("InitBaseUnit")]
            [Validation(Required=false)]
            public string InitBaseUnit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("InitBaseValue")]
            [Validation(Required=false)]
            public double? InitBaseValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>个</para>
            /// </summary>
            [NameInMap("InitShowUnit")]
            [Validation(Required=false)]
            public string InitShowUnit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("InitShowValue")]
            [Validation(Required=false)]
            public string InitShowValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsFreeTierUser")]
            [Validation(Required=false)]
            public bool? IsFreeTierUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>个</para>
            /// </summary>
            [NameInMap("PeriodBaseUnit")]
            [Validation(Required=false)]
            public string PeriodBaseUnit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3000</para>
            /// </summary>
            [NameInMap("PeriodBaseValue")]
            [Validation(Required=false)]
            public double? PeriodBaseValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>个</para>
            /// </summary>
            [NameInMap("PeriodShowUnit")]
            [Validation(Required=false)]
            public string PeriodShowUnit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3000</para>
            /// </summary>
            [NameInMap("PeriodShowValue")]
            [Validation(Required=false)]
            public string PeriodShowValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-11-08T15:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>valid</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FreeTierSpecAvailable")]
        [Validation(Required=false)]
        public bool? FreeTierSpecAvailable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Access denied&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E7D55162-4489-1619-AAF5-3F97D5FCA948</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
