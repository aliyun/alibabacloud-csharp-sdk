// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class RemoveUserConversationExtensionByKeysRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 移除用户拓展字段请求实体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public RemoveUserConversationExtensionByKeysRequestRequestParams RequestParams { get; set; }
        public class RemoveUserConversationExtensionByKeysRequestRequestParams : TeaModel {
            [NameInMap("AppUid")]
            [Validation(Required=false)]
            public string AppUid { get; set; }
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
            [NameInMap("Keys")]
            [Validation(Required=false)]
            public List<string> Keys { get; set; }
        };

    }

}
