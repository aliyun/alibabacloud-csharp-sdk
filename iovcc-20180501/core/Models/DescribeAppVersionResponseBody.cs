// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeAppVersionResponseBody : TeaModel {
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public DescribeAppVersionResponseBodyAppVersion AppVersion { get; set; }
        public class DescribeAppVersionResponseBodyAppVersion : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("IsAllowNewInstall")]
            [Validation(Required=false)]
            public string IsAllowNewInstall { get; set; }
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }
            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }
            [NameInMap("StatusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }
            [NameInMap("ApkMd5")]
            [Validation(Required=false)]
            public string ApkMd5 { get; set; }
            [NameInMap("RestartAppParam")]
            [Validation(Required=false)]
            public string RestartAppParam { get; set; }
            [NameInMap("WhiteVersionList")]
            [Validation(Required=false)]
            public string WhiteVersionList { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("RestartAppType")]
            [Validation(Required=false)]
            public string RestartAppType { get; set; }
            [NameInMap("VersionCode")]
            [Validation(Required=false)]
            public long? VersionCode { get; set; }
            [NameInMap("BlackVersionList")]
            [Validation(Required=false)]
            public string BlackVersionList { get; set; }
            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }
            [NameInMap("Adapters")]
            [Validation(Required=false)]
            public List<DescribeAppVersionResponseBodyAppVersionAdapters> Adapters { get; set; }
            public class DescribeAppVersionResponseBodyAppVersionAdapters : TeaModel {
                public string DeviceModelId { get; set; }
                public string MaxOsVersion { get; set; }
                public string MinOsVersion { get; set; }
                public long? VersionId { get; set; }
                public long? Id { get; set; }
                public string DeviceModelName { get; set; }
            }
            [NameInMap("IsSilentUpgrade")]
            [Validation(Required=false)]
            public string IsSilentUpgrade { get; set; }
            [NameInMap("InstallType")]
            [Validation(Required=false)]
            public string InstallType { get; set; }
            [NameInMap("IsNeedRestart")]
            [Validation(Required=false)]
            public string IsNeedRestart { get; set; }
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }
            [NameInMap("RestartType")]
            [Validation(Required=false)]
            public string RestartType { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }
            [NameInMap("IsForceUpgrade")]
            [Validation(Required=false)]
            public string IsForceUpgrade { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("OriginalUrl")]
            [Validation(Required=false)]
            public string OriginalUrl { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
