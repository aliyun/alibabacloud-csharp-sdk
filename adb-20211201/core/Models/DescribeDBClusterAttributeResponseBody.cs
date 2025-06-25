// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried cluster.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClusterAttributeResponseBodyItems Items { get; set; }
        public class DescribeDBClusterAttributeResponseBodyItems : TeaModel {
            [NameInMap("DBCluster")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAttributeResponseBodyItemsDBCluster> DBCluster { get; set; }
            public class DescribeDBClusterAttributeResponseBodyItemsDBCluster : TeaModel {
                [NameInMap("AINodeNumber")]
                [Validation(Required=false)]
                public int? AINodeNumber { get; set; }

                [NameInMap("AINodeSpec")]
                [Validation(Required=false)]
                public string AINodeSpec { get; set; }

                /// <summary>
                /// <para>The cache size of the ClickHouse wide table engine. Unit: GB. If a value of -1 is returned, the ClickHouse wide table engine is disabled. If a value other than -1 is returned, this parameter indicates the disk cache size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ClickhouseEngineCacheSize")]
                [Validation(Required=false)]
                public int? ClickhouseEngineCacheSize { get; set; }

                /// <summary>
                /// <para>Indicates whether the ClickHouse wide table engine is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ClickhouseEngineEnabled")]
                [Validation(Required=false)]
                public bool? ClickhouseEngineEnabled { get; set; }

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
                /// <para>The total amount of computing resources in the cluster. Each ACU is approximately equal to 1 core and 4 GB memory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>48ACU</para>
                /// </summary>
                [NameInMap("ComputeResourceTotal")]
                [Validation(Required=false)]
                public string ComputeResourceTotal { get; set; }

                /// <summary>
                /// <para>The public endpoint that is used to connect to the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amv-wz9509beptiz****.ads.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The time when the cluster was created. The time follows the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-01T09:50:18Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

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
                /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amv-wz9509beptiz****</para>
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
                /// <item><description><b>Creating</b></description></item>
                /// <item><description><b>Running</b></description></item>
                /// <item><description><b>Deleting</b></description></item>
                /// <item><description><b>Restoring</b></description></item>
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
                /// <para>The engine version of the AnalyticDB for MySQL Data Lakehouse Edition cluster. <b>5.0</b> is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.0</para>
                /// </summary>
                [NameInMap("DBVersion")]
                [Validation(Required=false)]
                public string DBVersion { get; set; }

                [NameInMap("DiskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

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
                /// <para>The minor version of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.1.16</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The time when the cluster expires.</para>
                /// <list type="bullet">
                /// <item><description>If the billing method of the cluster is subscription, the actual expiration time is returned.</description></item>
                /// <item><description>If the billing method of the cluster is pay-as-you-go, null is returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-01T09:50:18Z</para>
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
                /// <item><description><para>If the cluster has expired, the system locks or releases the cluster within a period of time. We recommend that you renew the expired cluster. For more information, see <a href="https://help.aliyun.com/document_detail/135248.html">Renewal policy</a>.</para>
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
                /// <para>The ID of the key that is used to encrypt disk data.</para>
                /// <remarks>
                /// <para> This parameter is returned only when disk encryption is enabled.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>e1935511-cf88-1123-a0f8-1be8d251****</para>
                /// </summary>
                [NameInMap("KmsId")]
                [Validation(Required=false)]
                public string KmsId { get; set; }

                /// <summary>
                /// <para>The lock mode of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unlock</b>: The cluster is not locked.</description></item>
                /// <item><description><b>ManualLock</b>: The cluster is manually locked.</description></item>
                /// <item><description><b>LockByExpiration</b>: The cluster is automatically locked due to cluster expiration.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ManualLock</para>
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
                /// <para>The maintenance window of the cluster. The time is displayed in the <c>HH:mmZ-HH:mmZ</c> format in UTC.</para>
                /// <remarks>
                /// <para> For more information about maintenance windows, see <a href="https://help.aliyun.com/document_detail/122569.html">Configure a maintenance window</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>04:00Z-05:00Z</para>
                /// </summary>
                [NameInMap("MaintainTime")]
                [Validation(Required=false)]
                public string MaintainTime { get; set; }

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
                public int? Port { get; set; }

                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>N/A</para>
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
                /// <para>BasicVersion</para>
                /// </summary>
                [NameInMap("ProductVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

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
                /// <para>The amount of remaining reserved computing resources that are available in the cluster. Each ACU is approximately equal to 1 core and 4 GB memory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24ACU</para>
                /// </summary>
                [NameInMap("ReservedACU")]
                [Validation(Required=false)]
                public string ReservedACU { get; set; }

                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>N/A</para>
                /// </summary>
                [NameInMap("ReservedNodeCount")]
                [Validation(Required=false)]
                public int? ReservedNodeCount { get; set; }

                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>N/A</para>
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

                [NameInMap("SecondaryVSwitchId")]
                [Validation(Required=false)]
                public string SecondaryVSwitchId { get; set; }

                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

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
                /// <para>The total amount of storage resources in the cluster. Each ACU is approximately equal to 1 core and 4 GB memory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24ACU</para>
                /// </summary>
                [NameInMap("StorageResourceTotal")]
                [Validation(Required=false)]
                public string StorageResourceTotal { get; set; }

                /// <summary>
                /// <para>Reserved parameters.</para>
                /// </summary>
                [NameInMap("SupportedFeatures")]
                [Validation(Required=false)]
                public Dictionary<string, string> SupportedFeatures { get; set; }

                /// <summary>
                /// <para>The tags that are added to the cluster.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBClusterAttributeResponseBodyItemsDBClusterTags Tags { get; set; }
                public class DescribeDBClusterAttributeResponseBodyItemsDBClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBClusterAttributeResponseBodyItemsDBClusterTagsTag> Tag { get; set; }
                    public class DescribeDBClusterAttributeResponseBodyItemsDBClusterTagsTag : TeaModel {
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
                /// <para>The job information.</para>
                /// </summary>
                [NameInMap("TaskInfo")]
                [Validation(Required=false)]
                public DescribeDBClusterAttributeResponseBodyItemsDBClusterTaskInfo TaskInfo { get; set; }
                public class DescribeDBClusterAttributeResponseBodyItemsDBClusterTaskInfo : TeaModel {
                    /// <summary>
                    /// <para>The name of the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ScaleUpDBCluster</para>
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
                    /// <item><description>NOT_RUN</description></item>
                    /// <item><description>RUNNING</description></item>
                    /// <item><description>SUCCEED</description></item>
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
                    public DescribeDBClusterAttributeResponseBodyItemsDBClusterTaskInfoStepList StepList { get; set; }
                    public class DescribeDBClusterAttributeResponseBodyItemsDBClusterTaskInfoStepList : TeaModel {
                        [NameInMap("StepList")]
                        [Validation(Required=false)]
                        public List<DescribeDBClusterAttributeResponseBodyItemsDBClusterTaskInfoStepListStepList> StepList { get; set; }
                        public class DescribeDBClusterAttributeResponseBodyItemsDBClusterTaskInfoStepListStepList : TeaModel {
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
                            /// <para>Prepare resources</para>
                            /// </summary>
                            [NameInMap("StepDesc")]
                            [Validation(Required=false)]
                            public string StepDesc { get; set; }

                            /// <summary>
                            /// <para>The name of the job step.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>PrepareResources</para>
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
                            /// <item><description>NOT_RUN</description></item>
                            /// <item><description>RUNNING</description></item>
                            /// <item><description>SUCCEED</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>RUNNING</para>
                            /// </summary>
                            [NameInMap("StepStatus")]
                            [Validation(Required=false)]
                            public string StepStatus { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>Indicates whether Elastic Network Interface (ENI) is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("UserENIStatus")]
                [Validation(Required=false)]
                public bool? UserENIStatus { get; set; }

                /// <summary>
                /// <para>The vSwitch connected to the ENI. Separate multiple vSwitches with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-rj9ixufmywqq98z******,vsw-rj95ij6wcz656v7******</para>
                /// </summary>
                [NameInMap("UserENIVSwitchOptions")]
                [Validation(Required=false)]
                public string UserENIVSwitchOptions { get; set; }

                /// <summary>
                /// <para>The VPC information of the ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-rj9hnedlfm645uj******</para>
                /// </summary>
                [NameInMap("UserENIVpcId")]
                [Validation(Required=false)]
                public string UserENIVpcId { get; set; }

                /// <summary>
                /// <para>The zone associated with the ENI. Separate multiple zones with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-k,cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("UserENIZoneOptions")]
                [Validation(Required=false)]
                public string UserENIZoneOptions { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp13h7uzhulpu****</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-uf629gydd54ld****</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5C433C2-001F-58E3-99F5-3274C14DF8BD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
