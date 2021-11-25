// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class GetCMSIdByForeignIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCMSIdByForeignIdResponseBodyData Data { get; set; }
        public class GetCMSIdByForeignIdResponseBodyData : TeaModel {
            [NameInMap("Anonymity")]
            [Validation(Required=false)]
            public bool? Anonymity { get; set; }
            [NameInMap("Avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }
            [NameInMap("CustomerTypeId")]
            [Validation(Required=false)]
            public int? CustomerTypeId { get; set; }
            [NameInMap("ForeignId")]
            [Validation(Required=false)]
            public string ForeignId { get; set; }
            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }
            [NameInMap("Nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
