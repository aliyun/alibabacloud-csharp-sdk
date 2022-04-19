// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class CreateKnowledgeRequest : TeaModel {
        /// <summary>
        /// 业务空间key,不设置则访问默认业务空间，key值在主账号业务管理页面获取
        /// </summary>
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
                public long? KnowledgeId { get; set; }
                public long? OutlineId { get; set; }
                public string Title { get; set; }
            }
            [NameInMap("SimQuestions")]
            [Validation(Required=false)]
            public List<CreateKnowledgeRequestKnowledgeSimQuestions> SimQuestions { get; set; }
            public class CreateKnowledgeRequestKnowledgeSimQuestions : TeaModel {
                public string Title { get; set; }
            }
            [NameInMap("Solutions")]
            [Validation(Required=false)]
            public List<CreateKnowledgeRequestKnowledgeSolutions> Solutions { get; set; }
            public class CreateKnowledgeRequestKnowledgeSolutions : TeaModel {
                public string Content { get; set; }
                public List<string> PerspectiveIds { get; set; }
                public string PlainText { get; set; }
            }
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }
        };

    }

}
