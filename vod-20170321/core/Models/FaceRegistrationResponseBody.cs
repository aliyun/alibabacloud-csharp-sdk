// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class FaceRegistrationResponseBody : TeaModel {
        [NameInMap("NonExistImageIds")]
        [Validation(Required=false)]
        public FaceRegistrationResponseBodyNonExistImageIds NonExistImageIds { get; set; }
        public class FaceRegistrationResponseBodyNonExistImageIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        [NameInMap("RegisteredPerson")]
        [Validation(Required=false)]
        public FaceRegistrationResponseBodyRegisteredPerson RegisteredPerson { get; set; }
        public class FaceRegistrationResponseBodyRegisteredPerson : TeaModel {
            [NameInMap("Faces")]
            [Validation(Required=false)]
            public FaceRegistrationResponseBodyRegisteredPersonFaces Faces { get; set; }
            public class FaceRegistrationResponseBodyRegisteredPersonFaces : TeaModel {
                [NameInMap("Face")]
                [Validation(Required=false)]
                public List<FaceRegistrationResponseBodyRegisteredPersonFacesFace> Face { get; set; }
                public class FaceRegistrationResponseBodyRegisteredPersonFacesFace : TeaModel {
                    [NameInMap("ImageId")]
                    [Validation(Required=false)]
                    public string ImageId { get; set; }

                    [NameInMap("Quality")]
                    [Validation(Required=false)]
                    public string Quality { get; set; }

                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public string Target { get; set; }

                }

            }

            [NameInMap("PersonId")]
            [Validation(Required=false)]
            public string PersonId { get; set; }

            [NameInMap("PersonName")]
            [Validation(Required=false)]
            public string PersonName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
