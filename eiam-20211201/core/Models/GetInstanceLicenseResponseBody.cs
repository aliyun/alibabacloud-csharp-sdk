// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetInstanceLicenseResponseBody : TeaModel {
        /// <summary>
        /// <para>The license details.</para>
        /// </summary>
        [NameInMap("License")]
        [Validation(Required=false)]
        public GetInstanceLicenseResponseBodyLicense License { get; set; }
        public class GetInstanceLicenseResponseBodyLicense : TeaModel {
            /// <summary>
            /// <para>The license edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>free</para>
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public string Edition { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp indicating the end of the license validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723996800000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The details of the instance license.</para>
            /// </summary>
            [NameInMap("InstanceLicenseDetail")]
            [Validation(Required=false)]
            public GetInstanceLicenseResponseBodyLicenseInstanceLicenseDetail InstanceLicenseDetail { get; set; }
            public class GetInstanceLicenseResponseBodyLicenseInstanceLicenseDetail : TeaModel {
                /// <summary>
                /// <para>The status of the license for the Conditional Access feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("ConditionalAccessPolicyLicenseStatus")]
                [Validation(Required=false)]
                public string ConditionalAccessPolicyLicenseStatus { get; set; }

                /// <summary>
                /// <para>The status of the license for machine-to-machine (M2M) applications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("M2mApplicationLicenseStatus")]
                [Validation(Required=false)]
                public string M2mApplicationLicenseStatus { get; set; }

                /// <summary>
                /// <para>The quota for machine-to-machine (M2M) applications.</para>
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
                /// <para>The quota for network access endpoints.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NetworkAccessEndpointQuota")]
                [Validation(Required=false)]
                public long? NetworkAccessEndpointQuota { get; set; }

                /// <summary>
                /// <para>The number of active subscription accounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("PrepaidActiveUserNumber")]
                [Validation(Required=false)]
                public long? PrepaidActiveUserNumber { get; set; }

                /// <summary>
                /// <para>The user quota included with the license.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("UserQuota")]
                [Validation(Required=false)]
                public long? UserQuota { get; set; }

            }

            /// <summary>
            /// <para>The billing method for the license.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prepay</para>
            /// </summary>
            [NameInMap("LicenseChargeType")]
            [Validation(Required=false)]
            public string LicenseChargeType { get; set; }

            /// <summary>
            /// <para>The detailed configurations of the license, formatted as a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;modules&quot;:[{&quot;features&quot;:[{&quot;name&quot;:&quot;urn:alibaba:idaas:license:module:ud:customField&quot;,&quot;status&quot;:&quot;enabled&quot;}]……{&quot;name&quot;:&quot;urn:alibaba:idaas:license:tag:enterprise&quot;,&quot;status&quot;:&quot;enabled&quot;}],&quot;version&quot;:&quot;1.0&quot;}</para>
            /// </summary>
            [NameInMap("LicenseConfigJson")]
            [Validation(Required=false)]
            public string LicenseConfigJson { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp indicating when the license was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1720509699000</para>
            /// </summary>
            [NameInMap("LicenseCreateTime")]
            [Validation(Required=false)]
            public long? LicenseCreateTime { get; set; }

            /// <summary>
            /// <para>The unique identifier for the license.</para>
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
            /// <para>The channel used to purchase the license.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud</para>
            /// </summary>
            [NameInMap("PurchaseChannel")]
            [Validation(Required=false)]
            public string PurchaseChannel { get; set; }

            /// <summary>
            /// <para>The unique identifier of the external service associated with the license.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eiam-cn-xxxxx</para>
            /// </summary>
            [NameInMap("PurchaseInstanceId")]
            [Validation(Required=false)]
            public string PurchaseInstanceId { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp indicating the start of the license validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1720509699000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The user quota included with the license.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("UserQuota")]
            [Validation(Required=false)]
            public long? UserQuota { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
