// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class DescribeTaskInstanceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c-b933c5aac7f7***</para>
        /// </summary>
        [NameInMap("EmrClusterId")]
        [Validation(Required=false)]
        public string EmrClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-03-27 00:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>application_123_***</para>
        /// </summary>
        [NameInMap("ExternalAppId")]
        [Validation(Required=false)]
        public string ExternalAppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wg-123abc***</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetryTimes")]
        [Validation(Required=false)]
        public int? RetryTimes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-03-27 00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-03-27 00:00:00</para>
        /// </summary>
        [NameInMap("SubmitTime")]
        [Validation(Required=false)]
        public string SubmitTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>t-3q9jo749ne5****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ti-3q9jo749ne5****</para>
        /// </summary>
        [NameInMap("TaskInstanceId")]
        [Validation(Required=false)]
        public string TaskInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TaskInstanceName")]
        [Validation(Required=false)]
        public string TaskInstanceName { get; set; }

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
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskVersion")]
        [Validation(Required=false)]
        public string TaskVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wi-3q9jo749ne5****</para>
        /// </summary>
        [NameInMap("WorkflowInstanceId")]
        [Validation(Required=false)]
        public string WorkflowInstanceId { get; set; }

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
