// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wuying_personal_pc20251111.Models
{
    public class DescribeImageDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageDetailResponseBodyData Data { get; set; }
        public class DescribeImageDetailResponseBodyData : TeaModel {
            [NameInMap("CurrentImageCodeInfo")]
            [Validation(Required=false)]
            public DescribeImageDetailResponseBodyDataCurrentImageCodeInfo CurrentImageCodeInfo { get; set; }
            public class DescribeImageDetailResponseBodyDataCurrentImageCodeInfo : TeaModel {
                [NameInMap("CurrentPassword")]
                [Validation(Required=false)]
                public string CurrentPassword { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("ImageCode")]
                [Validation(Required=false)]
                public string ImageCode { get; set; }

                [NameInMap("IsCopyPassword")]
                [Validation(Required=false)]
                public bool? IsCopyPassword { get; set; }

                [NameInMap("IsEncrypted")]
                [Validation(Required=false)]
                public bool? IsEncrypted { get; set; }

                [NameInMap("IsFree")]
                [Validation(Required=false)]
                public bool? IsFree { get; set; }

                [NameInMap("PeriodDays")]
                [Validation(Required=false)]
                public int? PeriodDays { get; set; }

                [NameInMap("RedeemCount")]
                [Validation(Required=false)]
                public int? RedeemCount { get; set; }

                [NameInMap("RedeemQuota")]
                [Validation(Required=false)]
                public int? RedeemQuota { get; set; }

            }

            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EnableStartUpConfig")]
            [Validation(Required=false)]
            public bool? EnableStartUpConfig { get; set; }

            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ImageScope")]
            [Validation(Required=false)]
            public string ImageScope { get; set; }

            [NameInMap("IsGpu")]
            [Validation(Required=false)]
            public bool? IsGpu { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("ShareCodes")]
            [Validation(Required=false)]
            public List<string> ShareCodes { get; set; }

            [NameInMap("ShareCodesIncludeDisable")]
            [Validation(Required=false)]
            public List<string> ShareCodesIncludeDisable { get; set; }

            [NameInMap("Shared")]
            [Validation(Required=false)]
            public bool? Shared { get; set; }

            [NameInMap("SourceDesktopType")]
            [Validation(Required=false)]
            public string SourceDesktopType { get; set; }

            [NameInMap("StartUpFileList")]
            [Validation(Required=false)]
            public List<string> StartUpFileList { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
