// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaKopilot20260414.Models
{
    public class KopilotChatStreamResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Delta")]
        [Validation(Required=false)]
        public string Delta { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("RunId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        [NameInMap("ThreadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

        [NameInMap("ToolCallId")]
        [Validation(Required=false)]
        public string ToolCallId { get; set; }

        [NameInMap("ToolCallName")]
        [Validation(Required=false)]
        public string ToolCallName { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
