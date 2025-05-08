// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateSupplierInformationRequest : TeaModel {
        /// <summary>
        /// <para>The delivery settings.</para>
        /// </summary>
        [NameInMap("DeliverySettings")]
        [Validation(Required=false)]
        public UpdateSupplierInformationRequestDeliverySettings DeliverySettings { get; set; }
        public class UpdateSupplierInformationRequestDeliverySettings : TeaModel {
            /// <summary>
            /// <para>The name of the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mybucket</para>
            /// </summary>
            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable screencast delivery to Object Storage Service (OSS). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OssEnabled")]
            [Validation(Required=false)]
            public bool? OssEnabled { get; set; }

            /// <summary>
            /// <para>The number of days for which the screencasts are saved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("OssExpirationDays")]
            [Validation(Required=false)]
            public long? OssExpirationDays { get; set; }

            /// <summary>
            /// <para>The OSS path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>path1/path2/</para>
            /// </summary>
            [NameInMap("OssPath")]
            [Validation(Required=false)]
            public string OssPath { get; set; }

        }

        /// <summary>
        /// <para>The Ip of operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.xxx.xxx.xxx/16,192.xxx.xxx.xxx</para>
        /// </summary>
        [NameInMap("OperationIp")]
        [Validation(Required=false)]
        public string OperationIp { get; set; }

        /// <summary>
        /// <para>The MFA of operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OperationMfaPresent")]
        [Validation(Required=false)]
        public bool? OperationMfaPresent { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The description of service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test supplier</para>
        /// </summary>
        [NameInMap("SupplierDesc")]
        [Validation(Required=false)]
        public string SupplierDesc { get; set; }

        /// <summary>
        /// <para>The Logo of service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.aliyundoc.com/cover/34DB-4F4C-9373-003AA060****.png">http://example.aliyundoc.com/cover/34DB-4F4C-9373-003AA060****.png</a></para>
        /// </summary>
        [NameInMap("SupplierLogo")]
        [Validation(Required=false)]
        public string SupplierLogo { get; set; }

        /// <summary>
        /// <para>The URL of the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.xxx.xxx.cn">http://www.xxx.xxx.cn</a></para>
        /// </summary>
        [NameInMap("SupplierUrl")]
        [Validation(Required=false)]
        public string SupplierUrl { get; set; }

        /// <summary>
        /// <para>Contact information of the service provider</para>
        /// </summary>
        [NameInMap("SupportContacts")]
        [Validation(Required=false)]
        public List<UpdateSupplierInformationRequestSupportContacts> SupportContacts { get; set; }
        public class UpdateSupplierInformationRequestSupportContacts : TeaModel {
            /// <summary>
            /// <para>The type of  contact information</para>
            /// 
            /// <b>Example:</b>
            /// <para>Email</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The value of contact information</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:supplier@example.com">supplier@example.com</a></para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
