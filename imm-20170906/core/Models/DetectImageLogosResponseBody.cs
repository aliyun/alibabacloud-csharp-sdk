// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class DetectImageLogosResponseBody : TeaModel {
        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Logos")]
        [Validation(Required=false)]
        public List<DetectImageLogosResponseBodyLogos> Logos { get; set; }
        public class DetectImageLogosResponseBodyLogos : TeaModel {
            [NameInMap("LogoConfidence")]
            [Validation(Required=false)]
            public float? LogoConfidence { get; set; }

            [NameInMap("LogoName")]
            [Validation(Required=false)]
            public string LogoName { get; set; }

            [NameInMap("LogoBoundary")]
            [Validation(Required=false)]
            public DetectImageLogosResponseBodyLogosLogoBoundary LogoBoundary { get; set; }
            public class DetectImageLogosResponseBodyLogosLogoBoundary : TeaModel {
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
