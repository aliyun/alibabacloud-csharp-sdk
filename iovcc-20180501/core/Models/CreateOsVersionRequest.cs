// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class CreateOsVersionRequest : TeaModel {
        [NameInMap("IsForceNightUpgrade")]
        [Validation(Required=false)]
        public string IsForceNightUpgrade { get; set; }

        [NameInMap("MaxClientVersion")]
        [Validation(Required=false)]
        public string MaxClientVersion { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

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

        [NameInMap("BlackVersionList")]
        [Validation(Required=false)]
        public string BlackVersionList { get; set; }

        [NameInMap("IsMilestone")]
        [Validation(Required=false)]
        public string IsMilestone { get; set; }

        [NameInMap("MinClientVersion")]
        [Validation(Required=false)]
        public string MinClientVersion { get; set; }

        [NameInMap("WhiteVersionList")]
        [Validation(Required=false)]
        public string WhiteVersionList { get; set; }

        [NameInMap("IsForceUpgrade")]
        [Validation(Required=false)]
        public string IsForceUpgrade { get; set; }

        [NameInMap("NightUpgradeDownloadType")]
        [Validation(Required=false)]
        public string NightUpgradeDownloadType { get; set; }

        [NameInMap("NightUpgradeIsShowTip")]
        [Validation(Required=false)]
        public string NightUpgradeIsShowTip { get; set; }

        [NameInMap("NightUpgradeIsAllowedCancel")]
        [Validation(Required=false)]
        public string NightUpgradeIsAllowedCancel { get; set; }

        [NameInMap("RomList")]
        [Validation(Required=false)]
        public string RomList { get; set; }

        [NameInMap("EnableMobileDownload")]
        [Validation(Required=false)]
        public string EnableMobileDownload { get; set; }

        [NameInMap("MobileDownloadMaxSize")]
        [Validation(Required=false)]
        public string MobileDownloadMaxSize { get; set; }

    }

}
