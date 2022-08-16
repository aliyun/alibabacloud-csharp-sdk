// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class OctreeOption : TeaModel {
        [NameInMap("DoVoxelGridDownDownSampling")]
        [Validation(Required=false)]
        public bool? DoVoxelGridDownDownSampling { get; set; }

        [NameInMap("LibraryName")]
        [Validation(Required=false)]
        public string LibraryName { get; set; }

        [NameInMap("OctreeResolution")]
        [Validation(Required=false)]
        public double? OctreeResolution { get; set; }

        [NameInMap("PointResolution")]
        [Validation(Required=false)]
        public double? PointResolution { get; set; }

    }

}
