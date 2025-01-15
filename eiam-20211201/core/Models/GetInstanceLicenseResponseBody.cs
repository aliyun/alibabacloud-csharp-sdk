// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetInstanceLicenseResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned result.</para>
        /// </summary>
        [NameInMap("License")]
        [Validation(Required=false)]
        public GetInstanceLicenseResponseBodyLicense License { get; set; }
        public class GetInstanceLicenseResponseBodyLicense : TeaModel {
            /// <summary>
            /// <para>Edition of the License</para>
            /// 
            /// <b>Example:</b>
            /// <para>free</para>
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public string Edition { get; set; }

            /// <summary>
            /// <para>End date of the validity period of the License, timestamp</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723996800000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Payment type of the License</para>
            /// 
            /// <b>Example:</b>
            /// <para>prepay</para>
            /// </summary>
            [NameInMap("LicenseChargeType")]
            [Validation(Required=false)]
            public string LicenseChargeType { get; set; }

            /// <summary>
            /// <para>Detailed configuration JSON string of the License</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;modules&quot;:[{&quot;features&quot;:[{&quot;name&quot;:&quot;urn:alibaba:idaas:license:module:ud:customField&quot;,&quot;status&quot;:&quot;enabled&quot;}]……{&quot;name&quot;:&quot;urn:alibaba:idaas:license:tag:enterprise&quot;,&quot;status&quot;:&quot;enabled&quot;}],&quot;version&quot;:&quot;1.0&quot;}</para>
            /// </summary>
            [NameInMap("LicenseConfigJson")]
            [Validation(Required=false)]
            public string LicenseConfigJson { get; set; }

            /// <summary>
            /// <para>Creation time of the License, timestamp</para>
            /// 
            /// <b>Example:</b>
            /// <para>1720509699000</para>
            /// </summary>
            [NameInMap("LicenseCreateTime")]
            [Validation(Required=false)]
            public long? LicenseCreateTime { get; set; }

            /// <summary>
            /// <para>Unique identifier of the License</para>
            /// 
            /// <b>Example:</b>
            /// <para>license_1234xxxx</para>
            /// </summary>
            [NameInMap("LicenseId")]
            [Validation(Required=false)]
            public string LicenseId { get; set; }

            /// <summary>
            /// <para>Status of the License</para>
            /// 
            /// <b>Example:</b>
            /// <para>valid</para>
            /// </summary>
            [NameInMap("LicenseStatus")]
            [Validation(Required=false)]
            public string LicenseStatus { get; set; }

            /// <summary>
            /// <para>Purchase channel of the License</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud</para>
            /// </summary>
            [NameInMap("PurchaseChannel")]
            [Validation(Required=false)]
            public string PurchaseChannel { get; set; }

            /// <summary>
            /// <para>Unique external product identifier corresponding to the License</para>
            /// 
            /// <b>Example:</b>
            /// <para>eiam-cn-xxxxx</para>
            /// </summary>
            [NameInMap("PurchaseInstanceId")]
            [Validation(Required=false)]
            public string PurchaseInstanceId { get; set; }

            /// <summary>
            /// <para>Start date of the validity period of the License, timestamp</para>
            /// 
            /// <b>Example:</b>
            /// <para>1720509699000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>User quota of the License</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("UserQuota")]
            [Validation(Required=false)]
            public long? UserQuota { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
