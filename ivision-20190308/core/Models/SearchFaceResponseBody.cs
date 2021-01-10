// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivision20190308.Models
{
    public class SearchFaceResponseBody : TeaModel {
        [NameInMap("Rect")]
        [Validation(Required=false)]
        public SearchFaceResponseBodyRect Rect { get; set; }
        public class SearchFaceResponseBodyRect : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FaceResults")]
        [Validation(Required=false)]
        public List<SearchFaceResponseBodyFaceResults> FaceResults { get; set; }
        public class SearchFaceResponseBodyFaceResults : TeaModel {
            [NameInMap("FaceToken")]
            [Validation(Required=false)]
            public string FaceToken { get; set; }

            [NameInMap("Probability")]
            [Validation(Required=false)]
            public float? Probability { get; set; }

        }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

    }

}
