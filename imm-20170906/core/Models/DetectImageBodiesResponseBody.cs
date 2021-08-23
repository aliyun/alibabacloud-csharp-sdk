// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class DetectImageBodiesResponseBody : TeaModel {
        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Bodies")]
        [Validation(Required=false)]
        public List<DetectImageBodiesResponseBodyBodies> Bodies { get; set; }
        public class DetectImageBodiesResponseBodyBodies : TeaModel {
            [NameInMap("BodyConfidence")]
            [Validation(Required=false)]
            public float? BodyConfidence { get; set; }

            [NameInMap("BodyBoundary")]
            [Validation(Required=false)]
            public DetectImageBodiesResponseBodyBodiesBodyBoundary BodyBoundary { get; set; }
            public class DetectImageBodiesResponseBodyBodiesBodyBoundary : TeaModel {
                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }
                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }
            };

        }

    }

}
