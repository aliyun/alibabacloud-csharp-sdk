// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetYikeAccountCreditResponseBody : TeaModel {
        /// <summary>
        /// <para>The credit information.</para>
        /// </summary>
        [NameInMap("CreditInfo")]
        [Validation(Required=false)]
        public GetYikeAccountCreditResponseBodyCreditInfo CreditInfo { get; set; }
        public class GetYikeAccountCreditResponseBodyCreditInfo : TeaModel {
            /// <summary>
            /// <para>The total granted credits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("GrantedCreditQuota")]
            [Validation(Required=false)]
            public double? GrantedCreditQuota { get; set; }

            /// <summary>
            /// <para>The remaining granted credits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("GrantedCreditQuotaUsage")]
            [Validation(Required=false)]
            public double? GrantedCreditQuotaUsage { get; set; }

            /// <summary>
            /// <para>The total credits of the booster pack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20000</para>
            /// </summary>
            [NameInMap("PackCreditQuota")]
            [Validation(Required=false)]
            public double? PackCreditQuota { get; set; }

            /// <summary>
            /// <para>The remaining credits of the booster pack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("PackCreditQuotaUsage")]
            [Validation(Required=false)]
            public double? PackCreditQuotaUsage { get; set; }

            /// <summary>
            /// <para>The total credits of the membership plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("ResourceCreditQuota")]
            [Validation(Required=false)]
            public double? ResourceCreditQuota { get; set; }

            /// <summary>
            /// <para>The remaining credits of the membership plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("ResourceCreditQuotaUsage")]
            [Validation(Required=false)]
            public double? ResourceCreditQuotaUsage { get; set; }

        }

        /// <summary>
        /// <para>The membership information.</para>
        /// </summary>
        [NameInMap("MembershipInfo")]
        [Validation(Required=false)]
        public GetYikeAccountCreditResponseBodyMembershipInfo MembershipInfo { get; set; }
        public class GetYikeAccountCreditResponseBodyMembershipInfo : TeaModel {
            /// <summary>
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1784179281</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The membership level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>basic: Basic Edition.</description></item>
            /// <item><description>standard: Standard Edition.</description></item>
            /// <item><description>professional: Ultimate Edition.</description></item>
            /// <item><description>ultra: Ultra Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("Membership")]
            [Validation(Required=false)]
            public string Membership { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1784784081</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
