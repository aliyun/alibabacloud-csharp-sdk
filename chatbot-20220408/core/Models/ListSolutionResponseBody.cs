// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListSolutionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 答案列表
        /// </summary>
        [NameInMap("Solutions")]
        [Validation(Required=false)]
        public List<ListSolutionResponseBodySolutions> Solutions { get; set; }
        public class ListSolutionResponseBodySolutions : TeaModel {
            /// <summary>
            /// 答案内容
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 答案类型(0纯文本，1富文本）
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public int? ContentType { get; set; }

            /// <summary>
            /// 创建时间(UTC 时间)
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 修改时间(UTC 时间)
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// 视角code列表
            /// </summary>
            [NameInMap("PerspectiveCodes")]
            [Validation(Required=false)]
            public List<string> PerspectiveCodes { get; set; }

            /// <summary>
            /// 答案纯文本内容
            /// </summary>
            [NameInMap("PlainText")]
            [Validation(Required=false)]
            public string PlainText { get; set; }

            /// <summary>
            /// 答案ID
            /// </summary>
            [NameInMap("SolutionId")]
            [Validation(Required=false)]
            public long? SolutionId { get; set; }

        }

    }

}
