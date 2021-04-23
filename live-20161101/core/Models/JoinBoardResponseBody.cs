// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class JoinBoardResponseBody : TeaModel {
        [NameInMap("BoardId")]
        [Validation(Required=false)]
        public string BoardId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("TopicId")]
        [Validation(Required=false)]
        public string TopicId { get; set; }

        [NameInMap("KeepaliveTopic")]
        [Validation(Required=false)]
        public string KeepaliveTopic { get; set; }

        [NameInMap("KeepaliveInterval")]
        [Validation(Required=false)]
        public int? KeepaliveInterval { get; set; }

    }

}
