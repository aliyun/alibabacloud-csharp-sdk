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
                public string Code { get; set; }
                public string ImageURL { get; set; }
                public string Message { get; set; }
            }
            [NameInMap("InsertedFaces")]
            [Validation(Required=false)]
            public List<BatchAddFacesResponseBodyDataInsertedFaces> InsertedFaces { get; set; }
            public class BatchAddFacesResponseBodyDataInsertedFaces : TeaModel {
                public string FaceId { get; set; }
                public string ImageURL { get; set; }
                public float? QualitieScore { get; set; }
            }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
