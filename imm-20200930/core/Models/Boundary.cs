// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Boundary : TeaModel {
        [NameInMap("Height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        [NameInMap("Left")]
        [Validation(Required=false)]
        public long? Left { get; set; }

        [NameInMap("Polygon")]
        [Validation(Required=false)]
        public List<PointInt64> Polygon { get; set; }

        [NameInMap("Top")]
        [Validation(Required=false)]
        public long? Top { get; set; }

        [NameInMap("Width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

    }

}
