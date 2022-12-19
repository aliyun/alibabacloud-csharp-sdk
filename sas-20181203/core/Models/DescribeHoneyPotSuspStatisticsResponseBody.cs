// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHoneyPotSuspStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array consisting of the top 5 VPCs or assets for which alerts are most frequently generated.
        /// </summary>
        [NameInMap("SuspHoneyPotStatisticsResponse")]
        [Validation(Required=false)]
        public List<DescribeHoneyPotSuspStatisticsResponseBodySuspHoneyPotStatisticsResponse> SuspHoneyPotStatisticsResponse { get; set; }
        public class DescribeHoneyPotSuspStatisticsResponseBodySuspHoneyPotStatisticsResponse : TeaModel {
            /// <summary>
            /// The total number of alerts that are generated for the asset.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The ID of the server.
            /// 
            /// >  This parameter is returned only if **StatisticsKeyType** is set to **uuid**.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the server.
            /// 
            /// >  This parameter is returned only if **StatisticsKeyType** is set to **uuid**.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The type of the asset. Valid values:
            /// 
            /// *   **vpcInstanceId**: VPC
            /// *   **uuid**: server
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The ID of the VPC.
            /// 
            /// >  This parameter is returned only if **StatisticsKeyType** is set to **vpcInstanceId**.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The name of the VPC.
            /// 
            /// >  This parameter is returned only if **StatisticsKeyType** is set to **vpcInstanceId**.
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

    }

}
