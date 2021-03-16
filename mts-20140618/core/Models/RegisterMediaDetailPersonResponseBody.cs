// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class RegisterMediaDetailPersonResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RegisteredPersonages")]
        [Validation(Required=false)]
        public RegisterMediaDetailPersonResponseBodyRegisteredPersonages RegisteredPersonages { get; set; }
        public class RegisterMediaDetailPersonResponseBodyRegisteredPersonages : TeaModel {
            [NameInMap("RegisteredPersonage")]
            [Validation(Required=false)]
            public List<RegisterMediaDetailPersonResponseBodyRegisteredPersonagesRegisteredPersonage> RegisteredPersonage { get; set; }
            public class RegisterMediaDetailPersonResponseBodyRegisteredPersonagesRegisteredPersonage : TeaModel {
                public string Quality { get; set; }
                public RegisterMediaDetailPersonResponseBodyRegisteredPersonagesRegisteredPersonageImageFile ImageFile { get; set; }
                public class RegisterMediaDetailPersonResponseBodyRegisteredPersonagesRegisteredPersonageImageFile : TeaModel {
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                }
                public string PersonName { get; set; }
                public string Gender { get; set; }
                public string FaceId { get; set; }
                public string Target { get; set; }
                public string ImageId { get; set; }
            }
        };

        [NameInMap("FailedImages")]
        [Validation(Required=false)]
        public RegisterMediaDetailPersonResponseBodyFailedImages FailedImages { get; set; }
        public class RegisterMediaDetailPersonResponseBodyFailedImages : TeaModel {
            [NameInMap("FailedImage")]
            [Validation(Required=false)]
            public List<RegisterMediaDetailPersonResponseBodyFailedImagesFailedImage> FailedImage { get; set; }
            public class RegisterMediaDetailPersonResponseBodyFailedImagesFailedImage : TeaModel {
                public RegisterMediaDetailPersonResponseBodyFailedImagesFailedImageImageFile ImageFile { get; set; }
                public class RegisterMediaDetailPersonResponseBodyFailedImagesFailedImageImageFile : TeaModel {
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                }
                public string Success { get; set; }
                public string Code { get; set; }
            }
        };

    }

}
