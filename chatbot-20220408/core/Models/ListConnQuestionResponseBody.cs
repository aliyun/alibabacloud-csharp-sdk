// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListConnQuestionResponseBody : TeaModel {
        [NameInMap("Outlines")]
        [Validation(Required=false)]
        public List<ListConnQuestionResponseBodyOutlines> Outlines { get; set; }
        public class ListConnQuestionResponseBodyOutlines : TeaModel {
            /// <summary>
            /// 关联知识ID
            /// </summary>
            [NameInMap("ConnQuestionId")]
            [Validation(Required=false)]
            public long? ConnQuestionId { get; set; }

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
            /// 关联关系ID
            /// </summary>
            [NameInMap("OutlineId")]
            [Validation(Required=false)]
            public long? OutlineId { get; set; }

            /// <summary>
            /// 关联知识题目
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
