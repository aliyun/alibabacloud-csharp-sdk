// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class CreateKnowledgeRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("Knowledge")]
        [Validation(Required=false)]
        public CreateKnowledgeRequestKnowledge Knowledge { get; set; }
        public class CreateKnowledgeRequestKnowledge : TeaModel {
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("KnowledgeTitle")]
            [Validation(Required=false)]
            public string KnowledgeTitle { get; set; }

            [NameInMap("KnowledgeType")]
            [Validation(Required=false)]
            public int? KnowledgeType { get; set; }

            [NameInMap("Outlines")]
            [Validation(Required=false)]
            public List<CreateKnowledgeRequestKnowledgeOutlines> Outlines { get; set; }
            public class CreateKnowledgeRequestKnowledgeOutlines : TeaModel {
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

            [NameInMap("SimQuestions")]
            [Validation(Required=false)]
            public List<CreateKnowledgeRequestKnowledgeSimQuestions> SimQuestions { get; set; }
            public class CreateKnowledgeRequestKnowledgeSimQuestions : TeaModel {
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("Solutions")]
            [Validation(Required=false)]
            public List<CreateKnowledgeRequestKnowledgeSolutions> Solutions { get; set; }
            public class CreateKnowledgeRequestKnowledgeSolutions : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("PerspectiveIds")]
                [Validation(Required=false)]
                public List<string> PerspectiveIds { get; set; }

                [NameInMap("PlainText")]
                [Validation(Required=false)]
                public string PlainText { get; set; }

            }

            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

        }

    }

}
