// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class SetUserConversationExtensionByKeysRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 设置用户拓展字段请求实体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public SetUserConversationExtensionByKeysRequestRequestParams RequestParams { get; set; }
        public class SetUserConversationExtensionByKeysRequestRequestParams : TeaModel {
            [NameInMap("AppUid")]
            [Validation(Required=false)]
            public string AppUid { get; set; }
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extensions { get; set; }
        };

    }

}
