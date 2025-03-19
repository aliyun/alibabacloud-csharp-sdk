// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetSupplierInformationResponseBody : TeaModel {
        /// <summary>
        /// <para>Acr container namespace</para>
        /// 
        /// <b>Example:</b>
        /// <para>computenest</para>
        /// </summary>
        [NameInMap("AcrNamespace")]
        [Validation(Required=false)]
        public string AcrNamespace { get; set; }

        /// <summary>
        /// <para>The delivery settings.</para>
        /// </summary>
        [NameInMap("DeliverySettings")]
        [Validation(Required=false)]
        public GetSupplierInformationResponseBodyDeliverySettings DeliverySettings { get; set; }
        public class GetSupplierInformationResponseBodyDeliverySettings : TeaModel {
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
            /// <para>Indicates whether screencast delivery to Object Storage Service (OSS) is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
        /// <para>Whether to enable reseller</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableReseller")]
        [Validation(Required=false)]
        public bool? EnableReseller { get; set; }

        /// <summary>
        /// <para>The Ip of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.xxx.xxx.xxx/101</para>
        /// </summary>
        [NameInMap("OperationIp")]
        [Validation(Required=false)]
        public string OperationIp { get; set; }

        /// <summary>
        /// <para>The MFA of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OperationMfaPresent")]
        [Validation(Required=false)]
        public bool? OperationMfaPresent { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51945B04-6AA6-410D-93BA-236E0248B104</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>The name of the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud</para>
        /// </summary>
        [NameInMap("SupplierName")]
        [Validation(Required=false)]
        public string SupplierName { get; set; }

        /// <summary>
        /// <para>The URL of the service provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.xxx.xxx.cn">http://www.xxx.xxx.cn</a></para>
        /// </summary>
        [NameInMap("SupplierUrl")]
        [Validation(Required=false)]
        public string SupplierUrl { get; set; }

    }

}
