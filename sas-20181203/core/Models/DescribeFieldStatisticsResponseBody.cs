// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeFieldStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the queried server assets.</para>
        /// </summary>
        [NameInMap("GroupedFields")]
        [Validation(Required=false)]
        public DescribeFieldStatisticsResponseBodyGroupedFields GroupedFields { get; set; }
        public class DescribeFieldStatisticsResponseBodyGroupedFields : TeaModel {
            /// <summary>
            /// <para>The number of assets that belong to Alibaba Cloud server groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AliYunInstanceCount")]
            [Validation(Required=false)]
            public int? AliYunInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of third-party cloud servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AwsInstanceCount")]
            [Validation(Required=false)]
            public int? AwsInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of third-party cloud servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AzureInstanceCount")]
            [Validation(Required=false)]
            public int? AzureInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of third-party cloud servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BaiduInstanceCount")]
            [Validation(Required=false)]
            public int? BaiduInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of CPU cores of exposed assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("ExposedInstanceCoreCount")]
            [Validation(Required=false)]
            public long? ExposedInstanceCoreCount { get; set; }

            /// <summary>
            /// <para>The number of exposed assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExposedInstanceCount")]
            [Validation(Required=false)]
            public int? ExposedInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of general assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("GeneralAssetCount")]
            [Validation(Required=false)]
            public int? GeneralAssetCount { get; set; }

            /// <summary>
            /// <para>The number of third-party cloud servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("GoogleInstanceCount")]
            [Validation(Required=false)]
            public int? GoogleInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of server groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("GroupCount")]
            [Validation(Required=false)]
            public int? GroupCount { get; set; }

            /// <summary>
            /// <para>The number of third-party cloud servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HuaweiInstanceCount")]
            [Validation(Required=false)]
            public int? HuaweiInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of assets that can be detected by Security Center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("IdcInstanceCount")]
            [Validation(Required=false)]
            public int? IdcInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of important assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ImportantAssetCount")]
            [Validation(Required=false)]
            public int? ImportantAssetCount { get; set; }

            /// <summary>
            /// <para>The total number of CPU cores of all assets of the specified type. If no asset type is specified, this value is the sum of the CPU cores of all servers and cloud services in your assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>301</para>
            /// </summary>
            [NameInMap("InstanceCoreCount")]
            [Validation(Required=false)]
            public long? InstanceCoreCount { get; set; }

            /// <summary>
            /// <para>The total number of assets of the specified type. If no asset type is specified, this value is the sum of all servers and cloud services in your assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>The number of tasks for the specified asset type. If no asset type is specified, this value is the sum of tasks for all servers and cloud services in your assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InstanceSyncTaskCount")]
            [Validation(Required=false)]
            public int? InstanceSyncTaskCount { get; set; }

            /// <summary>
            /// <para>The number of third-party cloud servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("KingsoftInstanceCount")]
            [Validation(Required=false)]
            public int? KingsoftInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of CPU cores of newly added servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("NewInstanceCoreCount")]
            [Validation(Required=false)]
            public long? NewInstanceCoreCount { get; set; }

            /// <summary>
            /// <para>The number of newly added servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("NewInstanceCount")]
            [Validation(Required=false)]
            public int? NewInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of assets that are not a risky asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("NoRiskInstanceCount")]
            [Validation(Required=false)]
            public int? NoRiskInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of Asset Types that do not attach or have no authorization under the specified asset type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("NotBindMachineInstanceCount")]
            [Validation(Required=false)]
            public int? NotBindMachineInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of CPU cores of stopped servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("NotRunningStatusCoreCount")]
            [Validation(Required=false)]
            public long? NotRunningStatusCoreCount { get; set; }

            /// <summary>
            /// <para>The number of stopped servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("NotRunningStatusCount")]
            [Validation(Required=false)]
            public int? NotRunningStatusCount { get; set; }

            /// <summary>
            /// <para>The number of offline servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("OfflineInstanceCount")]
            [Validation(Required=false)]
            public int? OfflineInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of third-party cloud servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OracleInstanceCount")]
            [Validation(Required=false)]
            public int? OracleInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of instances outside Alibaba Cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("OutMachineInstanceCount")]
            [Validation(Required=false)]
            public int? OutMachineInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of paused servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PauseInstanceCount")]
            [Validation(Required=false)]
            public int? PauseInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of regions to which the servers belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("RegionCount")]
            [Validation(Required=false)]
            public int? RegionCount { get; set; }

            /// <summary>
            /// <para>The number of CPU cores of assets with risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>201</para>
            /// </summary>
            [NameInMap("RiskInstanceCoreCount")]
            [Validation(Required=false)]
            public long? RiskInstanceCoreCount { get; set; }

            /// <summary>
            /// <para>The number of assets with risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("RiskInstanceCount")]
            [Validation(Required=false)]
            public int? RiskInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of third-party cloud servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("StateCloudInstanceCount")]
            [Validation(Required=false)]
            public int? StateCloudInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of third-party cloud servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TencentInstanceCount")]
            [Validation(Required=false)]
            public int? TencentInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of test assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TestAssetCount")]
            [Validation(Required=false)]
            public int? TestAssetCount { get; set; }

            /// <summary>
            /// <para>The number of Simple Application Server instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TripartiteInstanceCount")]
            [Validation(Required=false)]
            public int? TripartiteInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of third-party cloud servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("UcloudInstanceCount")]
            [Validation(Required=false)]
            public int? UcloudInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of assets with an unknown enabling status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UnKnowStatusInstanceCount")]
            [Validation(Required=false)]
            public int? UnKnowStatusInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of CPU cores of unprotected assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("UnprotectedInstanceCoreCount")]
            [Validation(Required=false)]
            public long? UnprotectedInstanceCoreCount { get; set; }

            /// <summary>
            /// <para>The number of unprotected assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UnprotectedInstanceCount")]
            [Validation(Required=false)]
            public int? UnprotectedInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of third-party cloud servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("VolcengineInstanceCount")]
            [Validation(Required=false)]
            public int? VolcengineInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of virtual private clouds (VPCs).</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("VpcCount")]
            [Validation(Required=false)]
            public int? VpcCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E0618A9-D5EF-4220-9471-C42B5E92719F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
