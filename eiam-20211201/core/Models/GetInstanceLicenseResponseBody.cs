// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetInstanceLicenseResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("License")]
        [Validation(Required=false)]
        public GetInstanceLicenseResponseBodyLicense License { get; set; }
        public class GetInstanceLicenseResponseBodyLicense : TeaModel {
            /// <summary>
            /// <para>The edition of the license.</para>
            /// 
            /// <b>Example:</b>
            /// <para>free</para>
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public string Edition { get; set; }

            /// <summary>
            /// <para>The end date of the license validity period. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723996800000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The detailed license information of the instance.</para>
            /// </summary>
            [NameInMap("InstanceLicenseDetail")]
            [Validation(Required=false)]
            public GetInstanceLicenseResponseBodyLicenseInstanceLicenseDetail InstanceLicenseDetail { get; set; }
            public class GetInstanceLicenseResponseBodyLicenseInstanceLicenseDetail : TeaModel {
                /// <summary>
                /// <para>The conditional access license status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("ConditionalAccessPolicyLicenseStatus")]
                [Validation(Required=false)]
                public string ConditionalAccessPolicyLicenseStatus { get; set; }

                /// <summary>
                /// <para>The M2M license status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("M2mApplicationLicenseStatus")]
                [Validation(Required=false)]
                public string M2mApplicationLicenseStatus { get; set; }

                /// <summary>
                /// <para>The M2M application quota of the license.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("M2mApplicationQuota")]
                [Validation(Required=false)]
                public long? M2mApplicationQuota { get; set; }

                /// <summary>
                /// <para>The machine identity status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("MimApplicationLicenseStatus")]
                [Validation(Required=false)]
                public string MimApplicationLicenseStatus { get; set; }

                /// <summary>
                /// <para>The network access endpoint quota of the license.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NetworkAccessEndpointQuota")]
                [Validation(Required=false)]
                public long? NetworkAccessEndpointQuota { get; set; }

                /// <summary>
                /// <para>The base quota of monthly active PAM users included in the plan, excluding additional purchases. The value is 0 if PAM is not activated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("PamActiveUserBaseQuota")]
                [Validation(Required=false)]
                public long? PamActiveUserBaseQuota { get; set; }

                /// <summary>
                /// <para>The number of additionally purchased monthly active PAM users. The value is 0 if no additional users are purchased or PAM is not activated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PamActiveUserPurchasedQuota")]
                [Validation(Required=false)]
                public long? PamActiveUserPurchasedQuota { get; set; }

                /// <summary>
                /// <para>Specifies whether pay-as-you-go billing for monthly PAM overages is enabled. Returns false if PAM is not activated or elastic billing is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PamElasticBillingEnabled")]
                [Validation(Required=false)]
                public bool? PamElasticBillingEnabled { get; set; }

                /// <summary>
                /// <para>The Privileged Access Management (PAM) license status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("PamLicenseStatus")]
                [Validation(Required=false)]
                public string PamLicenseStatus { get; set; }

                /// <summary>
                /// <para>The number of active subscription users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("PrepaidActiveUserNumber")]
                [Validation(Required=false)]
                public long? PrepaidActiveUserNumber { get; set; }

                /// <summary>
                /// <para>The user quota of the license.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("UserQuota")]
                [Validation(Required=false)]
                public long? UserQuota { get; set; }

            }

            /// <summary>
            /// <para>The billing method of the license.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prepay</para>
            /// </summary>
            [NameInMap("LicenseChargeType")]
            [Validation(Required=false)]
            public string LicenseChargeType { get; set; }

            /// <summary>
            /// <para>The JSON string of the detailed license configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;modules&quot;:[{&quot;features&quot;:[{&quot;name&quot;:&quot;urn:alibaba:idaas:license:module:ud:customField&quot;,&quot;status&quot;:&quot;enabled&quot;}]……{&quot;name&quot;:&quot;urn:alibaba:idaas:license:tag:enterprise&quot;,&quot;status&quot;:&quot;enabled&quot;}],&quot;version&quot;:&quot;1.0&quot;}</para>
            /// </summary>
            [NameInMap("LicenseConfigJson")]
            [Validation(Required=false)]
            public string LicenseConfigJson { get; set; }

            /// <summary>
            /// <para>The creation time of the license. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1720509699000</para>
            /// </summary>
            [NameInMap("LicenseCreateTime")]
            [Validation(Required=false)]
            public long? LicenseCreateTime { get; set; }

            /// <summary>
            /// <para>The unique identifier of the license.</para>
            /// 
            /// <b>Example:</b>
            /// <para>license_1234xxxx</para>
            /// </summary>
            [NameInMap("LicenseId")]
            [Validation(Required=false)]
            public string LicenseId { get; set; }

            /// <summary>
            /// <para>The license status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>valid</para>
            /// </summary>
            [NameInMap("LicenseStatus")]
            [Validation(Required=false)]
            public string LicenseStatus { get; set; }

            /// <summary>
            /// <para>The purchase channel of the license.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud</para>
            /// </summary>
            [NameInMap("PurchaseChannel")]
            [Validation(Required=false)]
            public string PurchaseChannel { get; set; }

            /// <summary>
            /// <para>The unique identifier of the external product corresponding to the license.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eiam-cn-xxxxx</para>
            /// </summary>
            [NameInMap("PurchaseInstanceId")]
            [Validation(Required=false)]
            public string PurchaseInstanceId { get; set; }

            /// <summary>
            /// <para>The start date of the license validity period. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1720509699000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The user quota of the license.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("UserQuota")]
            [Validation(Required=false)]
            public long? UserQuota { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
