// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class SendMessageRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public SendMessageRequestRequestParams RequestParams { get; set; }
        public class SendMessageRequestRequestParams : TeaModel {
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public int? ContentType { get; set; }

            [NameInMap("ConversationType")]
            [Validation(Required=false)]
            public int? ConversationType { get; set; }

            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extensions { get; set; }

            [NameInMap("Options")]
            [Validation(Required=false)]
            public SendMessageRequestRequestParamsOptions Options { get; set; }
            public class SendMessageRequestRequestParamsOptions : TeaModel {
                [NameInMap("ReceiveScopeOption")]
                [Validation(Required=false)]
                public SendMessageRequestRequestParamsOptionsReceiveScopeOption ReceiveScopeOption { get; set; }
                public class SendMessageRequestRequestParamsOptionsReceiveScopeOption : TeaModel {
                    [NameInMap("ExcludeReceiverIds")]
                    [Validation(Required=false)]
                    public List<string> ExcludeReceiverIds { get; set; }

                    [NameInMap("ReceiveScope")]
                    [Validation(Required=false)]
                    public int? ReceiveScope { get; set; }

                    [NameInMap("ReceiverIds")]
                    [Validation(Required=false)]
                    public List<string> ReceiverIds { get; set; }

                }

                [NameInMap("RedPointPolicy")]
                [Validation(Required=false)]
                public int? RedPointPolicy { get; set; }

                [NameInMap("SingleChatCreateRequest")]
                [Validation(Required=false)]
                public SendMessageRequestRequestParamsOptionsSingleChatCreateRequest SingleChatCreateRequest { get; set; }
                public class SendMessageRequestRequestParamsOptionsSingleChatCreateRequest : TeaModel {
                    [NameInMap("AppCid")]
                    [Validation(Required=false)]
                    public string AppCid { get; set; }

                    [NameInMap("AppUids")]
                    [Validation(Required=false)]
                    public List<string> AppUids { get; set; }

                    [NameInMap("Extensions")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Extensions { get; set; }

                    [NameInMap("UserConversation")]
                    [Validation(Required=false)]
                    public Dictionary<string, RequestParamsOptionsSingleChatCreateRequestUserConversationValue> UserConversation { get; set; }

                }

            }

            [NameInMap("SenderId")]
            [Validation(Required=false)]
            public string SenderId { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
