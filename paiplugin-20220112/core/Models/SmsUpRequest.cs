// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class SmsUpRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<SmsUpRequestBody> Body { get; set; }
        public class SmsUpRequestBody : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("dest_code")]
            [Validation(Required=false)]
            public string DestCode { get; set; }

            [NameInMap("phone_number")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            [NameInMap("send_time")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            [NameInMap("sequence_id")]
            [Validation(Required=false)]
            public int? SequenceId { get; set; }

            [NameInMap("sign_name")]
            [Validation(Required=false)]
            public string SignName { get; set; }

        }

    }

}
