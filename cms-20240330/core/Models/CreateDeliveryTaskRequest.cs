// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateDeliveryTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-xxxxxx</para>
        /// </summary>
        [NameInMap("dataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        [NameInMap("externalLabels")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExternalLabels { get; set; }

        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public Dictionary<string, string> LabelFilters { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Allow</para>
        /// </summary>
        [NameInMap("labelFiltersType")]
        [Validation(Required=false)]
        public string LabelFiltersType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-ae******ey</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sinkList")]
        [Validation(Required=false)]
        public List<CreateDeliveryTaskRequestSinkList> SinkList { get; set; }
        public class CreateDeliveryTaskRequestSinkList : TeaModel {
            [NameInMap("sinkConfigs")]
            [Validation(Required=false)]
            public Dictionary<string, string> SinkConfigs { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prometheus</para>
            /// </summary>
            [NameInMap("sinkType")]
            [Validation(Required=false)]
            public string SinkType { get; set; }

        }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateDeliveryTaskRequestTags> Tags { get; set; }
        public class CreateDeliveryTaskRequestTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>_cms_workspace</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my delivery task</para>
        /// </summary>
        [NameInMap("taskDescription")]
        [Validation(Required=false)]
        public string TaskDescription { get; set; }

        /// <summary>
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
