// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopGroupRequest : TeaModel {
        [NameInMap("AllowAutoSetup")]
        [Validation(Required=false)]
        public int? AllowAutoSetup { get; set; }

        [NameInMap("AllowBufferCount")]
        [Validation(Required=false)]
        public int? AllowBufferCount { get; set; }

        [NameInMap("BindAmount")]
        [Validation(Required=false)]
        public long? BindAmount { get; set; }

        [NameInMap("Classify")]
        [Validation(Required=false)]
        public string Classify { get; set; }

        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        [NameInMap("ConnectDuration")]
        [Validation(Required=false)]
        public long? ConnectDuration { get; set; }

        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        [NameInMap("DesktopGroupName")]
        [Validation(Required=false)]
        public string DesktopGroupName { get; set; }

        [NameInMap("DisableSessionConfig")]
        [Validation(Required=false)]
        public bool? DisableSessionConfig { get; set; }

        [NameInMap("IdleDisconnectDuration")]
        [Validation(Required=false)]
        public long? IdleDisconnectDuration { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("KeepDuration")]
        [Validation(Required=false)]
        public long? KeepDuration { get; set; }

        [NameInMap("LoadPolicy")]
        [Validation(Required=false)]
        public long? LoadPolicy { get; set; }

        [NameInMap("MaxDesktopsCount")]
        [Validation(Required=false)]
        public int? MaxDesktopsCount { get; set; }

        [NameInMap("MinDesktopsCount")]
        [Validation(Required=false)]
        public int? MinDesktopsCount { get; set; }

        [NameInMap("OwnBundleId")]
        [Validation(Required=false)]
        public string OwnBundleId { get; set; }

        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        [NameInMap("RatioThreshold")]
        [Validation(Required=false)]
        public float? RatioThreshold { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResetType")]
        [Validation(Required=false)]
        public long? ResetType { get; set; }

        [NameInMap("ScaleStrategyId")]
        [Validation(Required=false)]
        public string ScaleStrategyId { get; set; }

        [NameInMap("StopDuration")]
        [Validation(Required=false)]
        public long? StopDuration { get; set; }

    }

}
