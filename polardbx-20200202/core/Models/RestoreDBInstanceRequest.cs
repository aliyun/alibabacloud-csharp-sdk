// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class RestoreDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Default value: true.</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The backup set ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>The region where the backup set resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu</para>
        /// </summary>
        [NameInMap("BackupSetRegion")]
        [Validation(Required=false)]
        public string BackupSetRegion { get; set; }

        /// <summary>
        /// <para>The number of compute nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CNNodeCount")]
        [Validation(Required=false)]
        public string CNNodeCount { get; set; }

        /// <summary>
        /// <para>The client token used to ensure the idempotence of the request. Use a different value for each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx-xxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the source instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-***</para>
        /// </summary>
        [NameInMap("CloneInstanceName")]
        [Validation(Required=false)]
        public string CloneInstanceName { get; set; }

        /// <summary>
        /// <para>The compute node specifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>polarx.x4.medium.2e: 2 cores, 8 GB</description></item>
        /// <item><description>polarx.x4.large.2e: 4 cores, 16 GB</description></item>
        /// <item><description>polarx.x8.large.2e: 4 cores, 32 GB</description></item>
        /// <item><description>polarx.x4.xlarge.2e: 8 cores, 32 GB</description></item>
        /// <item><description>polarx.x8.xlarge.2e: 8 cores, 64 GB</description></item>
        /// <item><description>polarx.x4.2xlarge.2e: 16 cores, 64 GB</description></item>
        /// <item><description>polarx.x8.2xlarge.2e: 16 cores, 128 GB</description></item>
        /// <item><description>polarx.x4.4xlarge.2e: 32 cores, 128 GB</description></item>
        /// <item><description>polarx.x8.4xlarge.2e: 32 cores, 256 GB</description></item>
        /// <item><description>polarx.st.8xlarge.2e: 60 cores, 470 GB</description></item>
        /// <item><description>polarx.st.12xlarge.2e: 90 cores, 720 GB</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polarx.x4.medium.2e</para>
        /// </summary>
        [NameInMap("CnClass")]
        [Validation(Required=false)]
        public string CnClass { get; set; }

        /// <summary>
        /// <para>The node specifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>polarx.x4.medium.2e: 2 cores, 8 GB</description></item>
        /// <item><description>polarx.x4.large.2e: 4 cores, 16 GB</description></item>
        /// <item><description>polarx.x8.large.2e: 4 cores, 32 GB</description></item>
        /// <item><description>polarx.x4.xlarge.2e: 8 cores, 32 GB</description></item>
        /// <item><description>polarx.x8.xlarge.2e: 8 cores, 64 GB</description></item>
        /// <item><description>polarx.x4.2xlarge.2e: 16 cores, 64 GB</description></item>
        /// <item><description>polarx.x8.2xlarge.2e: 16 cores, 128 GB</description></item>
        /// <item><description>polarx.x4.4xlarge.2e: 32 cores, 128 GB</description></item>
        /// <item><description>polarx.x8.4xlarge.2e: 32 cores, 256 GB</description></item>
        /// <item><description>polarx.st.8xlarge.2e: 60 cores, 470 GB</description></item>
        /// <item><description>polarx.st.12xlarge.2e: 90 cores, 720 GB</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polarx.x4.2xlarge.2d</para>
        /// </summary>
        [NameInMap("DBNodeClass")]
        [Validation(Required=false)]
        public string DBNodeClass { get; set; }

        /// <summary>
        /// <para>The number of instance nodes. The minimum value is 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DBNodeCount")]
        [Validation(Required=false)]
        public int? DBNodeCount { get; set; }

        /// <summary>
        /// <para>The number of storage nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DNNodeCount")]
        [Validation(Required=false)]
        public string DNNodeCount { get; set; }

        /// <summary>
        /// <para>The storage node specifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>mysql.n4.medium.25: 2 cores, 8 GB</description></item>
        /// <item><description>mysql.n4.large.25: 4 cores, 16 GB</description></item>
        /// <item><description>mysql.x8.large.25: 4 cores, 32 GB</description></item>
        /// <item><description>mysql.n4.xlarge.25: 8 cores, 32 GB</description></item>
        /// <item><description>mysql.x8.xlarge.25: 8 cores, 64 GB</description></item>
        /// <item><description>mysql.n4.2xlarge.25: 16 cores, 64 GB</description></item>
        /// <item><description>mysql.x8.2xlarge.25: 16 cores, 128 GB</description></item>
        /// <item><description>mysql.x4.4xlarge.25: 32 cores, 128 GB</description></item>
        /// <item><description>mysql.x8.4xlarge.25: 32 cores, 256 GB</description></item>
        /// <item><description>mysql.st.8xlarge.25: 60 cores, 470 GB</description></item>
        /// <item><description>mysql.st.12xlarge.25: 90 cores, 720 GB</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.n4.medium.25</para>
        /// </summary>
        [NameInMap("DnClass")]
        [Validation(Required=false)]
        public string DnClass { get; set; }

        /// <summary>
        /// <para>The MySQL DPI engine version. Valid values: 5.7 and 8.0.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.7</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The GDN role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standby</para>
        /// </summary>
        [NameInMap("GdnRole")]
        [Validation(Required=false)]
        public string GdnRole { get; set; }

        /// <summary>
        /// <para>The network type. Only VPC is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The billing method of the instance.</para>
        /// <list type="bullet">
        /// <item><description>PREPAY: subscription</description></item>
        /// <item><description>POSTPAY: pay-as-you-go</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing cycle. Valid values for subscription: Year and Month. Default value for pay-as-you-go: Hour.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The primary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen-e</para>
        /// </summary>
        [NameInMap("PrimaryZone")]
        [Validation(Required=false)]
        public string PrimaryZone { get; set; }

        /// <summary>
        /// <para>The recovery type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Clone</para>
        /// </summary>
        [NameInMap("RecoveryTypeCode")]
        [Validation(Required=false)]
        public string RecoveryTypeCode { get; set; }

        /// <summary>
        /// <para>The region where the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. This parameter can be left empty. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The point in time to which you want to restore the instance. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-14T00:00:00Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen-a</para>
        /// </summary>
        [NameInMap("SecondaryZone")]
        [Validation(Required=false)]
        public string SecondaryZone { get; set; }

        /// <summary>
        /// <para>The instance series. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enterprise: Enterprise Edition.</description></item>
        /// <item><description>standard: Standard Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise</para>
        /// </summary>
        [NameInMap("Series")]
        [Validation(Required=false)]
        public string Series { get; set; }

        /// <summary>
        /// <para>The region where the source instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu</para>
        /// </summary>
        [NameInMap("SourceInstanceRegion")]
        [Validation(Required=false)]
        public string SourceInstanceRegion { get; set; }

        /// <summary>
        /// <para>The storage type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The zone for Three-zone deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen-e</para>
        /// </summary>
        [NameInMap("TertiaryZone")]
        [Validation(Required=false)]
        public string TertiaryZone { get; set; }

        /// <summary>
        /// <para>The topology type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>3azones: three-zone deployment.</description></item>
        /// <item><description>1azone: single-zone deployment.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3azones</para>
        /// </summary>
        [NameInMap("TopologyType")]
        [Validation(Required=false)]
        public string TopologyType { get; set; }

        /// <summary>
        /// <para>The subscription duration. Specify the number of months or years.</para>
        /// <remarks>
        /// <para>If Period is set to Year, valid values of this parameter are 1, 2, and 3.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

        /// <summary>
        /// <para>VPC ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-*****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*********</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
