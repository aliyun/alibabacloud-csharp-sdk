// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetCustomerInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomerInfoResponseBodyData Data { get; set; }
        public class GetCustomerInfoResponseBodyData : TeaModel {
            [NameInMap("CustomizeFields")]
            [Validation(Required=false)]
            public Dictionary<string, object> CustomizeFields { get; set; }

            [NameInMap("Nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            [NameInMap("OuterId")]
            [Validation(Required=false)]
            public string OuterId { get; set; }

            [NameInMap("Photo")]
            [Validation(Required=false)]
            public string Photo { get; set; }

            [NameInMap("RealName")]
            [Validation(Required=false)]
            public string RealName { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

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
