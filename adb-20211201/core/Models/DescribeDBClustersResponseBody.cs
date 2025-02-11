// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried clusters.</para>
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
                /// <para>The mode of the cluster. This parameter is returned only for Data Warehouse Edition clusters. Valid values:</para>
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
                /// <para>The billing method of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ads</b>: pay-as-you-go.</description></item>
                /// <item><description><b>ads_pre</b>: subscription.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ads_pre</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The specifications of reserved computing resources. Each ACU is approximately equal to 1 core and 4 GB memory. Computing resources are used to compute data. The increase in the computing resources can accelerate queries. You can scale computing resources based on your business requirements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16ACU</para>
                /// </summary>
                [NameInMap("ComputeResource")]
                [Validation(Required=false)]
                public string ComputeResource { get; set; }

                /// <summary>
                /// <para>The public endpoint that is used to connect to the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amv-bp163885f8q21****.ads.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The time when the cluster was created. The time follows the ISO 8601 standard in the <em>yyyy-mm-ddThh:mm:ssZ</em> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-01T09:50:18Z</para>
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
                /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amv-bp163885f8q21****</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// <para>The network type of the cluster. <b>VPC</b> is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("DBClusterNetworkType")]
                [Validation(Required=false)]
                public string DBClusterNetworkType { get; set; }

                /// <summary>
                /// <para>The status of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Preparing</b></description></item>
                /// </list>
                /// <!---->
                /// 
                /// <list type="bullet">
                /// <item><description><b>Creating</b></description></item>
                /// <item><description><b>Running</b></description></item>
                /// <item><description><b>Deleting</b></description></item>
                /// </list>
                /// <!---->
                /// 
                /// <list type="bullet">
                /// <item><description><b>Restoring</b></description></item>
                /// </list>
                /// <!---->
                /// 
                /// <list type="bullet">
                /// <item><description><b>ClassChanging</b></description></item>
                /// <item><description><b>NetAddressCreating</b></description></item>
                /// <item><description><b>NetAddressDeleting</b></description></item>
                /// <item><description><b>NetAddressModifying</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("DBClusterStatus")]
                [Validation(Required=false)]
                public string DBClusterStatus { get; set; }

                /// <summary>
                /// <para>The type of the cluster. By default, <b>Common</b> is returned, which indicates a common cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Common</para>
                /// </summary>
                [NameInMap("DBClusterType")]
                [Validation(Required=false)]
                public string DBClusterType { get; set; }

                /// <summary>
                /// <para>The node specifications of the cluster. This parameter is returned only for Data Warehouse Edition clusters.</para>
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
                /// <para>2</para>
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
                /// <para>The engine version of the AnalyticDB for MySQL Data Lakehouse Edition cluster. <b>5.0</b> is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.0</para>
                /// </summary>
                [NameInMap("DBVersion")]
                [Validation(Required=false)]
                public string DBVersion { get; set; }

                /// <summary>
                /// <para>The disk type of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>local_ssd</b>: local disk.</description></item>
                /// <item><description><b>cloud</b>: basic disk.</description></item>
                /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
                /// <item><description><b>cloud_efficiency</b>: ultra disk.</description></item>
                /// <item><description><b>cloud_essd</b>: PL1 Enterprise SSD (ESSD).</description></item>
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
                /// <para>The ID of the Data Transmission Service (DTS) synchronization job This parameter is returned only for MySQL analytic instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtsb1578j90XXXX</para>
                /// </summary>
                [NameInMap("DtsJobId")]
                [Validation(Required=false)]
                public string DtsJobId { get; set; }

                /// <summary>
                /// <para>The number of elastic I/O units (EIUs). For more information, see the &quot;<a href="https://help.aliyun.com/document_detail/189505.html">EIUs</a>&quot; section of the Scale out elastic I/O resources topic.</para>
                /// <remarks>
                /// <para> This parameter is returned only for clusters in elastic mode.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
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
                /// <para>The time when the cluster expires. The time follows the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time is displayed in UTC.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>If the billing method of the cluster is subscription, the actual expiration time is returned.</para>
                /// </description></item>
                /// <item><description><para>If the billing method of the cluster is pay-as-you-go, null is returned.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-01T09:50:18Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the subscription cluster has expired. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>If the cluster has expired, the system locks or releases the cluster within a period of time. We recommend that you renew the expired cluster. For more information, see <a href="https://help.aliyun.com/document_detail/135246.html">Renewal policy</a>.</para>
                /// </description></item>
                /// <item><description><para>This parameter is not returned for pay-as-you-go clusters.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public string Expired { get; set; }

                /// <summary>
                /// <para>The internal IP address of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.1.xx.xx</para>
                /// </summary>
                [NameInMap("InnerIp")]
                [Validation(Required=false)]
                public string InnerIp { get; set; }

                /// <summary>
                /// <para>The internal port of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("InnerPort")]
                [Validation(Required=false)]
                public string InnerPort { get; set; }

                /// <summary>
                /// <para>The lock status of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unlock</b>: The cluster is not locked.</description></item>
                /// <item><description><b>ManualLock</b>: The cluster is manually locked.</description></item>
                /// <item><description><b>LockByExpiration</b>: The cluster is automatically locked due to cluster expiration.</description></item>
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
                /// <para>instance_expire</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The mode of the cluster. By default, <b>flexible</b> is returned, which indicates that the cluster is in elastic mode.</para>
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
                /// <para>Prepaid</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>The port number that is used to connect to the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The service type of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>LegacyForm</description></item>
                /// <item><description>IntegrationForm</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IntegrationForm</para>
                /// </summary>
                [NameInMap("ProductForm")]
                [Validation(Required=false)]
                public string ProductForm { get; set; }

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
                /// <para>The remaining reserved computing resources that are available in the cluster. Each ACU is approximately equal to 1 core and 4 GB memory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32ACU</para>
                /// </summary>
                [NameInMap("ReservedACU")]
                [Validation(Required=false)]
                public string ReservedACU { get; set; }

                /// <summary>
                /// <para>The number of reserved resource nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReservedNodeCount")]
                [Validation(Required=false)]
                public int? ReservedNodeCount { get; set; }

                /// <summary>
                /// <para>The single-node specifications of reserved resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8ACU</para>
                /// </summary>
                [NameInMap("ReservedNodeSize")]
                [Validation(Required=false)]
                public string ReservedNodeSize { get; set; }

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
                /// <para>The specifications of reserved storage resources. Each AnalyticDB compute unit (ACU) is approximately equal to 1 core and 4 GB memory. Storage resources are used to read and write data. The increase in the storage resources can improve the read and write performance of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24ACU</para>
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
                        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/179253.html">TagResources</a> operation to add tags to a cluster.</para>
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
                    /// <para>The job steps.</para>
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
                /// <para>vpc-bp13h7uzhulpuxvnp****</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1syh8vvw8yech7n****</para>
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
        /// <para>A5EDBA27-AF3E-5966-9503-FD1557E19167</para>
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
