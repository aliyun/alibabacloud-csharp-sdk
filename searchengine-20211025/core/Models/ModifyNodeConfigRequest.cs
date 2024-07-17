// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyNodeConfigRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the index.
        /// </summary>
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// The number of data replicas.
        /// </summary>
        [NameInMap("dataDuplicateNumber")]
        [Validation(Required=false)]
        public int? DataDuplicateNumber { get; set; }

        /// <summary>
        /// The number of data shards.
        /// </summary>
        [NameInMap("dataFragmentNumber")]
        [Validation(Required=false)]
        public int? DataFragmentNumber { get; set; }

        /// <summary>
        /// The traffic percentage.
        /// </summary>
        [NameInMap("flowRatio")]
        [Validation(Required=false)]
        public int? FlowRatio { get; set; }

        /// <summary>
        /// The minimum service ratio.
        /// </summary>
        [NameInMap("minServicePercent")]
        [Validation(Required=false)]
        public int? MinServicePercent { get; set; }

        /// <summary>
        /// Specifies whether to mount the cluster.
        /// </summary>
        [NameInMap("published")]
        [Validation(Required=false)]
        public bool? Published { get; set; }

        /// <summary>
        /// The name of the cluster.
        /// </summary>
        [NameInMap("clusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// The name of the data source. Valid values: -search: search for data. -not_search: do not search for data.
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// The name of the configuration before the modification.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the algorithm. Valid values:
        /// 
        /// *   pop: a popularity model.
        /// *   cp: a category prediction model.
        /// *   hot: a top search model.
        /// *   hint: a hint model.
        /// *   suggest: a drop-down suggestions model.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
