// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried cluster information.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClustersResponseBodyItems Items { get; set; }
        public class DescribeDBClustersResponseBodyItems : TeaModel {
            [NameInMap("DBCluster")]
            [Validation(Required=false)]
            public List<DescribeDBClustersResponseBodyItemsDBCluster> DBCluster { get; set; }
            public class DescribeDBClustersResponseBodyItemsDBCluster : TeaModel {
                /// <summary>
                /// <para>The edition of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>BASIC</b>: reserved mode for Basic Edition.</description></item>
                /// <item><description><b>CLUSTER</b>: reserved mode for Cluster Edition.</description></item>
                /// <item><description><b>MIXED_STORAGE</b>: elastic mode for Cluster Edition.</description></item>
                /// </list>
                /// <remarks>
                /// <para> For more information about cluster editions, see <a href="https://help.aliyun.com/document_detail/205001.html">Editions</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>MIXED_STORAGE</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The commodity code. <b>ads</b> is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ads</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The specifications of computing resources that are used in the cluster in elastic mode. Computing resources are used to compute data. The increase in the computing resources can accelerate queries. You can scale computing resources based on your business requirements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8Core32GB</para>
                /// </summary>
                [NameInMap("ComputeResource")]
                [Validation(Required=false)]
                public string ComputeResource { get; set; }

                /// <summary>
                /// <para>The public endpoint that is used to connect to the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>am-bp163885f8q21****.ads.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The time when the cluster was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time is displayed in UTC. Example: <em>2021-04-01T09:50:18Z</em>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-01T09:50:18Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adb_test</para>
                /// </summary>
                [NameInMap("DBClusterDescription")]
                [Validation(Required=false)]
                public string DBClusterDescription { get; set; }

                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>am-bp163885f8q21****</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// <para>The network type of the cluster. <b>VPC</b> is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("DBClusterNetworkType")]
                [Validation(Required=false)]
                public string DBClusterNetworkType { get; set; }

                /// <summary>
                /// <para>The status of the cluster. For more information, see <a href="https://help.aliyun.com/document_detail/143075.html">Cluster states</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("DBClusterStatus")]
                [Validation(Required=false)]
                public string DBClusterStatus { get; set; }

                /// <summary>
                /// <para>The type of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Common</b>: common cluster.</description></item>
                /// <item><description><b>RDS_ANALYSIS</b>: MySQL analytic instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Common</para>
                /// </summary>
                [NameInMap("DBClusterType")]
                [Validation(Required=false)]
                public string DBClusterType { get; set; }

                /// <summary>
                /// <para>The specifications of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>E8</para>
                /// </summary>
                [NameInMap("DBNodeClass")]
                [Validation(Required=false)]
                public string DBNodeClass { get; set; }

                /// <summary>
                /// <para>The number of node groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DBNodeCount")]
                [Validation(Required=false)]
                public long? DBNodeCount { get; set; }

                /// <summary>
                /// <para>The storage capacity of the cluster. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("DBNodeStorage")]
                [Validation(Required=false)]
                public long? DBNodeStorage { get; set; }

                /// <summary>
                /// <para>The version of the database engine. <b>3.0</b> is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.0</para>
                /// </summary>
                [NameInMap("DBVersion")]
                [Validation(Required=false)]
                public string DBVersion { get; set; }

                /// <summary>
                /// <para>The disk type of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>local_ssd</b>: local SSD.</description></item>
                /// <item><description><b>cloud</b>: basic disk.</description></item>
                /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
                /// <item><description><b>cloud_efficiency</b>: ultra disk.</description></item>
                /// <item><description><b>cloud_essd0</b>: PL0 Enterprise SSD (ESSD).</description></item>
                /// <item><description><b>cloud_essd</b>: PL1 ESSD.</description></item>
                /// <item><description><b>cloud_essd2</b>: PL2 ESSD.</description></item>
                /// <item><description><b>cloud_essd3</b>: PL3 ESSD.</description></item>
                /// </list>
                /// <remarks>
                /// <para> For more information about ESSDs, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The ID of the Data Transmission Service (DTS) synchronization job. This parameter is returned only for MySQL analytic instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtsb1578j90XXXX</para>
                /// </summary>
                [NameInMap("DtsJobId")]
                [Validation(Required=false)]
                public string DtsJobId { get; set; }

                /// <summary>
                /// <para>The number of elastic I/O units (EIUs). For more information, see <a href="https://help.aliyun.com/document_detail/189505.html">Elasticity of the storage layer</a>.</para>
                /// <remarks>
                /// <para> This parameter is returned only for clusters in elastic mode.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ElasticIOResource")]
                [Validation(Required=false)]
                public int? ElasticIOResource { get; set; }

                /// <summary>
                /// <para>The engine of the cluster. <b>AnalyticDB</b> is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AnalyticDB</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The number of compute nodes that are used by the cluster in elastic mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExecutorCount")]
                [Validation(Required=false)]
                public string ExecutorCount { get; set; }

                /// <summary>
                /// <para>The expiration time of the cluster. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time is displayed in UTC. Example: <em>2999-09-08T16:00:00Z</em>.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>If the billing method of the cluster is subscription, the actual expiration time is returned.</para>
                /// </description></item>
                /// <item><description><para>If the billing method of the cluster is pay-as-you-go, <b>2999-09-08T16:00:00Z</b> is returned.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2999-09-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the cluster has expired. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public string Expired { get; set; }

                /// <summary>
                /// <para>The public IP address of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.1.xx.xx</para>
                /// </summary>
                [NameInMap("InnerIp")]
                [Validation(Required=false)]
                public string InnerIp { get; set; }

                /// <summary>
                /// <para>The port number that is used to connect to the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("InnerPort")]
                [Validation(Required=false)]
                public string InnerPort { get; set; }

                /// <summary>
                /// <para>The lock mode of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unlock</b>: The cluster is not locked.</description></item>
                /// <item><description><b>ManualLock</b>: The cluster is manually locked.</description></item>
                /// <item><description><b>LockByExpiration</b>: The cluster is automatically locked due to cluster expiration.</description></item>
                /// <item><description><b>LockByRestoration</b>: The cluster is automatically locked due to cluster restoration.</description></item>
                /// <item><description><b>LockByDiskQuota</b>: The cluster is automatically locked when 90% of the cluster storage is used.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unlock</para>
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// <para>The reason why the cluster is locked.</para>
                /// <remarks>
                /// <para> This parameter is returned only when the cluster was locked. <b>instance_expire</b> is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>instance_expired</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The mode of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>flexible</b>: elastic mode.</description></item>
                /// <item><description><b>reserver</b>: reserved mode.</description></item>
                /// </list>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description>For more information about cluster modes, see <a href="https://help.aliyun.com/document_detail/205001.html">Editions</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>flexible</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The billing method of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
                /// <item><description><b>Prepaid</b>: subscription.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Postpaid</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>The port number that is used to connect to the cluster. Default value: 3306.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The edition of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>BasicVersion</b>: Basic Edition.</description></item>
                /// <item><description><b>EnterpriseVersion</b>: Enterprise Edition.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EnterpriseVersion</para>
                /// </summary>
                [NameInMap("ProductVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

                /// <summary>
                /// <para>The ID of the ApsaraDB RDS instance from which data is synchronized to the cluster. This parameter is returned only for MySQL analytic instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-bp11q28kvl688****</para>
                /// </summary>
                [NameInMap("RdsInstanceId")]
                [Validation(Required=false)]
                public string RdsInstanceId { get; set; }

                /// <summary>
                /// <para>The region ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmyiu4ekp****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The specifications of storage resources that are used in the cluster in elastic mode. Storage resources are used to read and write data. The increase in the storage resources can improve the read and write performance of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8Core32GB</para>
                /// </summary>
                [NameInMap("StorageResource")]
                [Validation(Required=false)]
                public string StorageResource { get; set; }

                /// <summary>
                /// <para>The tags that are added to the cluster.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBClustersResponseBodyItemsDBClusterTags Tags { get; set; }
                public class DescribeDBClustersResponseBodyItemsDBClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBClustersResponseBodyItemsDBClusterTagsTag> Tag { get; set; }
                    public class DescribeDBClustersResponseBodyItemsDBClusterTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// <remarks>
                        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/179253.html">TagResources</a> operation to add a tag to the cluster.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tag1</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The job progress.</para>
                /// </summary>
                [NameInMap("TaskInfo")]
                [Validation(Required=false)]
                public DescribeDBClustersResponseBodyItemsDBClusterTaskInfo TaskInfo { get; set; }
                public class DescribeDBClustersResponseBodyItemsDBClusterTaskInfo : TeaModel {
                    /// <summary>
                    /// <para>The name of the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>analyticDBFlexibleScaleOut</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The progress of the job. Unit: %.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                    /// <summary>
                    /// <para>The status of the job. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>NOT_RUN</b></description></item>
                    /// <item><description><b>RUNNING</b></description></item>
                    /// <item><description><b>SUCCEED</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RUNNING</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The job step.</para>
                    /// </summary>
                    [NameInMap("StepList")]
                    [Validation(Required=false)]
                    public DescribeDBClustersResponseBodyItemsDBClusterTaskInfoStepList StepList { get; set; }
                    public class DescribeDBClustersResponseBodyItemsDBClusterTaskInfoStepList : TeaModel {
                        [NameInMap("StepList")]
                        [Validation(Required=false)]
                        public List<DescribeDBClustersResponseBodyItemsDBClusterTaskInfoStepListStepList> StepList { get; set; }
                        public class DescribeDBClustersResponseBodyItemsDBClusterTaskInfoStepListStepList : TeaModel {
                            /// <summary>
                            /// <para>The end time of the job step. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2024-03-10T10:28:34Z</para>
                            /// </summary>
                            [NameInMap("EndTime")]
                            [Validation(Required=false)]
                            public string EndTime { get; set; }

                            /// <summary>
                            /// <para>The start time of the job step. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2024-03-10T09:28:34Z</para>
                            /// </summary>
                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                            /// <summary>
                            /// <para>The description of the job step.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Apply resource</para>
                            /// </summary>
                            [NameInMap("StepDesc")]
                            [Validation(Required=false)]
                            public string StepDesc { get; set; }

                            /// <summary>
                            /// <para>The name of the job step.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ApplyResource</para>
                            /// </summary>
                            [NameInMap("StepName")]
                            [Validation(Required=false)]
                            public string StepName { get; set; }

                            /// <summary>
                            /// <para>The progress of the job step. Unit: %.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>50</para>
                            /// </summary>
                            [NameInMap("StepProgress")]
                            [Validation(Required=false)]
                            public string StepProgress { get; set; }

                            /// <summary>
                            /// <para>The status of the job step. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>NOT_RUN</b></description></item>
                            /// <item><description><b>RUNNING</b></description></item>
                            /// <item><description><b>SUCCEED</b></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>SUCCEED</para>
                            /// </summary>
                            [NameInMap("StepStatus")]
                            [Validation(Required=false)]
                            public string StepStatus { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The ID of the cluster that resides in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>am-bp163885f8q21****-controller</para>
                /// </summary>
                [NameInMap("VPCCloudInstanceId")]
                [Validation(Required=false)]
                public string VPCCloudInstanceId { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp13h7uzhulpuxvnpXXXX</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1syh8vvw8yech7nXXXX</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The zone ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65A809F-34CE-4550-9BC1-0ED21ETG380</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
