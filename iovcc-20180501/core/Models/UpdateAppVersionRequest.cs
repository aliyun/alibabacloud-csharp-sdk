// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class UpdateAppVersionRequest : TeaModel {
        [NameInMap("BlackVersionList")]
        [Validation(Required=false)]
        public string BlackVersionList { get; set; }

        [NameInMap("IsAllowNewInstall")]
        [Validation(Required=false)]
        public string IsAllowNewInstall { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

        [NameInMap("InstallType")]
        [Validation(Required=false)]
        public string InstallType { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("IsForceUpgrade")]
        [Validation(Required=false)]
        public string IsForceUpgrade { get; set; }

        [NameInMap("IsSilentUpgrade")]
        [Validation(Required=false)]
        public string IsSilentUpgrade { get; set; }

        [NameInMap("IsNeedRestart")]
        [Validation(Required=false)]
        public string IsNeedRestart { get; set; }

        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        [NameInMap("ReleaseNote")]
        [Validation(Required=false)]
        public string ReleaseNote { get; set; }

        [NameInMap("WhiteVersionList")]
        [Validation(Required=false)]
        public string WhiteVersionList { get; set; }

        [NameInMap("RestartType")]
        [Validation(Required=false)]
        public string RestartType { get; set; }

        [NameInMap("RestartAppType")]
        [Validation(Required=false)]
        public string RestartAppType { get; set; }

        [NameInMap("RestartAppParam")]
        [Validation(Required=false)]
        public string RestartAppParam { get; set; }

        [NameInMap("DeviceAdapterList")]
        [Validation(Required=false)]
        public string DeviceAdapterList { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("ApkMd5")]
        [Validation(Required=false)]
        public string ApkMd5 { get; set; }

    }

}
