// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateDeliveryTaskRequest : TeaModel {
        /// <summary>
        /// <para>The data source ID (Prometheus instance ID).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-5f2b4sc7es4d66</para>
        /// </summary>
        [NameInMap("dataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>Additional labels to attach to all delivered metrics, specified as key-value pairs.</para>
        /// </summary>
        [NameInMap("externalLabels")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExternalLabels { get; set; }

        /// <summary>
        /// <para>The labels for filtering metrics. This operation replaces the entire existing filter; incremental updates are not supported.</para>
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
        /// <para>The list of sinks.</para>
        /// </summary>
        [NameInMap("sinkList")]
        [Validation(Required=false)]
        public List<UpdateDeliveryTaskRequestSinkList> SinkList { get; set; }
        public class UpdateDeliveryTaskRequestSinkList : TeaModel {
            /// <summary>
            /// <para>The detailed configuration of the sink. The meaning of the key-value pairs depends on the specified sinkType.</para>
            /// </summary>
            [NameInMap("sinkConfigs")]
            [Validation(Required=false)]
            public Dictionary<string, string> SinkConfigs { get; set; }

            /// <summary>
            /// <para>The sink type.</para>
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
        /// <para>The status of the delivery task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
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
        /// <para>The name of the delivery task. The name can include Chinese characters, English letters, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>new-task-name</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
