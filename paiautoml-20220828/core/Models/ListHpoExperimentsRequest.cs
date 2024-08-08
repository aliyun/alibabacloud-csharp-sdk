// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiAutoML20220828.Models
{
    public class ListHpoExperimentsRequest : TeaModel {
        /// <summary>
        /// The accessibility of the experiments to be listed.
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// Who created the expriment.
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// Return experiment detailed configuration or not.
        /// </summary>
        [NameInMap("IncludeConfigData")]
        [Validation(Required=false)]
        public string IncludeConfigData { get; set; }

        /// <summary>
        /// The maximum create time of the experiment.
        /// </summary>
        [NameInMap("MaxCreateTime")]
        [Validation(Required=false)]
        public string MaxCreateTime { get; set; }

        /// <summary>
        /// The minimum create time of the experiment.
        /// </summary>
        [NameInMap("MinCreateTime")]
        [Validation(Required=false)]
        public string MinCreateTime { get; set; }

        /// <summary>
        /// Experiment name filter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// ASC, DESC.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Record number on each page
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The returned experiments to be sorted by this column.
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// Experiment status to be listed.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The AI workspace ID the experiments belongs to.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
