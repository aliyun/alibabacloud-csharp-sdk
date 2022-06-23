// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVersionConfigResponseBody : TeaModel {
        [NameInMap("AllowPartialBuy")]
        [Validation(Required=false)]
        public int? AllowPartialBuy { get; set; }

        [NameInMap("AppWhiteList")]
        [Validation(Required=false)]
        public int? AppWhiteList { get; set; }

        [NameInMap("AppWhiteListAuthCount")]
        [Validation(Required=false)]
        public long? AppWhiteListAuthCount { get; set; }

        [NameInMap("AssetLevel")]
        [Validation(Required=false)]
        public int? AssetLevel { get; set; }

        [NameInMap("HighestVersion")]
        [Validation(Required=false)]
        public int? HighestVersion { get; set; }

        [NameInMap("HoneypotCapacity")]
        [Validation(Required=false)]
        public long? HoneypotCapacity { get; set; }

        [NameInMap("ImageScanCapacity")]
        [Validation(Required=false)]
        public long? ImageScanCapacity { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsNewContainerVersion")]
        [Validation(Required=false)]
        public bool? IsNewContainerVersion { get; set; }

        [NameInMap("IsOverBalance")]
        [Validation(Required=false)]
        public bool? IsOverBalance { get; set; }

        [NameInMap("IsTrialVersion")]
        [Validation(Required=false)]
        public int? IsTrialVersion { get; set; }

        [NameInMap("LastTrailEndTime")]
        [Validation(Required=false)]
        public long? LastTrailEndTime { get; set; }

        [NameInMap("MVAuthCount")]
        [Validation(Required=false)]
        public int? MVAuthCount { get; set; }

        [NameInMap("MVUnusedAuthCount")]
        [Validation(Required=false)]
        public int? MVUnusedAuthCount { get; set; }

        [NameInMap("OpenTime")]
        [Validation(Required=false)]
        public long? OpenTime { get; set; }

        [NameInMap("ReleaseTime")]
        [Validation(Required=false)]
        public long? ReleaseTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SasLog")]
        [Validation(Required=false)]
        public int? SasLog { get; set; }

        [NameInMap("SasScreen")]
        [Validation(Required=false)]
        public int? SasScreen { get; set; }

        [NameInMap("SlsCapacity")]
        [Validation(Required=false)]
        public long? SlsCapacity { get; set; }

        [NameInMap("UserDefinedAlarms")]
        [Validation(Required=false)]
        public int? UserDefinedAlarms { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

        [NameInMap("VmCores")]
        [Validation(Required=false)]
        public int? VmCores { get; set; }

        [NameInMap("WebLock")]
        [Validation(Required=false)]
        public int? WebLock { get; set; }

        [NameInMap("WebLockAuthCount")]
        [Validation(Required=false)]
        public long? WebLockAuthCount { get; set; }

    }

}
