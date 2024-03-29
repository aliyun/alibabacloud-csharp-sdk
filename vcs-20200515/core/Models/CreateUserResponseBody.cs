// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class CreateUserResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateUserResponseBodyData Data { get; set; }
        public class CreateUserResponseBodyData : TeaModel {
            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }
            [NameInMap("FaceImageUrl")]
            [Validation(Required=false)]
            public string FaceImageUrl { get; set; }
            [NameInMap("IsvSubId")]
            [Validation(Required=false)]
            public string IsvSubId { get; set; }
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public int? UserGroupId { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public int? UserId { get; set; }
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }
            [NameInMap("Attachment")]
            [Validation(Required=false)]
            public string Attachment { get; set; }
            [NameInMap("Age")]
            [Validation(Required=false)]
            public string Age { get; set; }
            [NameInMap("IdNumber")]
            [Validation(Required=false)]
            public string IdNumber { get; set; }
            [NameInMap("PhoneNo")]
            [Validation(Required=false)]
            public string PhoneNo { get; set; }
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("PlateNo")]
            [Validation(Required=false)]
            public string PlateNo { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
