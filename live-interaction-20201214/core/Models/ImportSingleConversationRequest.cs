// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ImportSingleConversationRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public ImportSingleConversationRequestRequestParams RequestParams { get; set; }
        public class ImportSingleConversationRequestRequestParams : TeaModel {
            [NameInMap("Conversation")]
            [Validation(Required=false)]
            public ImportSingleConversationRequestRequestParamsConversation Conversation { get; set; }
            public class ImportSingleConversationRequestRequestParamsConversation : TeaModel {
                /// <summary>
                /// 会话ID
                /// </summary>
                [NameInMap("AppCid")]
                [Validation(Required=false)]
                public string AppCid { get; set; }

                /// <summary>
                /// 用户ID列表
                /// </summary>
                [NameInMap("AppUids")]
                [Validation(Required=false)]
                public List<string> AppUids { get; set; }

                /// <summary>
                /// 扩展字段
                /// </summary>
                [NameInMap("Extensions")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extensions { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

            }
            [NameInMap("UserConversations")]
            [Validation(Required=false)]
            public Dictionary<string, string> UserConversations { get; set; }
        };

    }

}
