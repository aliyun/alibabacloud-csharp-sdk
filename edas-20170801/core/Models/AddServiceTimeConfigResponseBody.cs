// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class AddServiceTimeConfigResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddServiceTimeConfigResponseBodyData Data { get; set; }
        public class AddServiceTimeConfigResponseBodyData : TeaModel {
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public string Timeout { get; set; }
            [NameInMap("ConsumerAppName")]
            [Validation(Required=false)]
            public string ConsumerAppName { get; set; }
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }
            [NameInMap("ConsumerAppId")]
            [Validation(Required=false)]
            public string ConsumerAppId { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
