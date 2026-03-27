// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateDeliveryTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>rw-5f2b4sc7es4d66</para>
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
        /// <para>Deny</para>
        /// </summary>
        [NameInMap("labelFiltersType")]
        [Validation(Required=false)]
        public string LabelFiltersType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-aekzoiafjtr7zyq</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("sinkList")]
        [Validation(Required=false)]
        public List<UpdateDeliveryTaskRequestSinkList> SinkList { get; set; }
        public class UpdateDeliveryTaskRequestSinkList : TeaModel {
            [NameInMap("sinkConfigs")]
            [Validation(Required=false)]
            public Dictionary<string, string> SinkConfigs { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>updated desc</para>
        /// </summary>
        [NameInMap("taskDescription")]
        [Validation(Required=false)]
        public string TaskDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>new-task-name</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
