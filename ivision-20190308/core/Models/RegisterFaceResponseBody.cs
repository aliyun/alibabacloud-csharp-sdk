// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivision20190308.Models
{
    public class RegisterFaceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("Faces")]
        [Validation(Required=false)]
        public List<RegisterFaceResponseBodyFaces> Faces { get; set; }
        public class RegisterFaceResponseBodyFaces : TeaModel {
            [NameInMap("FaceToken")]
            [Validation(Required=false)]
            public string FaceToken { get; set; }

            [NameInMap("Rect")]
            [Validation(Required=false)]
            public RegisterFaceResponseBodyFacesRect Rect { get; set; }
            public class RegisterFaceResponseBodyFacesRect : TeaModel {
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
