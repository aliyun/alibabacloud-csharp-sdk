// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class SendMessageRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 消息发送请求体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public SendMessageRequestRequestParams RequestParams { get; set; }
        public class SendMessageRequestRequestParams : TeaModel {
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
            [NameInMap("ConversationType")]
            [Validation(Required=false)]
            public int? ConversationType { get; set; }
            [NameInMap("SenderId")]
            [Validation(Required=false)]
            public string SenderId { get; set; }
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public int? ContentType { get; set; }
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extensions { get; set; }
            [NameInMap("Options")]
            [Validation(Required=false)]
            public SendMessageRequestRequestParamsOptions Options { get; set; }
            public class SendMessageRequestRequestParamsOptions : TeaModel {
                /// <summary>
                /// 未读消息小红点控制。0:增加小红点; 1:不增加小红点
                /// </summary>
                [NameInMap("RedPointPolicy")]
                [Validation(Required=false)]
                public int? RedPointPolicy { get; set; }

                /// <summary>
                /// 接受相关设置
                /// </summary>
                [NameInMap("ReceiveScopeOption")]
                [Validation(Required=false)]
                public SendMessageRequestRequestParamsOptionsReceiveScopeOption ReceiveScopeOption { get; set; }
                public class SendMessageRequestRequestParamsOptionsReceiveScopeOption : TeaModel {
                    [NameInMap("ReceiverIds")]
                    [Validation(Required=false)]
                    public List<string> ReceiverIds { get; set; }
                    [NameInMap("ExcludeReceiverIds")]
                    [Validation(Required=false)]
                    public List<string> ExcludeReceiverIds { get; set; }
                    [NameInMap("ReceiveScope")]
                    [Validation(Required=false)]
                    public int? ReceiveScope { get; set; }
                };

                /// <summary>
                /// 单聊会话不存在时新建自定义单聊请求体
                /// </summary>
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
                    public Dictionary<string, string> UserConversation { get; set; }
                };

            }
        };

    }

}
