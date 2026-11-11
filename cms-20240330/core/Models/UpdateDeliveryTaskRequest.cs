// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateDeliveryTaskRequest : TeaModel {
        /// <summary>
        /// <para>The data source ID, which is the Prometheus instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-5f2b4sc7es4d66</para>
        /// </summary>
        [NameInMap("dataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>The additional labels appended to all shipped metrics. The key is the label name, and the value is the label value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;region&quot;:&quot;cn-hangzhou&quot;}</para>
        /// </summary>
        [NameInMap("externalLabels")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExternalLabels { get; set; }

        /// <summary>
        /// <para>The metric filtering conditions. The existing conditions are entirely replaced rather than incrementally merged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;<b>name</b>&quot;:&quot;up&quot;}</para>
        /// </summary>
        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public Dictionary<string, string> LabelFilters { get; set; }

        /// <summary>
        /// <para>The metric filtering mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Deny</para>
        /// </summary>
        [NameInMap("labelFiltersType")]
        [Validation(Required=false)]
        public string LabelFiltersType { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzoiafjtr7zyq</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of shipping destinations.</para>
        /// </summary>
        [NameInMap("sinkList")]
        [Validation(Required=false)]
        public List<UpdateDeliveryTaskRequestSinkList> SinkList { get; set; }
        public class UpdateDeliveryTaskRequestSinkList : TeaModel {
            /// <summary>
            /// <para>The detailed configuration of the shipping destination. The meanings of keys and values vary based on the sink type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Url&quot;:&quot;<a href="https://example.com/api/v1/write%22,%22Network%22:%22PublicNetwork%22,%22AuthType%22:%22None%22%7D">https://example.com/api/v1/write&quot;,&quot;Network&quot;:&quot;PublicNetwork&quot;,&quot;AuthType&quot;:&quot;None&quot;}</a></para>
            /// </summary>
            [NameInMap("sinkConfigs")]
            [Validation(Required=false)]
            public Dictionary<string, string> SinkConfigs { get; set; }

            /// <summary>
            /// <para>The type of the shipping destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prometheus</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("sinkType")]
            [Validation(Required=false)]
            public string SinkType { get; set; }

        }

        /// <summary>
        /// <para>The task status, which is used to start or stop the task. Valid values:</para>
        /// <para>Enable: Starts the task.</para>
        /// <para>Disable: Stops the task.</para>
        /// <para>Running: The task is running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>updated desc</para>
        /// </summary>
        [NameInMap("taskDescription")]
        [Validation(Required=false)]
        public string TaskDescription { get; set; }

        /// <summary>
        /// <para>The task name. Chinese characters, English letters, underscores (_), and hyphens (-) are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new-task-name</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
