// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class CreateDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("BackupSetID")]
        [Validation(Required=false)]
        public string BackupSetID { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The value is case-sensitive and can contain a maximum of 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-t7241****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The computing resources of the cluster. You can use computing resources to compute data. The increase in the computing resources can accelerate data queries. The computing resources are available for Cluster Edition and Basic Edition.</para>
        /// <list type="bullet">
        /// <item><description>Computing resources for Cluster Edition include 16 cores and 64 GB memory, 24 cores and 96 GB memory, and 32 cores or more. Cluster Edition supports resource isolation, scheduled scaling, and tiered storage of hot and cold data.</description></item>
        /// <item><description>Computing resources for Basic Edition include 8 cores and 32 GB memory and 16 cores and 64 GB memory. Alibaba Cloud does not provide an SLA guarantee for Basic Edition, and 4 to 8 hours are required for a failover. We recommend that you do not use Basic Edition in production environments.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/190632.html">DescribeAvailableResource</a> operation to query the available computing resources in a region.</para>
        /// </description></item>
        /// <item><description><para>This parameter must be specified when Mode is set to <b>Flexible</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>32Core128GB</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResource { get; set; }

        /// <summary>
        /// <para>The edition of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cluster</b>: reserved mode for Cluster Edition</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <list type="bullet">
        /// <item><description><b>MixedStorage</b>: elastic mode for Cluster Edition</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the DBClusterCategory parameter is set to Cluster, you must set the Mode parameter to Reserver. If the DBClusterCategory parameter is set to MixedStorage, you must set the Mode parameter to Flexible. Otherwise, the cluster fails to be created.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster</para>
        /// </summary>
        [NameInMap("DBClusterCategory")]
        [Validation(Required=false)]
        public string DBClusterCategory { get; set; }

        /// <summary>
        /// <para>The specification of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>C8</b></description></item>
        /// <item><description><b>C32</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if the Mode parameter is set to Reserver.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>C8</para>
        /// </summary>
        [NameInMap("DBClusterClass")]
        [Validation(Required=false)]
        public string DBClusterClass { get; set; }

        /// <summary>
        /// <para>The description of the cluster.</para>
        /// <list type="bullet">
        /// <item><description>The description cannot start with <c>http://</c> or <c>https</c>.</description></item>
        /// <item><description>The description must be 2 to 256 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The network type of the cluster. Set the value to <b>VPC</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("DBClusterNetworkType")]
        [Validation(Required=false)]
        public string DBClusterNetworkType { get; set; }

        /// <summary>
        /// <para>The version of the cluster. Set the value to <b>3.0</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.0</para>
        /// </summary>
        [NameInMap("DBClusterVersion")]
        [Validation(Required=false)]
        public string DBClusterVersion { get; set; }

        /// <summary>
        /// <para>The number of node groups. Valid values: 1 to 200 (integer).</para>
        /// <remarks>
        /// <para> This parameter is required if the Mode parameter is set to Reserver.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DBNodeGroupCount")]
        [Validation(Required=false)]
        public string DBNodeGroupCount { get; set; }

        /// <summary>
        /// <para>The storage capacity of the cluster. Unit: GB.</para>
        /// <list type="bullet">
        /// <item><description>Valid values when DBClusterClass is set to C8: 100 to 1000</description></item>
        /// <item><description>Valid values when DBClusterClass is set to C32: 100 to 8000</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required if the Mode parameter is set to Reserver.</description></item>
        /// <item><description>1000 The storage capacity less than 1,000 GB increases in 100 GB increments. The storage capacity greater than 1,000 GB increases in 1,000 GB increments.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("DBNodeStorage")]
        [Validation(Required=false)]
        public string DBNodeStorage { get; set; }

        /// <summary>
        /// <para>Indicates whether disk encryption is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DiskEncryption")]
        [Validation(Required=false)]
        public bool? DiskEncryption { get; set; }

        /// <summary>
        /// <para>The number of elastic I/O units (EIUs). For more information, see <a href="https://help.aliyun.com/document_detail/189505.html">Elasticity of the storage layer</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ElasticIOResource")]
        [Validation(Required=false)]
        public string ElasticIOResource { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable SSL encryption. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSSL")]
        [Validation(Required=false)]
        public bool? EnableSSL { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("ExecutorCount")]
        [Validation(Required=false)]
        public string ExecutorCount { get; set; }

        /// <summary>
        /// <para>The Key Management Service (KMS) ID that is used for disk encryption. This parameter takes effect only when DiskEncryption is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxxx-xxxx-xxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("KmsId")]
        [Validation(Required=false)]
        public string KmsId { get; set; }

        /// <summary>
        /// <para>The mode of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Reserver</b>: the reserved mode.</description></item>
        /// <item><description><b>Flexible</b>: the elastic mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Reserver</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
        /// <item><description><b>Prepaid</b>: subscription</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The subscription type of the subscription cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: subscription on a yearly basis</description></item>
        /// <item><description><b>Month</b>: subscription on a monthly basis</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if the PayType parameter is set to Prepaid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the cluster belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-4690g37929****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("SourceDBInstanceName")]
        [Validation(Required=false)]
        public string SourceDBInstanceName { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("StorageResource")]
        [Validation(Required=false)]
        public string StorageResource { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The tags to add to the cluster.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBClusterRequestTag> Tag { get; set; }
        public class CreateDBClusterRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the cluster. You can use tags to filter clusters. Valid values of N: 1 to 20. The values that you specify for N must be unique and consecutive integers that start from 1. Each value of <c>Tag.N.Key</c> is paired with a value of <c>Tag.N.Value</c>.</para>
            /// <remarks>
            /// <para> The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>tag1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the cluster. You can use tags to filter clusters. Valid values of N: 1 to 20. The values that you specify for N must be unique and consecutive integers that start from 1. Each value of <c>Tag.N.Key</c> is paired with a value of <c>Tag.N.Value</c>.</para>
            /// <remarks>
            /// <para> The tag value can be up to 64 characters in length and cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The subscription period of the subscription cluster.</para>
        /// <list type="bullet">
        /// <item><description>Valid values when Period is set to Year: 1, 2, and 3 (integer)</description></item>
        /// <item><description>Valid values when Period is set to Month: 1 to 9 (integer)</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required if the PayType parameter is set to Prepaid.</description></item>
        /// <item><description>Longer subscription periods offer more savings. Purchasing a cluster for one year is more cost-effective than purchasing the cluster for 10 or 11 months.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1at5ze0t5u3xtqn****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1aadw9k19x6cis9****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the most recent zone list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
