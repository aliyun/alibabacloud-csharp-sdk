// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AsyncEditTimelineShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Enable automatic clip adjustment</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoClips")]
        [Validation(Required=false)]
        public bool? AutoClips { get; set; }

        /// <summary>
        /// <para>Unique identifier of the task</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0dbf1055f8a2475d99904c3b76a0ffba</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Array structure of video editing timelines</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Timelines")]
        [Validation(Required=false)]
        public string TimelinesShrink { get; set; }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/2782167.html">Model Studio workspace ID</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-az2gglkjauwnnhpq</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
