// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyScaleStrategyRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ScaleStrategyId")]
        [Validation(Required=false)]
        public string ScaleStrategyId { get; set; }

        [NameInMap("ScaleStrategyName")]
        [Validation(Required=false)]
        public string ScaleStrategyName { get; set; }

        [NameInMap("ScaleStrategyType")]
        [Validation(Required=false)]
        public string ScaleStrategyType { get; set; }

        [NameInMap("MinDesktopsCount")]
        [Validation(Required=false)]
        public int? MinDesktopsCount { get; set; }

        [NameInMap("MaxDesktopsCount")]
        [Validation(Required=false)]
        public int? MaxDesktopsCount { get; set; }

        [NameInMap("MinAvailableDesktopsCount")]
        [Validation(Required=false)]
        public int? MinAvailableDesktopsCount { get; set; }

        [NameInMap("MaxAvailableDesktopsCount")]
        [Validation(Required=false)]
        public int? MaxAvailableDesktopsCount { get; set; }

        [NameInMap("ScaleStep")]
        [Validation(Required=false)]
        public int? ScaleStep { get; set; }

    }

}
