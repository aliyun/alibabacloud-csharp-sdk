// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class MetadataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public MetadataResponseBodyData Data { get; set; }
        public class MetadataResponseBodyData : TeaModel {
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("HasPretendPermission")]
            [Validation(Required=false)]
            public bool? HasPretendPermission { get; set; }

            [NameInMap("InternalEndpoint")]
            [Validation(Required=false)]
            public string InternalEndpoint { get; set; }

            [NameInMap("PretendUserId")]
            [Validation(Required=false)]
            public string PretendUserId { get; set; }

            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public int? UserStatus { get; set; }

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
