// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListLgfResponseBody : TeaModel {
        [NameInMap("Lgfs")]
        [Validation(Required=false)]
        public List<ListLgfResponseBodyLgfs> Lgfs { get; set; }
        public class ListLgfResponseBodyLgfs : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 意图ID
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public long? IntentId { get; set; }

            /// <summary>
            /// LGF ID
            /// </summary>
            [NameInMap("LgfId")]
            [Validation(Required=false)]
            public long? LgfId { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// LGF规则
            /// </summary>
            [NameInMap("RuleText")]
            [Validation(Required=false)]
            public string RuleText { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
