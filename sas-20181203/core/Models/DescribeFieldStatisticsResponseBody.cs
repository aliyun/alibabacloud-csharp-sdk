// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeFieldStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The information about servers that are returned.
        /// </summary>
        [NameInMap("GroupedFields")]
        [Validation(Required=false)]
        public DescribeFieldStatisticsResponseBodyGroupedFields GroupedFields { get; set; }
        public class DescribeFieldStatisticsResponseBodyGroupedFields : TeaModel {
            /// <summary>
            /// The number of assets that are deployed on Alibaba Cloud.
            /// </summary>
            [NameInMap("AliYunInstanceCount")]
            [Validation(Required=false)]
            public int? AliYunInstanceCount { get; set; }

            /// <summary>
            /// The number of servers.
            /// </summary>
            [NameInMap("AwsInstanceCount")]
            [Validation(Required=false)]
            public int? AwsInstanceCount { get; set; }

            /// <summary>
            /// The number of third-party cloud servers.
            /// </summary>
            [NameInMap("AzureInstanceCount")]
            [Validation(Required=false)]
            public int? AzureInstanceCount { get; set; }

            /// <summary>
            /// The number of cores of exposed assets.
            /// </summary>
            [NameInMap("ExposedInstanceCoreCount")]
            [Validation(Required=false)]
            public long? ExposedInstanceCoreCount { get; set; }

            /// <summary>
            /// The number of exposed servers.
            /// </summary>
            [NameInMap("ExposedInstanceCount")]
            [Validation(Required=false)]
            public int? ExposedInstanceCount { get; set; }

            /// <summary>
            /// The number of assets whose importance is common.
            /// </summary>
            [NameInMap("GeneralAssetCount")]
            [Validation(Required=false)]
            public int? GeneralAssetCount { get; set; }

            /// <summary>
            /// The number of server groups.
            /// </summary>
            [NameInMap("GroupCount")]
            [Validation(Required=false)]
            public int? GroupCount { get; set; }

            /// <summary>
            /// The number of instances that are provisioned by third-party providers.
            /// </summary>
            [NameInMap("HuaweiInstanceCount")]
            [Validation(Required=false)]
            public int? HuaweiInstanceCount { get; set; }

            /// <summary>
            /// The number of assets that can be protected by Security Center.
            /// </summary>
            [NameInMap("IdcInstanceCount")]
            [Validation(Required=false)]
            public int? IdcInstanceCount { get; set; }

            /// <summary>
            /// The number of assets whose importance is important.
            /// </summary>
            [NameInMap("ImportantAssetCount")]
            [Validation(Required=false)]
            public int? ImportantAssetCount { get; set; }

            /// <summary>
            /// The number of cores of assets in the specified asset type. If the asset type is not specified, the value of this parameter indicates the total number of cores of servers and Alibaba Cloud services within your account.
            /// </summary>
            [NameInMap("InstanceCoreCount")]
            [Validation(Required=false)]
            public long? InstanceCoreCount { get; set; }

            /// <summary>
            /// The total number of assets of the specified type. If no asset types are specified, this parameter indicates the total number of all servers and Alibaba Cloud services within your account.
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// The total number of tasks for the specified type of assets. If no asset types are specified, this parameter indicates the total number of all servers and Alibaba Cloud services within your account.
            /// </summary>
            [NameInMap("InstanceSyncTaskCount")]
            [Validation(Required=false)]
            public int? InstanceSyncTaskCount { get; set; }

            /// <summary>
            /// The number of cores of new servers.
            /// </summary>
            [NameInMap("NewInstanceCoreCount")]
            [Validation(Required=false)]
            public long? NewInstanceCoreCount { get; set; }

            /// <summary>
            /// The number of newly added servers.
            /// </summary>
            [NameInMap("NewInstanceCount")]
            [Validation(Required=false)]
            public int? NewInstanceCount { get; set; }

            /// <summary>
            /// The number of servers on which no risks are detected.
            /// </summary>
            [NameInMap("NoRiskInstanceCount")]
            [Validation(Required=false)]
            public int? NoRiskInstanceCount { get; set; }

            [NameInMap("NotBindMachineInstanceCount")]
            [Validation(Required=false)]
            public int? NotBindMachineInstanceCount { get; set; }

            /// <summary>
            /// The number of cores of servers that are not started.
            /// </summary>
            [NameInMap("NotRunningStatusCoreCount")]
            [Validation(Required=false)]
            public long? NotRunningStatusCoreCount { get; set; }

            /// <summary>
            /// The number of servers that are shut down.
            /// </summary>
            [NameInMap("NotRunningStatusCount")]
            [Validation(Required=false)]
            public int? NotRunningStatusCount { get; set; }

            /// <summary>
            /// The number of servers whose Security Center agent status is Offline.
            /// </summary>
            [NameInMap("OfflineInstanceCount")]
            [Validation(Required=false)]
            public int? OfflineInstanceCount { get; set; }

            /// <summary>
            /// The number of servers outside the cloud.
            /// </summary>
            [NameInMap("OutMachineInstanceCount")]
            [Validation(Required=false)]
            public int? OutMachineInstanceCount { get; set; }

            /// <summary>
            /// The number of servers for which the Security Center agent suspends protection.
            /// </summary>
            [NameInMap("PauseInstanceCount")]
            [Validation(Required=false)]
            public int? PauseInstanceCount { get; set; }

            /// <summary>
            /// The number of regions to which the servers belong.
            /// </summary>
            [NameInMap("RegionCount")]
            [Validation(Required=false)]
            public int? RegionCount { get; set; }

            /// <summary>
            /// The number of cores of vulnerable assets.
            /// </summary>
            [NameInMap("RiskInstanceCoreCount")]
            [Validation(Required=false)]
            public long? RiskInstanceCoreCount { get; set; }

            /// <summary>
            /// The number of assets that are at risk.
            /// </summary>
            [NameInMap("RiskInstanceCount")]
            [Validation(Required=false)]
            public int? RiskInstanceCount { get; set; }

            /// <summary>
            /// The total number of cloud services that are protected by Security Center.
            /// </summary>
            [NameInMap("TencentInstanceCount")]
            [Validation(Required=false)]
            public int? TencentInstanceCount { get; set; }

            /// <summary>
            /// The number of assets whose importance is test.
            /// </summary>
            [NameInMap("TestAssetCount")]
            [Validation(Required=false)]
            public int? TestAssetCount { get; set; }

            /// <summary>
            /// The number of simple application servers.
            /// </summary>
            [NameInMap("TripartiteInstanceCount")]
            [Validation(Required=false)]
            public int? TripartiteInstanceCount { get; set; }

            /// <summary>
            /// The number of servers that are in the Unknown state.
            /// </summary>
            [NameInMap("UnKnowStatusInstanceCount")]
            [Validation(Required=false)]
            public int? UnKnowStatusInstanceCount { get; set; }

            /// <summary>
            /// The number of cores of unprotected assets.
            /// </summary>
            [NameInMap("UnprotectedInstanceCoreCount")]
            [Validation(Required=false)]
            public long? UnprotectedInstanceCoreCount { get; set; }

            /// <summary>
            /// The number of unprotected assets.
            /// </summary>
            [NameInMap("UnprotectedInstanceCount")]
            [Validation(Required=false)]
            public int? UnprotectedInstanceCount { get; set; }

            /// <summary>
            /// The number of virtual private clouds (VPCs).
            /// </summary>
            [NameInMap("VpcCount")]
            [Validation(Required=false)]
            public int? VpcCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
