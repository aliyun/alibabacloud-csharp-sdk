// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set that you want to use to restore data.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/612318.html">DescribeBackups</a> operation to query the backup sets of the cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1880808684</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>The region ID of the source cluster.</para>
        /// <remarks>
        /// <para> This parameter must be specified for cloning clusters across regions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("CloneSourceRegionId")]
        [Validation(Required=false)]
        public string CloneSourceRegionId { get; set; }

        /// <summary>
        /// <para>The amount of reserved computing resources. Valid values: 0ACU to 4096ACU. The value must be in increments of 16ACU. Each ACU is approximately equal to 1 core and 4 GB memory.</para>
        /// <remarks>
        /// <para> This parameter must be specified with a unit.</para>
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
        /// <item><description>The description must be 2 to 256 characters in length</description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("DBClusterNetworkType")]
        [Validation(Required=false)]
        public string DBClusterNetworkType { get; set; }

        /// <summary>
        /// <para>The version of the cluster. Set the value to <b>5.0</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("DBClusterVersion")]
        [Validation(Required=false)]
        public string DBClusterVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable disk encryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DiskEncryption")]
        [Validation(Required=false)]
        public bool? DiskEncryption { get; set; }

        /// <summary>
        /// <para>Specifies whether to allocate all reserved computing resources to the user_default resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default)</description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDefaultResourcePool")]
        [Validation(Required=false)]
        public bool? EnableDefaultResourcePool { get; set; }

        [NameInMap("EnableSSL")]
        [Validation(Required=false)]
        public bool? EnableSSL { get; set; }

        /// <summary>
        /// <para>The ID of the key that is used to encrypt disk data.</para>
        /// <remarks>
        /// <para> This parameter must be specified only when disk encryption is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>e1935511-cf88-1123-a0f8-1be8d251****</para>
        /// </summary>
        [NameInMap("KmsId")]
        [Validation(Required=false)]
        public string KmsId { get; set; }

        /// <summary>
        /// <para>The billing method of the cluster. Valid values:</para>
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
        /// <para> This parameter must be specified when PayType is set to Prepaid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The product form of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IntegrationForm</b>: integrated.</description></item>
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
        /// <para>The edition of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BasicVersion</b>: Basic Edition.</description></item>
        /// <item><description><b>EnterpriseVersion</b>: Enterprise Edition.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter must be specified only when ProductForm is set to IntegrationForm.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>BasicVersion</para>
        /// </summary>
        [NameInMap("ProductVersion")]
        [Validation(Required=false)]
        public string ProductVersion { get; set; }

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
        /// <para>The number of reserved resource nodes.</para>
        /// <list type="bullet">
        /// <item><description>For Enterprise Edition, the default value is 3 and the step size is 3.</description></item>
        /// <item><description>For Basic Edition, the default value is 1.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter must be specified only when ProductForm is set to IntegrationForm.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ReservedNodeCount")]
        [Validation(Required=false)]
        public int? ReservedNodeCount { get; set; }

        /// <summary>
        /// <para>The specifications of reserved resource nodes. Unit: ACUs.</para>
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
        /// <para>The method that you want to use to restore data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>backup</b>: restores data from a backup set. You must also specify the <b>BackupSetId</b> and <b>SourceDBClusterId</b> parameters.</description></item>
        /// <item><description><b>timepoint</b>: restores data to a point in time. You must also specify the <b>RestoreToTime</b> and <b>SourceDBClusterId</b> parameters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>backup</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The ID of the secondary vSwitch.</para>
        /// <remarks>
        /// <para> You cannot set this parameter to a value that is the same as that of the VSwitchId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1aadw9k19x451gx****</para>
        /// </summary>
        [NameInMap("SecondaryVSwitchId")]
        [Validation(Required=false)]
        public string SecondaryVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone.</para>
        /// <remarks>
        /// <para> You cannot set this parameter to a value that is the same as that of the ZoneId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-h</para>
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the source AnalyticDB for MySQL Data Warehouse Edition cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1r053byu48p****</para>
        /// </summary>
        [NameInMap("SourceDbClusterId")]
        [Validation(Required=false)]
        public string SourceDbClusterId { get; set; }

        /// <summary>
        /// <para>The amount of reserved storage resources. Valid values: 0ACU to 2064ACU. The value must be in increments of 24ACU. Each ACU is approximately equal to 1 core and 4 GB memory.</para>
        /// <remarks>
        /// <para> This parameter must be specified with a unit.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>24ACU</para>
        /// </summary>
        [NameInMap("StorageResource")]
        [Validation(Required=false)]
        public string StorageResource { get; set; }

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
            /// <para>testkey1</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1at5ze0t5u3xtqn****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the cluster.</para>
        /// <para>This parameter is required.</para>
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
