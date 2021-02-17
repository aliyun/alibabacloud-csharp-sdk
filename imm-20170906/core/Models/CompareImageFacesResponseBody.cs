// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class CompareImageFacesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Similarity")]
        [Validation(Required=false)]
        public float? Similarity { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

        [NameInMap("FaceA")]
        [Validation(Required=false)]
        public CompareImageFacesResponseBodyFaceA FaceA { get; set; }
        public class CompareImageFacesResponseBodyFaceA : TeaModel {
            [NameInMap("FaceId")]
            [Validation(Required=false)]
            public string FaceId { get; set; }
            [NameInMap("FaceAttributes")]
            [Validation(Required=false)]
            public CompareImageFacesResponseBodyFaceAFaceAttributes FaceAttributes { get; set; }
            public class CompareImageFacesResponseBodyFaceAFaceAttributes : TeaModel {
                [NameInMap("FaceBoundary")]
                [Validation(Required=false)]
                public CompareImageFacesResponseBodyFaceAFaceAttributesFaceBoundary FaceBoundary { get; set; }
                public class CompareImageFacesResponseBodyFaceAFaceAttributesFaceBoundary : TeaModel {
                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public int? Top { get; set; }
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }
                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public int? Left { get; set; }
                };

            }
        };

        [NameInMap("FaceB")]
        [Validation(Required=false)]
        public CompareImageFacesResponseBodyFaceB FaceB { get; set; }
        public class CompareImageFacesResponseBodyFaceB : TeaModel {
            [NameInMap("FaceId")]
            [Validation(Required=false)]
            public string FaceId { get; set; }
            [NameInMap("FaceAttributes")]
            [Validation(Required=false)]
            public CompareImageFacesResponseBodyFaceBFaceAttributes FaceAttributes { get; set; }
            public class CompareImageFacesResponseBodyFaceBFaceAttributes : TeaModel {
                [NameInMap("FaceBoundary")]
                [Validation(Required=false)]
                public CompareImageFacesResponseBodyFaceBFaceAttributesFaceBoundary FaceBoundary { get; set; }
                public class CompareImageFacesResponseBodyFaceBFaceAttributesFaceBoundary : TeaModel {
                    [NameInMap("Top")]
                    [Validation(Required=false)]
                    public int? Top { get; set; }
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }
                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public int? Left { get; set; }
                };

            }
        };

    }

}
