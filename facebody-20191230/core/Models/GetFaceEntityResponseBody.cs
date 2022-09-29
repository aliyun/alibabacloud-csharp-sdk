// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class GetFaceEntityResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFaceEntityResponseBodyData Data { get; set; }
        public class GetFaceEntityResponseBodyData : TeaModel {
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            [NameInMap("Faces")]
            [Validation(Required=false)]
            public List<GetFaceEntityResponseBodyDataFaces> Faces { get; set; }
            public class GetFaceEntityResponseBodyDataFaces : TeaModel {
                [NameInMap("FaceId")]
                [Validation(Required=false)]
                public string FaceId { get; set; }

            }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public string Labels { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
