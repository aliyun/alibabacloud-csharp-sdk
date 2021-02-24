// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ImportGroupChatConversationRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public ImportGroupChatConversationRequestRequestParams RequestParams { get; set; }
        public class ImportGroupChatConversationRequestRequestParams : TeaModel {
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }
            [NameInMap("OwnerAppUid")]
            [Validation(Required=false)]
            public string OwnerAppUid { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("IconMediaId")]
            [Validation(Required=false)]
            public string IconMediaId { get; set; }
            [NameInMap("MemberLimit")]
            [Validation(Required=false)]
            public long? MemberLimit { get; set; }
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extensions { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("SilenceAll")]
            [Validation(Required=false)]
            public bool? SilenceAll { get; set; }
        };

    }

}
