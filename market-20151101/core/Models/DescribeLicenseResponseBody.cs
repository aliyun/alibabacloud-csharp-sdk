// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeLicenseResponseBody : TeaModel {
        [NameInMap("License")]
        [Validation(Required=false)]
        public DescribeLicenseResponseBodyLicense License { get; set; }
        public class DescribeLicenseResponseBodyLicense : TeaModel {
            [NameInMap("ActivateTime")]
            [Validation(Required=false)]
            public string ActivateTime { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

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

            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public DescribeLicenseResponseBodyLicenseExtendInfo ExtendInfo { get; set; }
            public class DescribeLicenseResponseBodyLicenseExtendInfo : TeaModel {
                [NameInMap("AccountQuantity")]
                [Validation(Required=false)]
                public long? AccountQuantity { get; set; }

                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("LicenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }

            [NameInMap("LicenseStatus")]
            [Validation(Required=false)]
            public string LicenseStatus { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("ProductSkuId")]
            [Validation(Required=false)]
            public string ProductSkuId { get; set; }

            [NameInMap("SupplierName")]
            [Validation(Required=false)]
            public string SupplierName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
