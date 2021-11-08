// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class DescribeKnowledgeResponseBody : TeaModel {
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        [NameInMap("CoreWords")]
        [Validation(Required=false)]
        public List<string> CoreWords { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("KeyWords")]
        [Validation(Required=false)]
        public List<string> KeyWords { get; set; }

        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public long? KnowledgeId { get; set; }

        [NameInMap("KnowledgeStatus")]
        [Validation(Required=false)]
        public int? KnowledgeStatus { get; set; }

        [NameInMap("KnowledgeTitle")]
        [Validation(Required=false)]
        public string KnowledgeTitle { get; set; }

        [NameInMap("KnowledgeType")]
        [Validation(Required=false)]
        public int? KnowledgeType { get; set; }

        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        [NameInMap("Outlines")]
        [Validation(Required=false)]
        public List<DescribeKnowledgeResponseBodyOutlines> Outlines { get; set; }
        public class DescribeKnowledgeResponseBodyOutlines : TeaModel {
            [NameInMap("KnowledgeId")]
            [Validation(Required=false)]
            public long? KnowledgeId { get; set; }

            [NameInMap("OutlineId")]
            [Validation(Required=false)]
            public long? OutlineId { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SimQuestions")]
        [Validation(Required=false)]
        public List<DescribeKnowledgeResponseBodySimQuestions> SimQuestions { get; set; }
        public class DescribeKnowledgeResponseBodySimQuestions : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("SimQuestionId")]
            [Validation(Required=false)]
            public long? SimQuestionId { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("Solutions")]
        [Validation(Required=false)]
        public List<DescribeKnowledgeResponseBodySolutions> Solutions { get; set; }
        public class DescribeKnowledgeResponseBodySolutions : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("PerspectiveIds")]
            [Validation(Required=false)]
            public List<string> PerspectiveIds { get; set; }

            [NameInMap("PlainText")]
            [Validation(Required=false)]
            public string PlainText { get; set; }

            [NameInMap("SolutionId")]
            [Validation(Required=false)]
            public long? SolutionId { get; set; }

            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

        }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
