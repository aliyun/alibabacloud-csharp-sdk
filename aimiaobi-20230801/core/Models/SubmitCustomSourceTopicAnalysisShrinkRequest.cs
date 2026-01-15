// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitCustomSourceTopicAnalysisShrinkRequest : TeaModel {
        [NameInMap("AnalysisTypes")]
        [Validation(Required=false)]
        public string AnalysisTypesShrink { get; set; }

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
        public string NewsShrink { get; set; }

        [NameInMap("Topics")]
        [Validation(Required=false)]
        public string TopicsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com/xxx.jsonline">http://www.example.com/xxx.jsonline</a></para>
        /// </summary>
        [NameInMap("TopicsFileUrl")]
        [Validation(Required=false)]
        public string TopicsFileUrl { get; set; }

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
