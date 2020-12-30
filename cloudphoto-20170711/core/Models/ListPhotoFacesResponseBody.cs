// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class ListPhotoFacesResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Faces")]
        [Validation(Required=false)]
        public List<ListPhotoFacesResponseBodyFaces> Faces { get; set; }
        public class ListPhotoFacesResponseBodyFaces : TeaModel {
            [NameInMap("FaceIdStr")]
            [Validation(Required=false)]
            public string FaceIdStr { get; set; }

            [NameInMap("FaceName")]
            [Validation(Required=false)]
            public string FaceName { get; set; }

            [NameInMap("FaceId")]
            [Validation(Required=false)]
            public long? FaceId { get; set; }

            [NameInMap("Axis")]
            [Validation(Required=false)]
            public List<string> Axis { get; set; }

        }

    }

}
