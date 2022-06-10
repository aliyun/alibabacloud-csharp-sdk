// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListSimQuestionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 相似问列表
        /// </summary>
        [NameInMap("SimQuestions")]
        [Validation(Required=false)]
        public List<ListSimQuestionResponseBodySimQuestions> SimQuestions { get; set; }
        public class ListSimQuestionResponseBodySimQuestions : TeaModel {
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
            /// 相似问ID
            /// </summary>
            [NameInMap("SimQuestionId")]
            [Validation(Required=false)]
            public long? SimQuestionId { get; set; }

            /// <summary>
            /// 相似问标题
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
