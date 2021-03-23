// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeOsVersionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OsVersion")]
        [Validation(Required=false)]
        public DescribeOsVersionResponseBodyOsVersion OsVersion { get; set; }
        public class DescribeOsVersionResponseBodyOsVersion : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("DeviceModelId")]
            [Validation(Required=false)]
            public string DeviceModelId { get; set; }
            [NameInMap("SystemVersion")]
            [Validation(Required=false)]
            public string SystemVersion { get; set; }
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("BlackVersionList")]
            [Validation(Required=false)]
            public string BlackVersionList { get; set; }
            [NameInMap("WhiteVersionList")]
            [Validation(Required=false)]
            public string WhiteVersionList { get; set; }
            [NameInMap("MinClientVersion")]
            [Validation(Required=false)]
            public string MinClientVersion { get; set; }
            [NameInMap("MaxClientVersion")]
            [Validation(Required=false)]
            public string MaxClientVersion { get; set; }
            [NameInMap("IsMilestone")]
            [Validation(Required=false)]
            public string IsMilestone { get; set; }
            [NameInMap("IsForceUpgrade")]
            [Validation(Required=false)]
            public string IsForceUpgrade { get; set; }
            [NameInMap("IsForceNightUpgrade")]
            [Validation(Required=false)]
            public string IsForceNightUpgrade { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }
            [NameInMap("StatusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }
            [NameInMap("DeviceModelName")]
            [Validation(Required=false)]
            public string DeviceModelName { get; set; }
            [NameInMap("EnableMobileDownload")]
            [Validation(Required=false)]
            public string EnableMobileDownload { get; set; }
            [NameInMap("MobileDownloadMaxSize")]
            [Validation(Required=false)]
            public string MobileDownloadMaxSize { get; set; }
            [NameInMap("RomList")]
            [Validation(Required=false)]
            public List<DescribeOsVersionResponseBodyOsVersionRomList> RomList { get; set; }
            public class DescribeOsVersionResponseBodyOsVersionRomList : TeaModel {
                public long? Id { get; set; }
                public long? VersionId { get; set; }
                public string BaseVersion { get; set; }
                public string DownloadUrl { get; set; }
                public string OriginalUrl { get; set; }
                public string Md5 { get; set; }
                public string Size { get; set; }
                public string SplitNum { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModify { get; set; }
            }
            [NameInMap("NightUpgradeOption")]
            [Validation(Required=false)]
            public DescribeOsVersionResponseBodyOsVersionNightUpgradeOption NightUpgradeOption { get; set; }
            public class DescribeOsVersionResponseBodyOsVersionNightUpgradeOption : TeaModel {
                [NameInMap("DownloadType")]
                [Validation(Required=false)]
                public string DownloadType { get; set; }

                [NameInMap("IsShowTip")]
                [Validation(Required=false)]
                public string IsShowTip { get; set; }

                [NameInMap("IsAllowedCancel")]
                [Validation(Required=false)]
                public string IsAllowedCancel { get; set; }

            }
        };

    }

}
