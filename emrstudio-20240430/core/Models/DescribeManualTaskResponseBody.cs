// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class DescribeManualTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-03-27 00:00:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mt-3q9jo749ne5****</para>
        /// </summary>
        [NameInMap("ManualTaskId")]
        [Validation(Required=false)]
        public string ManualTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ManualTaskName")]
        [Validation(Required=false)]
        public string ManualTaskName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mtd-oy98v7n43el****</para>
        /// </summary>
        [NameInMap("ParentDirectoryId")]
        [Validation(Required=false)]
        public string ParentDirectoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>p-3q9jo749ne5****</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>r-oy98v7n43el****</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;yarnUser&quot;: &quot;&quot;,
        ///     &quot;conditionResult&quot;: &quot;null&quot;,
        ///     &quot;rawScript&quot;: &quot;sleep 300&quot;,
        ///     &quot;submitOnYarnFlag&quot;: false,
        ///     &quot;emrClusterId&quot;: &quot;&quot;,
        ///     &quot;yarnPriority&quot;: &quot;&quot;,
        ///     &quot;dependence&quot;: &quot;null&quot;,
        ///     &quot;yarnMemory&quot;: &quot;&quot;,
        ///     &quot;localParams&quot;: [],
        ///     &quot;switchResult&quot;: &quot;null&quot;,
        ///     &quot;resourceList&quot;: [],
        ///     &quot;yarnQueue&quot;: &quot;&quot;,
        ///     &quot;yarnVCores&quot;: &quot;&quot;,
        ///     &quot;associateManualTaskFlag&quot;: false
        /// }</para>
        /// </summary>
        [NameInMap("TaskParams")]
        [Validation(Required=false)]
        public string TaskParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SHELL</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-03-27 00:00:00</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
