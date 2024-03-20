// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyNodeConfigRequest : TeaModel {
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        [NameInMap("dataDuplicateNumber")]
        [Validation(Required=false)]
        public int? DataDuplicateNumber { get; set; }

        [NameInMap("dataFragmentNumber")]
        [Validation(Required=false)]
        public int? DataFragmentNumber { get; set; }

        [NameInMap("flowRatio")]
        [Validation(Required=false)]
        public int? FlowRatio { get; set; }

        [NameInMap("minServicePercent")]
        [Validation(Required=false)]
        public int? MinServicePercent { get; set; }

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
        /// The name of the data source. Valid values: search and not_search. search indicates to search data. not_search indicates not to search data.
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// The original name of the node.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the algorithm. Valid values: pop, cp, hot, hint, and suggest.
        /// 
        /// *   pop indicates the popularity model.
        /// *   cp indicates the category prediction model.
        /// *   hot indicates the top search model.
        /// *   hint indicates the hint model.
        /// *   suggest indicates the drop-down suggestion model.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
