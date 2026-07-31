// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateDBClusterRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AINodeNumber")]
        [Validation(Required=false)]
        public int? AINodeNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ADB.MLPlus.4</para>
        /// </summary>
        [NameInMap("AINodeSpec")]
        [Validation(Required=false)]
        public string AINodeSpec { get; set; }

        /// <summary>
        /// <para>The ID of the backup set used for restoration from a backup set.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/612318.html">DescribeBackups</a> operation to query the backup list of the cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1880808684</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>The region of the source cluster.</para>
        /// <remarks>
        /// <para>This parameter is required for cross-region cloning.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("CloneSourceRegionId")]
        [Validation(Required=false)]
        public string CloneSourceRegionId { get; set; }

        /// <summary>
        /// <para>The compute reserved resources. Valid values: 0 ACU to 4096 ACU, in increments of 16. 1 ACU is approximately equivalent to 1 core and 4 GB of memory.</para>
        /// <remarks>
        /// <para>Include the unit when specifying this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16ACU</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResource { get; set; }

        /// <summary>
        /// <para>The description of the cluster.</para>
        /// <list type="bullet">
        /// <item><description>The description cannot start with <c>http://</c> or <c>https://</c>.</description></item>
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
        /// <para>The network type of the cluster. Only <b>VPC</b> (Virtual Private Cloud) is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("DBClusterNetworkType")]
        [Validation(Required=false)]
        public string DBClusterNetworkType { get; set; }

        /// <summary>
        /// <para>The version of the Data Lakehouse Edition cluster. Valid values: <b>5.0</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("DBClusterVersion")]
        [Validation(Required=false)]
        public string DBClusterVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cloud disk encryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DiskEncryption")]
        [Validation(Required=false)]
        public bool? DiskEncryption { get; set; }

        /// <summary>
        /// <para>Specifies whether to allocate all compute reserved resources to the default resource group (user_default). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): All compute reserved resources are allocated to the default resource group.</description></item>
        /// <item><description><b>false</b>: Not all compute reserved resources are allocated to the default resource group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDefaultResourcePool")]
        [Validation(Required=false)]
        public bool? EnableDefaultResourcePool { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable SSL encryption. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: SSL encryption is enabled.</description></item>
        /// <item><description><b>false</b>: SSL encryption is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSSL")]
        [Validation(Required=false)]
        public bool? EnableSSL { get; set; }

        /// <summary>
        /// <para>The ID of the key used to encrypt cloud disk data.</para>
        /// <remarks>
        /// <para>This parameter is used only when cloud disk encryption is enabled for the AnalyticDB for MySQL cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>e1935511-cf88-1123-a0f8-1be8d251****</para>
        /// </summary>
        [NameInMap("KmsId")]
        [Validation(Required=false)]
        public string KmsId { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The subscription type of the subscription cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: subscription on a yearly basis.</description></item>
        /// <item><description><b>Month</b>: subscription on a monthly basis.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when PayType is set to Prepaid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The product form. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IntegrationForm</b>: integrated form.</description></item>
        /// <item><description><b>LegacyForm</b>: Data Lakehouse Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LegacyForm</para>
        /// </summary>
        [NameInMap("ProductForm")]
        [Validation(Required=false)]
        public string ProductForm { get; set; }

        /// <summary>
        /// <para>The product version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BasicVersion</b>: Basic Edition.</description></item>
        /// <item><description><b>EnterpriseVersion</b>: Enterprise Edition.<remarks>
        /// <para>This parameter is required only when ProductForm is set to IntegrationForm.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BasicVersion</para>
        /// </summary>
        [NameInMap("ProductVersion")]
        [Validation(Required=false)]
        public string ProductVersion { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454314.html">DescribeRegions</a> operation to query the region ID of a specific Data Lakehouse Edition cluster.</para>
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
        /// <para>The number of reserved nodes. </para>
        /// <list type="bullet">
        /// <item><description>Enterprise Edition uses 3 nodes by default, in increments of 3.</description></item>
        /// <item><description>Basic Edition uses 1 node by default.<remarks>
        /// <para>This parameter is required only when ProductForm is set to IntegrationForm.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ReservedNodeCount")]
        [Validation(Required=false)]
        public int? ReservedNodeCount { get; set; }

        /// <summary>
        /// <para>The node specifications of reserved nodes, in ACUs.</para>
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
        /// <para>rg-4690g37929****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The point in time to which you want to restore data from the backup set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-20T03:13:56Z</para>
        /// </summary>
        [NameInMap("RestoreToTime")]
        [Validation(Required=false)]
        public string RestoreToTime { get; set; }

        /// <summary>
        /// <para>The restoration method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>backup</b>: restores data from a backup set. You must also specify the <b>BackupSetId</b> and <b>SourceDBClusterId</b> parameters.</description></item>
        /// <item><description><b>timepoint</b>: restores data to a specific point in time. You must also specify the <b>RestoreToTime</b> and <b>SourceDBClusterId</b> parameters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>backup</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The secondary vSwitch ID.</para>
        /// <remarks>
        /// <para>The value of this parameter must be different from the value of the VSwitchId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1aadw9k19x451gx****</para>
        /// </summary>
        [NameInMap("SecondaryVSwitchId")]
        [Validation(Required=false)]
        public string SecondaryVSwitchId { get; set; }

        /// <summary>
        /// <para>The secondary zone ID.</para>
        /// <remarks>
        /// <para>The value of this parameter must be different from the value of the ZoneId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-h</para>
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        /// <summary>
        /// <para>The instance ID of the source AnalyticDB for MySQL Data Warehouse Edition cluster. If this parameter is specified, the Data Lakehouse Edition cluster is used to recover from the Data Warehouse Edition cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1r053byu48p****</para>
        /// </summary>
        [NameInMap("SourceDbClusterId")]
        [Validation(Required=false)]
        public string SourceDbClusterId { get; set; }

        /// <summary>
        /// <para>The storage reserved resources. Valid values: 0 ACU to 2064 ACU, in increments of 24. 1 ACU is approximately equivalent to 1 core and 4 GB of memory.</para>
        /// <remarks>
        /// <para>Include the unit when specifying this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>24ACU</para>
        /// </summary>
        [NameInMap("StorageResource")]
        [Validation(Required=false)]
        public string StorageResource { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBClusterRequestTag> Tag { get; set; }
        public class CreateDBClusterRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can use tags to filter the cluster list. You can specify up to 20 tag pairs. The value of N for each tag pair must be unique and must be a consecutive integer that starts from 1. The value of <c>Tag.N.Key</c> corresponds to the value of <c>Tag.N.Value</c>.</para>
            /// <remarks>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can use tags to filter the cluster list. You can specify up to 20 tag pairs. The value of N for each tag pair must be unique and must be a consecutive integer that starts from 1. The value of <c>Tag.N.Key</c> corresponds to the value of <c>Tag.N.Value</c>.</para>
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
        /// <para>The subscription duration of the subscription cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When <b>Period</b> is set to Year, the value of UsedTime ranges from 1 to 3 (integer).</description></item>
        /// <item><description>When <b>Period</b> is set to Month, the value of UsedTime ranges from 1 to 9 (integer).</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when PayType is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1at5ze0t5u3xtqn****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1aadw9k19x6cis9****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454314.html">DescribeRegions</a> operation to query the zone ID of a specific Data Lakehouse Edition cluster.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
