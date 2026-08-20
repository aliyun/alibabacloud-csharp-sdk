// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeLicenseResponseBody : TeaModel {
        /// <summary>
        /// <para>The license object.</para>
        /// </summary>
        [NameInMap("License")]
        [Validation(Required=false)]
        public DescribeLicenseResponseBodyLicense License { get; set; }
        public class DescribeLicenseResponseBodyLicense : TeaModel {
            /// <summary>
            /// <para>The activation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-25 09:00:00</para>
            /// </summary>
            [NameInMap("ActivateTime")]
            [Validation(Required=false)]
            public string ActivateTime { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-25 09:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-06-25 09:00:00</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("ExtendArray")]
            [Validation(Required=false)]
            public DescribeLicenseResponseBodyLicenseExtendArray ExtendArray { get; set; }
            public class DescribeLicenseResponseBodyLicenseExtendArray : TeaModel {
                [NameInMap("LicenseAttribute")]
                [Validation(Required=false)]
                public List<DescribeLicenseResponseBodyLicenseExtendArrayLicenseAttribute> LicenseAttribute { get; set; }
                public class DescribeLicenseResponseBodyLicenseExtendArrayLicenseAttribute : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The extended information.</para>
            /// </summary>
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public DescribeLicenseResponseBodyLicenseExtendInfo ExtendInfo { get; set; }
            public class DescribeLicenseResponseBodyLicenseExtendInfo : TeaModel {
                /// <summary>
                /// <para>The account information.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("AccountQuantity")]
                [Validation(Required=false)]
                public long? AccountQuantity { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud UID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>190311111111****</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                /// <summary>
                /// <para>The email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id***@**.com</para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The mobile phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>129****1111</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

            }

            /// <summary>
            /// <para>The business instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1551111111</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The activation code.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("LicenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }

            /// <summary>
            /// <para>The license status.</para>
            /// <list type="bullet">
            /// <item><description>ACTIVATED</description></item>
            /// <item><description>INACTIVATED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVATED</para>
            /// </summary>
            [NameInMap("LicenseStatus")]
            [Validation(Required=false)]
            public string LicenseStatus { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmgj02****</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LNMP环境</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The product SKU ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmgj02****-prepay</para>
            /// </summary>
            [NameInMap("ProductSkuId")]
            [Validation(Required=false)]
            public string ProductSkuId { get; set; }

            /// <summary>
            /// <para>The supplier name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>**科技股份有限公司</para>
            /// </summary>
            [NameInMap("SupplierName")]
            [Validation(Required=false)]
            public string SupplierName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EF60BEC-0242-43AF-BB20-270359FB54A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
