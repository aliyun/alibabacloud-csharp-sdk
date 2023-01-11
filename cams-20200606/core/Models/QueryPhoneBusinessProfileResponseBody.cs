// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class QueryPhoneBusinessProfileResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPhoneBusinessProfileResponseBodyData Data { get; set; }
        public class QueryPhoneBusinessProfileResponseBodyData : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("ProfilePictureUrl")]
            [Validation(Required=false)]
            public string ProfilePictureUrl { get; set; }

            [NameInMap("Vertical")]
            [Validation(Required=false)]
            public string Vertical { get; set; }

            [NameInMap("Websites")]
            [Validation(Required=false)]
            public List<string> Websites { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
