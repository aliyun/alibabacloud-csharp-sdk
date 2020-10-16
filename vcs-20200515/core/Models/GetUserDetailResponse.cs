// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetUserDetailResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetUserDetailResponseData Data { get; set; }
        public class GetUserDetailResponseData : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=true)]
            public string Address { get; set; }
            [NameInMap("Age")]
            [Validation(Required=true)]
            public string Age { get; set; }
            [NameInMap("Attachment")]
            [Validation(Required=true)]
            public string Attachment { get; set; }
            [NameInMap("BizId")]
            [Validation(Required=true)]
            public string BizId { get; set; }
            [NameInMap("FaceImageUrl")]
            [Validation(Required=true)]
            public string FaceImageUrl { get; set; }
            [NameInMap("Gender")]
            [Validation(Required=true)]
            public string Gender { get; set; }
            [NameInMap("IdNumber")]
            [Validation(Required=true)]
            public string IdNumber { get; set; }
            [NameInMap("PhoneNo")]
            [Validation(Required=true)]
            public string PhoneNo { get; set; }
            [NameInMap("PlateNo")]
            [Validation(Required=true)]
            public string PlateNo { get; set; }
            [NameInMap("UserGroupId")]
            [Validation(Required=true)]
            public int? UserGroupId { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=true)]
            public int? UserId { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=true)]
            public string UserName { get; set; }
            [NameInMap("IsvSubId")]
            [Validation(Required=true)]
            public string IsvSubId { get; set; }
        };

    }

}
