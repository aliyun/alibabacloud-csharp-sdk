// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class UpdateKnowledgeRequest : TeaModel {
        [NameInMap("Knowledge")]
        [Validation(Required=false)]
        public UpdateKnowledgeRequestKnowledge Knowledge { get; set; }
        public class UpdateKnowledgeRequestKnowledge : TeaModel {
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }
            [NameInMap("KnowledgeId")]
            [Validation(Required=false)]
            public long? KnowledgeId { get; set; }
            [NameInMap("KnowledgeTitle")]
            [Validation(Required=false)]
            public string KnowledgeTitle { get; set; }
            [NameInMap("KnowledgeType")]
            [Validation(Required=false)]
            public int? KnowledgeType { get; set; }
            [NameInMap("Outlines")]
            [Validation(Required=false)]
            public List<UpdateKnowledgeRequestKnowledgeOutlines> Outlines { get; set; }
            public class UpdateKnowledgeRequestKnowledgeOutlines : TeaModel {
                public string Action { get; set; }
                public long? KnowledgeId { get; set; }
                public long? OutlineId { get; set; }
                public string Title { get; set; }
            }
            [NameInMap("SimQuestions")]
            [Validation(Required=false)]
            public List<UpdateKnowledgeRequestKnowledgeSimQuestions> SimQuestions { get; set; }
            public class UpdateKnowledgeRequestKnowledgeSimQuestions : TeaModel {
                public string Action { get; set; }
                public long? SimQuestionId { get; set; }
                public string Title { get; set; }
            }
            [NameInMap("Solutions")]
            [Validation(Required=false)]
            public List<UpdateKnowledgeRequestKnowledgeSolutions> Solutions { get; set; }
            public class UpdateKnowledgeRequestKnowledgeSolutions : TeaModel {
                public string Action { get; set; }
                public string Content { get; set; }
                public List<string> PerspectiveIds { get; set; }
                public string PlainText { get; set; }
                public long? SolutionId { get; set; }
            }
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }
        };

    }

}
