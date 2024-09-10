// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunStepByStepWritingRequest : TeaModel {
        [NameInMap("OriginSessionId")]
        [Validation(Required=false)]
        public string OriginSessionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("ReferenceData")]
        [Validation(Required=false)]
        public RunStepByStepWritingRequestReferenceData ReferenceData { get; set; }
        public class RunStepByStepWritingRequestReferenceData : TeaModel {
            [NameInMap("Articles")]
            [Validation(Required=false)]
            public List<RunStepByStepWritingRequestReferenceDataArticles> Articles { get; set; }
            public class RunStepByStepWritingRequestReferenceDataArticles : TeaModel {
                [NameInMap("Author")]
                [Validation(Required=false)]
                public string Author { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("DocId")]
                [Validation(Required=false)]
                public string DocId { get; set; }

                [NameInMap("DocUuid")]
                [Validation(Required=false)]
                public string DocUuid { get; set; }

                [NameInMap("MediaUrl")]
                [Validation(Required=false)]
                public string MediaUrl { get; set; }

                [NameInMap("PubTime")]
                [Validation(Required=false)]
                public string PubTime { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("MiniDoc")]
            [Validation(Required=false)]
            public List<string> MiniDoc { get; set; }

            [NameInMap("Outlines")]
            [Validation(Required=false)]
            public List<RunStepByStepWritingRequestReferenceDataOutlines> Outlines { get; set; }
            public class RunStepByStepWritingRequestReferenceDataOutlines : TeaModel {
                [NameInMap("Articles")]
                [Validation(Required=false)]
                public List<RunStepByStepWritingRequestReferenceDataOutlinesArticles> Articles { get; set; }
                public class RunStepByStepWritingRequestReferenceDataOutlinesArticles : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("Outline")]
                [Validation(Required=false)]
                public string Outline { get; set; }

            }

            [NameInMap("Summarization")]
            [Validation(Required=false)]
            public List<string> Summarization { get; set; }

        }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("WritingConfig")]
        [Validation(Required=false)]
        public RunStepByStepWritingRequestWritingConfig WritingConfig { get; set; }
        public class RunStepByStepWritingRequestWritingConfig : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            [NameInMap("PromptTag")]
            [Validation(Required=false)]
            public RunStepByStepWritingRequestWritingConfigPromptTag PromptTag { get; set; }
            public class RunStepByStepWritingRequestWritingConfigPromptTag : TeaModel {
                [NameInMap("NecessaryTips")]
                [Validation(Required=false)]
                public string NecessaryTips { get; set; }

                [NameInMap("Position")]
                [Validation(Required=false)]
                public string Position { get; set; }

                [NameInMap("ReverseWords")]
                [Validation(Required=false)]
                public string ReverseWords { get; set; }

                [NameInMap("Theme")]
                [Validation(Required=false)]
                public string Theme { get; set; }

            }

            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            [NameInMap("Step")]
            [Validation(Required=false)]
            public string Step { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<RunStepByStepWritingRequestWritingConfigTags> Tags { get; set; }
            public class RunStepByStepWritingRequestWritingConfigTags : TeaModel {
                [NameInMap("Keyword")]
                [Validation(Required=false)]
                public string Keyword { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            [NameInMap("UseSearch")]
            [Validation(Required=false)]
            public bool? UseSearch { get; set; }

        }

    }

}
