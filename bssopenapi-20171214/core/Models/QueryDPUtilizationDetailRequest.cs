// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryDPUtilizationDetailRequest : TeaModel {
        /// <summary>
        /// The code of the resource, such as ecsRi and scu_bag. If this parameter is specified, the ProdCode parameter does not take effect for the request.
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// The ID of the deducted instance. If this parameter is not specified, the details of all instances are returned.
        /// </summary>
        [NameInMap("DeductedInstanceId")]
        [Validation(Required=false)]
        public string DeductedInstanceId { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the YYYY-MM-DD HH:mm:ss format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Specifies whether to query the resource plan usage of linked accounts. Valid values:
        /// 
        /// *   true: queries the resource plan usage of linked accounts.
        /// *   false: does not query the resource plan usage of linked accounts.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IncludeShare")]
        [Validation(Required=false)]
        public bool? IncludeShare { get; set; }

        /// <summary>
        /// The ID of the instance to query. If this parameter is not specified, the details of all used instances are returned.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The instance type of the instance.
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// The token that is used to retrieve the next page of results. For the first query, set the value to null. For subsequent queries, set the value to the token that is obtained from the NextToken parameter.
        /// </summary>
        [NameInMap("LastToken")]
        [Validation(Required=false)]
        public string LastToken { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20. Maximum value: 300.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The code of the service. Example: ecs.
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the YYYY-MM-DD HH:mm:ss format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
