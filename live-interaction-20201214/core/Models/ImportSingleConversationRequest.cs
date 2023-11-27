// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ImportSingleConversationRequest : TeaModel {
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
                [NameInMap("AppCid")]
                [Validation(Required=false)]
                public string AppCid { get; set; }

                [NameInMap("AppUids")]
                [Validation(Required=false)]
                public List<string> AppUids { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Extensions")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extensions { get; set; }

            }

            [NameInMap("UserConversations")]
            [Validation(Required=false)]
            public Dictionary<string, RequestParamsUserConversationsValue> UserConversations { get; set; }

        }

    }

}
