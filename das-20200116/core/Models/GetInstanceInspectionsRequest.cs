// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetInstanceInspectionsRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// >  The end time must be later than the start time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The database engine. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **Redis**
        /// *   **PolarDBMySQL**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The type of the instance on which the database is deployed. Valid values:
        /// 
        /// *   **RDS**: an Alibaba Cloud database instance.
        /// *   **ECS**: an ECS instance on which a self-managed database is deployed.
        /// *   **IDC**: a self-managed database instance that is not deployed on Alibaba Cloud.
        /// 
        /// >  The value IDC specifies that the instance is deployed in a data center.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceArea")]
        [Validation(Required=false)]
        public string InstanceArea { get; set; }

        /// <summary>
        /// The page number. The value must be a positive integer. Default value: 1.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The filter condition, which can be specified in one of the following formats:
        /// 
        /// *   Specify the ID of a single instance in the {"InstanceId":"Instance ID"} format.
        /// *   Specify the IDs of multiple instances in the {"InstanceIds":["Instance ID1","Instance ID2"]} format. Separate the instance IDs with commas (,).
        /// *   Specify the region in which the instance resides in the {"region":"Region of the instance"} format.
        /// </summary>
        [NameInMap("SearchMap")]
        [Validation(Required=false)]
        public string SearchMap { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
