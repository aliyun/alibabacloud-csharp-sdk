// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopGroupRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        [NameInMap("OwnBundleId")]
        [Validation(Required=false)]
        public string OwnBundleId { get; set; }

        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        [NameInMap("DesktopGroupName")]
        [Validation(Required=false)]
        public string DesktopGroupName { get; set; }

        [NameInMap("ScaleStrategyId")]
        [Validation(Required=false)]
        public string ScaleStrategyId { get; set; }

        [NameInMap("KeepDuration")]
        [Validation(Required=false)]
        public long? KeepDuration { get; set; }

        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        [NameInMap("MinDesktopsCount")]
        [Validation(Required=false)]
        public int? MinDesktopsCount { get; set; }

        [NameInMap("MaxDesktopsCount")]
        [Validation(Required=false)]
        public int? MaxDesktopsCount { get; set; }

        [NameInMap("AllowAutoSetup")]
        [Validation(Required=false)]
        public int? AllowAutoSetup { get; set; }

        [NameInMap("AllowBufferCount")]
        [Validation(Required=false)]
        public int? AllowBufferCount { get; set; }

    }

}
