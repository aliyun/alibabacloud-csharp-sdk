// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class BatchAddFacesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchAddFacesResponseBodyData Data { get; set; }
        public class BatchAddFacesResponseBodyData : TeaModel {
            [NameInMap("FailedFaces")]
            [Validation(Required=false)]
            public List<BatchAddFacesResponseBodyDataFailedFaces> FailedFaces { get; set; }
            public class BatchAddFacesResponseBodyDataFailedFaces : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            [NameInMap("InsertedFaces")]
            [Validation(Required=false)]
            public List<BatchAddFacesResponseBodyDataInsertedFaces> InsertedFaces { get; set; }
            public class BatchAddFacesResponseBodyDataInsertedFaces : TeaModel {
                [NameInMap("FaceId")]
                [Validation(Required=false)]
                public string FaceId { get; set; }

                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                [NameInMap("QualitieScore")]
                [Validation(Required=false)]
                public float? QualitieScore { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
