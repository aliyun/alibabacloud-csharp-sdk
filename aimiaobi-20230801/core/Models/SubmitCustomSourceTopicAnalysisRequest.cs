// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitCustomSourceTopicAnalysisRequest : TeaModel {
        [NameInMap("AnalysisTypes")]
        [Validation(Required=false)]
        public List<string> AnalysisTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>json</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com/xxx.json">http://www.example.com/xxx.json</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxTopicSize")]
        [Validation(Required=false)]
        public int? MaxTopicSize { get; set; }

        [NameInMap("News")]
        [Validation(Required=false)]
        public List<SubmitCustomSourceTopicAnalysisRequestNews> News { get; set; }
        public class SubmitCustomSourceTopicAnalysisRequestNews : TeaModel {
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public List<SubmitCustomSourceTopicAnalysisRequestNewsComments> Comments { get; set; }
            public class SubmitCustomSourceTopicAnalysisRequestNewsComments : TeaModel {
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-22 10:29:00</para>
            /// </summary>
            [NameInMap("PubTime")]
            [Validation(Required=false)]
            public string PubTime { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com/xxx.html">http://www.example.com/xxx.html</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
