// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class CreateDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("BackupSetID")]
        [Validation(Required=false)]
        public string BackupSetID { get; set; }

        /// <summary>
        /// <para>A client-generated token to ensure request idempotence. The token must be unique across requests, case-sensitive, and up to 64 ASCII characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-t7241****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The compute resources for the cluster. Compute resources are used for data queries. A larger amount of compute resources can provide better query performance. Compute resources are available in cluster and single-node editions:</para>
        /// <list type="bullet">
        /// <item><description><para>Cluster edition: includes specifications such as 16 cores/64 GB, 24 cores/96 GB, and 32 cores or more. The cluster edition supports resource pool isolation, scheduled scaling, and tiered storage of hot and cold data.</para>
        /// </description></item>
        /// <item><description><para>Single-node edition: includes specifications such as 8 cores/32 GB and 16 cores/64 GB. The single-node edition does not provide an SLA guarantee and has a long recovery time from failures (4 to 8 hours). We do not recommend that you use the single-node edition in production environments.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/190632.html">DescribeAvailableResource</a> operation to query the compute resources that are available in a specific region.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required when <c>Mode</c> is set to <c>Flexible</c> (flexible mode).</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>32Core128GBNEW</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResource { get; set; }

        /// <summary>
        /// <para>The cluster edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cluster</b>: reserved cluster.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>Reserved clusters are available only in the Chinese mainland and Singapore regions. In the Singapore region, you can purchase reserved clusters only with the pay-as-you-go billing method.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>MixedStorage</b>: elastic cluster (new).</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set <c>DBClusterCategory</c> to <c>Cluster</c>, you must set the <c>Mode</c> parameter to <c>Reserved</c>. If you set <c>DBClusterCategory</c> to <c>MixedStorage</c>, you must set the <c>Mode</c> parameter to <c>Flexible</c>. Otherwise, cluster creation will fail.</para>
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
        /// <para>The cluster specification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>C8</b></para>
        /// </description></item>
        /// <item><description><para><b>C32</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <c>Mode</c> is set to <c>Reserved</c> (reserved mode).</para>
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
        /// <item><description><para>The description cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </description></item>
        /// <item><description><para>The description must be 2 to 256 characters long.</para>
        /// </description></item>
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
        /// <para>The version of the AnalyticDB for MySQL cluster. Set the value to <b>3.0</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.0</para>
        /// </summary>
        [NameInMap("DBClusterVersion")]
        [Validation(Required=false)]
        public string DBClusterVersion { get; set; }

        /// <summary>
        /// <para>The number of node groups. The value must be an integer from 1 to 200.</para>
        /// <remarks>
        /// <para>This parameter is required when <c>Mode</c> is set to <c>Reserved</c> (reserved mode).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DBNodeGroupCount")]
        [Validation(Required=false)]
        public string DBNodeGroupCount { get; set; }

        /// <summary>
        /// <para>The node storage capacity. Unit: GB. The valid values vary based on the cluster specification:</para>
        /// <list type="bullet">
        /// <item><description><para>For the <c>C8</c> specification, the value ranges from 100 to 1,000.</para>
        /// </description></item>
        /// <item><description><para>For the <c>C32</c> specification, the value ranges from 100 to 8,000.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required when <c>Mode</c> is set to <c>Reserved</c> (reserved mode).</para>
        /// </description></item>
        /// <item><description><para>The value must be a multiple of 100 for storage sizes under 1,000 GB, and a multiple of 1,000 for storage sizes of 1,000 GB or more.</para>
        /// </description></item>
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
        /// <para>Specifies whether to enable disk encryption. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: enables disk encryption.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: disables disk encryption.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DiskEncryption")]
        [Validation(Required=false)]
        public bool? DiskEncryption { get; set; }

        /// <summary>
        /// <para>The number of Elastic IO Units (EIUs). For more information, see <a href="https://help.aliyun.com/document_detail/189505.html">EIU details</a>.</para>
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
        /// <item><description><para><b>true</b>: enables SSL encryption.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables SSL encryption.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSSL")]
        [Validation(Required=false)]
        public bool? EnableSSL { get; set; }

        /// <summary>
        /// <para>This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("ExecutorCount")]
        [Validation(Required=false)]
        public string ExecutorCount { get; set; }

        /// <summary>
        /// <para>The ID of the Key Management Service (KMS) key that is used for disk encryption. This parameter is valid only when <c>DiskEncryption</c> is set to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxxx-xxxx-xxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("KmsId")]
        [Validation(Required=false)]
        public string KmsId { get; set; }

        /// <summary>
        /// <para>The cluster mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Reserved</b>: reserved mode.</para>
        /// </description></item>
        /// <item><description><para><b>Flexible</b>: flexible mode.</para>
        /// </description></item>
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
        /// <item><description><para><b>Postpaid</b>: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: subscription.</para>
        /// </description></item>
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
        /// <para>The subscription period unit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Year</b></para>
        /// </description></item>
        /// <item><description><para><b>Month</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <c>PayType</c> is set to <c>Prepaid</c> (subscription).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the IDs of available regions.</para>
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
        /// <para>The resource group ID.</para>
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
        /// <para>This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("SourceDBInstanceName")]
        [Validation(Required=false)]
        public string SourceDBInstanceName { get; set; }

        /// <summary>
        /// <para>This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("StorageResource")]
        [Validation(Required=false)]
        public string StorageResource { get; set; }

        /// <summary>
        /// <para>This parameter is reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBClusterRequestTag> Tag { get; set; }
        public class CreateDBClusterRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can use tags to filter clusters. You can specify up to 20 tags. N in <c>Tag.N.Key</c> must be a unique and consecutive integer that starts from 1. <c>Tag.N.Key</c> is paired with <c>Tag.N.Value</c>.</para>
            /// <remarks>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>tag1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can use tags to filter clusters. You can specify up to 20 tags. N in <c>Tag.N.Value</c> must be a unique and consecutive integer that starts from 1. <c>Tag.N.Value</c> is paired with <c>Tag.N.Key</c>.</para>
            /// <remarks>
            /// <para>The tag value can be up to 64 characters in length and cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</para>
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
        /// <para>The subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>Period</c> is set to <c>Year</c>, the value can be 1, 2, 3, or 5.</para>
        /// </description></item>
        /// <item><description><para>If <c>Period</c> is set to <c>Month</c>, the value can be an integer from 1 to 11.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required when <c>PayType</c> is set to <c>Prepaid</c> (subscription).</para>
        /// </description></item>
        /// <item><description><para>The longer the subscription duration, the greater the savings. For example, a one-year subscription is more cost-effective than a 10- or 11-month subscription.</para>
        /// </description></item>
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
        /// <para>The Virtual Private Cloud (VPC) ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1at5ze0t5u3xtqn****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1aadw9k19x6cis9****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The availability zone ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the IDs of available availability zones.</para>
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
