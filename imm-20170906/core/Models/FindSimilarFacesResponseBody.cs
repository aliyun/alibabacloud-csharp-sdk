// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class FindSimilarFacesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Faces")]
        [Validation(Required=false)]
        public List<FindSimilarFacesResponseBodyFaces> Faces { get; set; }
        public class FindSimilarFacesResponseBodyFaces : TeaModel {
            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }

            [NameInMap("Similarity")]
            [Validation(Required=false)]
            public float? Similarity { get; set; }

            [NameInMap("FaceId")]
            [Validation(Required=false)]
            public string FaceId { get; set; }

            [NameInMap("ImageUri")]
            [Validation(Required=false)]
            public string ImageUri { get; set; }

            [NameInMap("SimilarFaces")]
            [Validation(Required=false)]
            public List<FindSimilarFacesResponseBodyFacesSimilarFaces> SimilarFaces { get; set; }
            public class FindSimilarFacesResponseBodyFacesSimilarFaces : TeaModel {
                [NameInMap("ExternalId")]
                [Validation(Required=false)]
                public string ExternalId { get; set; }

                [NameInMap("Similarity")]
                [Validation(Required=false)]
                public float? Similarity { get; set; }

                [NameInMap("FaceId")]
                [Validation(Required=false)]
                public string FaceId { get; set; }

                [NameInMap("ImageUri")]
                [Validation(Required=false)]
                public string ImageUri { get; set; }

                [NameInMap("FaceAttributes")]
                [Validation(Required=false)]
                public FindSimilarFacesResponseBodyFacesSimilarFacesFaceAttributes FaceAttributes { get; set; }
                public class FindSimilarFacesResponseBodyFacesSimilarFacesFaceAttributes : TeaModel {
                    [NameInMap("FaceBoundary")]
                    [Validation(Required=false)]
                    public FindSimilarFacesResponseBodyFacesSimilarFacesFaceAttributesFaceBoundary FaceBoundary { get; set; }
                    public class FindSimilarFacesResponseBodyFacesSimilarFacesFaceAttributesFaceBoundary : TeaModel {
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

                    }
                };

            }

            [NameInMap("FaceAttributes")]
            [Validation(Required=false)]
            public FindSimilarFacesResponseBodyFacesFaceAttributes FaceAttributes { get; set; }
            public class FindSimilarFacesResponseBodyFacesFaceAttributes : TeaModel {
                [NameInMap("FaceBoundary")]
                [Validation(Required=false)]
                public FindSimilarFacesResponseBodyFacesFaceAttributesFaceBoundary FaceBoundary { get; set; }
                public class FindSimilarFacesResponseBodyFacesFaceAttributesFaceBoundary : TeaModel {
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

                }
            };

        }

    }

}
