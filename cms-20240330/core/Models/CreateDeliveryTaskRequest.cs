// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateDeliveryTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Prometheus instance that serves as the data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-xxxxxx</para>
        /// </summary>
        [NameInMap("dataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>A map of key-value pairs to attach as additional labels to all delivered metrics.</para>
        /// </summary>
        [NameInMap("externalLabels")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExternalLabels { get; set; }

        /// <summary>
        /// <para>The label conditions for filtering metrics. The key is the label name and the value is the value to match. The filtering behavior is controlled by <c>labelFiltersType</c>.</para>
        /// </summary>
        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public Dictionary<string, string> LabelFilters { get; set; }

        /// <summary>
        /// <para>The mode for applying the label filters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Allow</para>
        /// </summary>
        [NameInMap("labelFiltersType")]
        [Validation(Required=false)]
        public string LabelFiltersType { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ae******ey</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>An array of delivery destination objects.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sinkList")]
        [Validation(Required=false)]
        public List<CreateDeliveryTaskRequestSinkList> SinkList { get; set; }
        public class CreateDeliveryTaskRequestSinkList : TeaModel {
            /// <summary>
            /// <para>The configuration for the sink, specified as key-value pairs. The valid keys and values depend on the value of <c>sinkType</c>.</para>
            /// </summary>
            [NameInMap("sinkConfigs")]
            [Validation(Required=false)]
            public Dictionary<string, string> SinkConfigs { get; set; }

            /// <summary>
            /// <para>The type of the delivery destination (sink).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prometheus</para>
            /// </summary>
            [NameInMap("sinkType")]
            [Validation(Required=false)]
            public string SinkType { get; set; }

        }

        /// <summary>
        /// <para>An array of resource tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateDeliveryTaskRequestTags> Tags { get; set; }
        public class CreateDeliveryTaskRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the resource tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_cms_workspace</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the resource tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The task description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my delivery task</para>
        /// </summary>
        [NameInMap("taskDescription")]
        [Validation(Required=false)]
        public string TaskDescription { get; set; }

        /// <summary>
        /// <para>The name of the task. The name can contain Chinese characters, English letters, underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-task</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
