// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeARMServerInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// The container specifications.
        /// </summary>
        [NameInMap("AICSpecs")]
        [Validation(Required=false)]
        public string AICSpecsShrink { get; set; }

        /// <summary>
        /// Spcifies whether the result contains the container information. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("DescribeAICInstances")]
        [Validation(Required=false)]
        public bool? DescribeAICInstances { get; set; }

        /// <summary>
        /// The IDs of the Edge Node Service (ENS) nodes.
        /// </summary>
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public string EnsRegionIdsShrink { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the 2006-01-02 format. By default, the time range to query is not restricted.
        /// </summary>
        [NameInMap("MaxDate")]
        [Validation(Required=false)]
        public string MaxDate { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the 2006-01-02 format. By default, the time range to query is not restricted.
        /// </summary>
        [NameInMap("MinDate")]
        [Validation(Required=false)]
        public string MinDate { get; set; }

        /// <summary>
        /// The name of the server.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The namespace.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The sorting order of the results to return. Valid values: ServerIdSort, ServerNameSort, ExpireTimeSort, CreationTimeSort, and EnsRegionIdSort.
        /// 
        /// asc: ascending order. desc: descending order.
        /// </summary>
        [NameInMap("OrderByParams")]
        [Validation(Required=false)]
        public string OrderByParams { get; set; }

        /// <summary>
        /// The page number. Pages start from page **1**.
        /// 
        /// Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. The maximum value is **100**.
        /// 
        /// Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The IDs of the ARM servers.
        /// </summary>
        [NameInMap("ServerIds")]
        [Validation(Required=false)]
        public string ServerIdsShrink { get; set; }

        /// <summary>
        /// The server specifications.
        /// </summary>
        [NameInMap("ServerSpecs")]
        [Validation(Required=false)]
        public string ServerSpecsShrink { get; set; }

        /// <summary>
        /// The operation statuses.
        /// </summary>
        [NameInMap("States")]
        [Validation(Required=false)]
        public string StatesShrink { get; set; }

    }

}
