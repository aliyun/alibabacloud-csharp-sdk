// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeNodeMetricsResponseBody : TeaModel {
        [NameInMap("NodeMetrics")]
        [Validation(Required=false)]
        public string NodeMetrics { get; set; }

        /// <summary>
        /// You can call this operation to query the detailed metrics information of an OceanBase Database node.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// ```
        /// http(s)://[Endpoint]/?Action=DescribeNodeMetrics
        /// &InstanceId=ob317v4uif****
        /// &PageSize=10
        /// &PageNumber=1
        /// &TenantId=ob2mr3oae0****
        /// &StartTime=2021-06-13 15:40:43
        /// &EndTime=2021-09-13 15:40:43
        /// &Metrics=tps
        /// &NodeName=i-bp16niirq4zdmgvm****
        /// &NodeIdList=["i-bp19y05uq6xpacyqnlrc","i-bp1blcr3htr3g3u2vqvu","i-bp1392ikhayhr3hi4fli"]
        /// &Common request parameters
        /// ```
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
