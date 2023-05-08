// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeFieldStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The number of assets whose importance is test.
        /// </summary>
        [NameInMap("GroupedFields")]
        [Validation(Required=false)]
        public DescribeFieldStatisticsResponseBodyGroupedFields GroupedFields { get; set; }
        public class DescribeFieldStatisticsResponseBodyGroupedFields : TeaModel {
            [NameInMap("AliYunInstanceCount")]
            [Validation(Required=false)]
            public int? AliYunInstanceCount { get; set; }

            [NameInMap("AwsInstanceCount")]
            [Validation(Required=false)]
            public int? AwsInstanceCount { get; set; }

            [NameInMap("AzureInstanceCount")]
            [Validation(Required=false)]
            public int? AzureInstanceCount { get; set; }

            /// <summary>
            /// The data returned.
            /// </summary>
            [NameInMap("ExposedInstanceCount")]
            [Validation(Required=false)]
            public int? ExposedInstanceCount { get; set; }

            /// <summary>
            /// The number of server groups.
            /// </summary>
            [NameInMap("GeneralAssetCount")]
            [Validation(Required=false)]
            public int? GeneralAssetCount { get; set; }

            /// <summary>
            /// The type of the asset to query. If no asset types are specified, all types of assets are returned. Valid values:
            /// 
            /// *   **ecs**: server
            /// *   **cloud_product**: Alibaba Cloud service
            /// </summary>
            [NameInMap("GroupCount")]
            [Validation(Required=false)]
            public int? GroupCount { get; set; }

            [NameInMap("HuaweiInstanceCount")]
            [Validation(Required=false)]
            public int? HuaweiInstanceCount { get; set; }

            /// <summary>
            /// DescribeFieldStatistics
            /// </summary>
            [NameInMap("IdcInstanceCount")]
            [Validation(Required=false)]
            public int? IdcInstanceCount { get; set; }

            /// <summary>
            /// The number of assets that are at risk.
            /// </summary>
            [NameInMap("ImportantAssetCount")]
            [Validation(Required=false)]
            public int? ImportantAssetCount { get; set; }

            /// <summary>
            /// The number of assets that are deployed on Alibaba Cloud.
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// The number of assets whose importance is common.
            /// </summary>
            [NameInMap("InstanceSyncTaskCount")]
            [Validation(Required=false)]
            public int? InstanceSyncTaskCount { get; set; }

            /// <summary>
            /// The number of assets whose statuses are unknown.
            /// </summary>
            [NameInMap("NewInstanceCount")]
            [Validation(Required=false)]
            public int? NewInstanceCount { get; set; }

            /// <summary>
            /// The number of servers that are shut down.
            /// </summary>
            [NameInMap("NoRiskInstanceCount")]
            [Validation(Required=false)]
            public int? NoRiskInstanceCount { get; set; }

            /// <summary>
            /// WB01224678
            /// </summary>
            [NameInMap("NotRunningStatusCount")]
            [Validation(Required=false)]
            public int? NotRunningStatusCount { get; set; }

            /// <summary>
            /// The number of unprotected assets.
            /// </summary>
            [NameInMap("OfflineInstanceCount")]
            [Validation(Required=false)]
            public int? OfflineInstanceCount { get; set; }

            [NameInMap("OutMachineInstanceCount")]
            [Validation(Required=false)]
            public int? OutMachineInstanceCount { get; set; }

            /// <summary>
            /// Queries the statistics of assets that belong to your account.
            /// </summary>
            [NameInMap("PauseInstanceCount")]
            [Validation(Required=false)]
            public int? PauseInstanceCount { get; set; }

            /// <summary>
            /// The number of virtual private clouds (VPCs).
            /// </summary>
            [NameInMap("RegionCount")]
            [Validation(Required=false)]
            public int? RegionCount { get; set; }

            [NameInMap("RiskInstanceCount")]
            [Validation(Required=false)]
            public int? RiskInstanceCount { get; set; }

            /// <summary>
            /// The number of servers.
            /// </summary>
            [NameInMap("TencentInstanceCount")]
            [Validation(Required=false)]
            public int? TencentInstanceCount { get; set; }

            /// <summary>
            /// The number of servers outside the cloud.
            /// </summary>
            [NameInMap("TestAssetCount")]
            [Validation(Required=false)]
            public int? TestAssetCount { get; set; }

            [NameInMap("TripartiteInstanceCount")]
            [Validation(Required=false)]
            public int? TripartiteInstanceCount { get; set; }

            /// <summary>
            /// The number of newly added servers.
            /// </summary>
            [NameInMap("UnKnowStatusInstanceCount")]
            [Validation(Required=false)]
            public int? UnKnowStatusInstanceCount { get; set; }

            /// <summary>
            /// The number of servers whose Security Center agent status is Offline.
            /// </summary>
            [NameInMap("UnprotectedInstanceCount")]
            [Validation(Required=false)]
            public int? UnprotectedInstanceCount { get; set; }

            /// <summary>
            /// The ID of the request, which is used to locate and troubleshoot issues.
            /// </summary>
            [NameInMap("VpcCount")]
            [Validation(Required=false)]
            public int? VpcCount { get; set; }

        }

        /// <summary>
        /// The information about servers that are returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
