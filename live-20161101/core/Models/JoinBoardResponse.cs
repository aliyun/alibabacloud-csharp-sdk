// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class JoinBoardResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Token")]
        [Validation(Required=true)]
        public string Token { get; set; }

        [NameInMap("BoardId")]
        [Validation(Required=true)]
        public string BoardId { get; set; }

        [NameInMap("TopicId")]
        [Validation(Required=true)]
        public string TopicId { get; set; }

        [NameInMap("KeepaliveTopic")]
        [Validation(Required=true)]
        public string KeepaliveTopic { get; set; }

        [NameInMap("KeepaliveInterval")]
        [Validation(Required=true)]
        public int? KeepaliveInterval { get; set; }

    }

}
