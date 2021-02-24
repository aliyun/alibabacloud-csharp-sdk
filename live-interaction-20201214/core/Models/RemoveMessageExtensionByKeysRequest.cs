// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class RemoveMessageExtensionByKeysRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public RemoveMessageExtensionByKeysRequestRequestParams RequestParams { get; set; }
        public class RemoveMessageExtensionByKeysRequestRequestParams : TeaModel {
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }
            [NameInMap("Keys")]
            [Validation(Required=false)]
            public List<string> Keys { get; set; }
        };

    }

}
