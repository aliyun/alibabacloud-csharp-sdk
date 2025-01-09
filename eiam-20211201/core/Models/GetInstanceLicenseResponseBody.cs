// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetInstanceLicenseResponseBody : TeaModel {
        [NameInMap("License")]
        [Validation(Required=false)]
        public GetInstanceLicenseResponseBodyLicense License { get; set; }
        public class GetInstanceLicenseResponseBodyLicense : TeaModel {
            /// <summary>
            /// <para>License 的版本型号,free-免费版，trail-试用版，enterprise-企业版</para>
            /// 
            /// <b>Example:</b>
            /// <para>free</para>
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public string Edition { get; set; }

            /// <summary>
            /// <para>License 的有效期终止日期</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723996800000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>License 的付费类型，prepay-预付费，postpay-后付费</para>
            /// 
            /// <b>Example:</b>
            /// <para>prepay</para>
            /// </summary>
            [NameInMap("LicenseChargeType")]
            [Validation(Required=false)]
            public string LicenseChargeType { get; set; }

            /// <summary>
            /// <para>License 详细配置JSON</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;modules&quot;:[{&quot;features&quot;:[{&quot;name&quot;:&quot;urn:alibaba:idaas:license:module:ud:customField&quot;,&quot;status&quot;:&quot;enabled&quot;}]……{&quot;name&quot;:&quot;urn:alibaba:idaas:license:tag:enterprise&quot;,&quot;status&quot;:&quot;enabled&quot;}],&quot;version&quot;:&quot;1.0&quot;}</para>
            /// </summary>
            [NameInMap("LicenseConfigJson")]
            [Validation(Required=false)]
            public string LicenseConfigJson { get; set; }

            /// <summary>
            /// <para>License 的创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>1720509699000</para>
            /// </summary>
            [NameInMap("LicenseCreateTime")]
            [Validation(Required=false)]
            public long? LicenseCreateTime { get; set; }

            /// <summary>
            /// <para>License 的唯一标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>license_1234xxxx</para>
            /// </summary>
            [NameInMap("LicenseId")]
            [Validation(Required=false)]
            public string LicenseId { get; set; }

            /// <summary>
            /// <para>License 的状态，valid-有效，expired-已过期，released-已释放</para>
            /// 
            /// <b>Example:</b>
            /// <para>valid</para>
            /// </summary>
            [NameInMap("LicenseStatus")]
            [Validation(Required=false)]
            public string LicenseStatus { get; set; }

            /// <summary>
            /// <para>License 的购买渠道</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud</para>
            /// </summary>
            [NameInMap("PurchaseChannel")]
            [Validation(Required=false)]
            public string PurchaseChannel { get; set; }

            /// <summary>
            /// <para>License 对应的外部商品唯一标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>eiam-cn-xxxxx</para>
            /// </summary>
            [NameInMap("PurchaseInstanceId")]
            [Validation(Required=false)]
            public string PurchaseInstanceId { get; set; }

            /// <summary>
            /// <para>License 的有效期开始日期</para>
            /// 
            /// <b>Example:</b>
            /// <para>1720509699000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>License 的用户配额</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("UserQuota")]
            [Validation(Required=false)]
            public long? UserQuota { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
