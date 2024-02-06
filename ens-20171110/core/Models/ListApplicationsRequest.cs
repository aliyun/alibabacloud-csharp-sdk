// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListApplicationsRequest : TeaModel {
        /// <summary>
        /// The version number of the application. Separate multiple version numbers with commas (,). If you want to query data of all versions of applications, specify All for this parameter. By default, only data of applications in the stable versions are queried.
        /// </summary>
        [NameInMap("AppVersions")]
        [Validation(Required=false)]
        public string AppVersions { get; set; }

        /// <summary>
        /// The name of the application cluster. Separate multiple names with commas (,). If you want to query applications of all clusters in your account, specify All for this parameter. Default value: All.
        /// </summary>
        [NameInMap("ClusterNames")]
        [Validation(Required=false)]
        public string ClusterNames { get; set; }

        /// <summary>
        /// The region level by which edge resources of the application are collected. The value is of the enumeration type. Valid values:
        /// 
        /// *   National: Chinese mainland
        /// *   Big: area
        /// *   Middle: province
        /// *   Small: city
        /// *   RegionId: edge node
        /// 
        /// Default value: National.
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

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
        /// Specifies whether to return other information about the application, such as statistics on resource instances and pods. The value must be a JSON string. By default, all information is returned.
        /// </summary>
        [NameInMap("OutAppInfoParams")]
        [Validation(Required=false)]
        public string OutAppInfoParams { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. This parameter is optional if you want to return all information about the applications.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. This parameter is optional if you want to return all information about the applications.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
