// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeCreditPackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The credit booster package information.</para>
        /// </summary>
        [NameInMap("CreditsPackageInfos")]
        [Validation(Required=false)]
        public List<DescribeCreditPackageResponseBodyCreditsPackageInfos> CreditsPackageInfos { get; set; }
        public class DescribeCreditPackageResponseBodyCreditsPackageInfos : TeaModel {
            /// <summary>
            /// <para>The number of available credits in the current credit booster package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("AvailableCredits")]
            [Validation(Required=false)]
            public string AvailableCredits { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the credit booster package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crp-xagydbhfkah****</para>
            /// </summary>
            [NameInMap("CreditPackageId")]
            [Validation(Required=false)]
            public string CreditPackageId { get; set; }

            /// <summary>
            /// <para>The status of the credit booster package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("CreditPackageStatus")]
            [Validation(Required=false)]
            public string CreditPackageStatus { get; set; }

            /// <summary>
            /// <para>The effective period of the credit booster package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-30 00:00:00</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The number of consumed credits in the current credit booster package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("ExhaustedCredits")]
            [Validation(Required=false)]
            public string ExhaustedCredits { get; set; }

            /// <summary>
            /// <para>The expiration time of the credit booster package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-30 00:00:00</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The total number of credits in the current credit booster package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCredits")]
            [Validation(Required=false)]
            public string TotalCredits { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether this is the first purchase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsFirstPurchase")]
        [Validation(Required=false)]
        public bool? IsFirstPurchase { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of available credits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalAvailableCredits")]
        [Validation(Required=false)]
        public string TotalAvailableCredits { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of consumed credits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalExhaustedCredit")]
        [Validation(Required=false)]
        public string TotalExhaustedCredit { get; set; }

    }

}
