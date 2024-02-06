// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeApplicationRequest : TeaModel {
        /// <summary>
        /// The ID of the application. You can call the ListApplications operation to obtain the application ID.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The version number of the application. Separate multiple version numbers with commas (,). If you want to query data of all versions of applications, specify All for this parameter. By default, only data of applications in the stable versions are queried.
        /// </summary>
        [NameInMap("AppVersions")]
        [Validation(Required=false)]
        public string AppVersions { get; set; }

        /// <summary>
        /// The region level by which edge resources of the application are collected. The value must be of the enumerated data type. Valid values:
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
        /// Specifies whether to return other information about the application, such as statistics on resource instances and pods. The value must be a JSON string. By default, all information is returned.
        /// </summary>
        [NameInMap("OutDetailStatParams")]
        [Validation(Required=false)]
        public string OutDetailStatParams { get; set; }

    }

}
