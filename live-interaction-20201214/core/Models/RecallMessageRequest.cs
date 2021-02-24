// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class RecallMessageRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public RecallMessageRequestRequestParams RequestParams { get; set; }
        public class RecallMessageRequestRequestParams : TeaModel {
            [NameInMap("AppUid")]
            [Validation(Required=false)]
            public string AppUid { get; set; }
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }
            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public int? OperatorType { get; set; }
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extensions { get; set; }
        };

    }

}
