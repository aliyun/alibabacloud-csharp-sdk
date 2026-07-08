// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunTitleGenerationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A collection of titles to deduplicate against the newly generated titles. The total character count for all titles must not exceed 5K.</para>
        /// </summary>
        [NameInMap("DeduplicatedTitles")]
        [Validation(Required=false)]
        public string DeduplicatedTitlesShrink { get; set; }

        /// <summary>
        /// <para>Data for title generation.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ReferenceData")]
        [Validation(Required=false)]
        public string ReferenceDataShrink { get; set; }

        /// <summary>
        /// <para>The unique identifier for the associated creative article.</para>
        /// <remarks>
        /// <para>The system automatically generates the TaskId by default. You do not need to specify it. If subsequent tasks use the same TaskId, they belong to the same conversation group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Number of titles to generate, maximum 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TitleCount")]
        [Validation(Required=false)]
        public string TitleCount { get; set; }

        /// <summary>
        /// <para>The unique identifier for the Alibaba Cloud Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get the workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
