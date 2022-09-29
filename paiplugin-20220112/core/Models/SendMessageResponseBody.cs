// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class SendMessageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SendMessageResponseBodyData Data { get; set; }
        public class SendMessageResponseBodyData : TeaModel {
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<SendMessageResponseBodyDataMessages> Messages { get; set; }
            public class SendMessageResponseBodyDataMessages : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

            }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
