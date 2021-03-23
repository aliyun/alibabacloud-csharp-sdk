// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeAppVersionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public DescribeAppVersionResponseBodyAppVersion AppVersion { get; set; }
        public class DescribeAppVersionResponseBodyAppVersion : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("VersionCode")]
            [Validation(Required=false)]
            public long? VersionCode { get; set; }
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }
            [NameInMap("OriginalUrl")]
            [Validation(Required=false)]
            public string OriginalUrl { get; set; }
            [NameInMap("IsForceUpgrade")]
            [Validation(Required=false)]
            public string IsForceUpgrade { get; set; }
            [NameInMap("IsSilentUpgrade")]
            [Validation(Required=false)]
            public string IsSilentUpgrade { get; set; }
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }
            [NameInMap("ApkMd5")]
            [Validation(Required=false)]
            public string ApkMd5 { get; set; }
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }
            [NameInMap("IsNeedRestart")]
            [Validation(Required=false)]
            public string IsNeedRestart { get; set; }
            [NameInMap("IsAllowNewInstall")]
            [Validation(Required=false)]
            public string IsAllowNewInstall { get; set; }
            [NameInMap("RestartType")]
            [Validation(Required=false)]
            public string RestartType { get; set; }
            [NameInMap("RestartAppType")]
            [Validation(Required=false)]
            public string RestartAppType { get; set; }
            [NameInMap("RestartAppParam")]
            [Validation(Required=false)]
            public string RestartAppParam { get; set; }
            [NameInMap("InstallType")]
            [Validation(Required=false)]
            public string InstallType { get; set; }
            [NameInMap("BlackVersionList")]
            [Validation(Required=false)]
            public string BlackVersionList { get; set; }
            [NameInMap("WhiteVersionList")]
            [Validation(Required=false)]
            public string WhiteVersionList { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("StatusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }
            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }
            [NameInMap("Adapters")]
            [Validation(Required=false)]
            public List<DescribeAppVersionResponseBodyAppVersionAdapters> Adapters { get; set; }
            public class DescribeAppVersionResponseBodyAppVersionAdapters : TeaModel {
                public long? Id { get; set; }
                public long? VersionId { get; set; }
                public string DeviceModelId { get; set; }
                public string MinOsVersion { get; set; }
                public string MaxOsVersion { get; set; }
                public string DeviceModelName { get; set; }
            }
        };

    }

}
