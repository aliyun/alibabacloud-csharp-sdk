// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Multimediaai20190810.Models
{
    public class ListFacePersonsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("FacePersons")]
        [Validation(Required=false)]
        public List<ListFacePersonsResponseBodyFacePersons> FacePersons { get; set; }
        public class ListFacePersonsResponseBodyFacePersons : TeaModel {
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            [NameInMap("ImageCount")]
            [Validation(Required=false)]
            public long? ImageCount { get; set; }

            [NameInMap("FacePersonId")]
            [Validation(Required=false)]
            public long? FacePersonId { get; set; }

            [NameInMap("FacePersonName")]
            [Validation(Required=false)]
            public string FacePersonName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
