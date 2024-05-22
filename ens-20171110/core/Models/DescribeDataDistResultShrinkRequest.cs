// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataDistResultShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The name of the data file. Separate multiple names with commas (,). By default, all data files are queried.
        /// </summary>
        [NameInMap("DataNames")]
        [Validation(Required=false)]
        public string DataNames { get; set; }

        /// <summary>
        /// The version number of the data file. Separate multiple numbers with commas (,). By default, all versions of data files are queried.
        /// </summary>
        [NameInMap("DataVersions")]
        [Validation(Required=false)]
        public string DataVersions { get; set; }

        /// <summary>
        /// The IDs of the ENS nodes.
        /// </summary>
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public string EnsRegionIdsShrink { get; set; }

        /// <summary>
        /// The IDs of ENS instances. Separate multiple IDs with commas (,). By default, all instances are queried.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

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
        /// The page number. Pages start from page 1. This parameter is optional if you want to return the distribution status of all data files.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. This parameter is optional if you want to return the distribution status of all data files.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
