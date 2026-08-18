// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateGdnStandbyMemberRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Default value: true.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

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
        /// <para>The client token that is used to ensure the idempotence of the request. Make sure that the value is different for each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEA5DC20-6D8A-5979-97AA-FC57546ADC20</para>
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
        /// <para>The compute node specifications. This parameter is required for Enterprise Edition instances and is not required for Standard Edition instances.</para>
        /// <para>Enterprise Edition with local disks:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx.x4.medium.2e</b>: 2 cores, 8 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x4.large.2e</b>: 4 cores, 16 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x4.xlarge.2e</b>: 8 cores, 32 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x4.2xlarge.2e</b>: 16 cores, 64 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x8.large.2e</b>: 4 cores, 32 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x2.large.2x</b>: 8 cores, 16 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x4.xlarge.2x</b>: 8 cores, 32 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x8.xlarge.2e</b>: 8 cores, 64 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x8.2xlarge.2e</b>: 16 cores, 128 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x4.4xlarge.2e</b>: 32 cores, 128 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x8.4xlarge.2e</b>: 32 cores, 256 GB (dedicated)</description></item>
        /// <item><description><b>polarx.st.8xlarge.2e</b>: 60 cores, 470 GB (dedicated)</description></item>
        /// <item><description><b>polarx.st.12xlarge.2e</b>: 90 cores, 720 GB (dedicated)</description></item>
        /// </list>
        /// <para>Enterprise Edition with cloud disks:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx.x4.medium.c2e</b>: 2 cores, 8 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x4.large.c2e</b>: 4 cores, 16 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x4.xlarge.c2e</b>: 8 cores, 32 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x4.2xlarge.c2e</b>: 16 cores, 64 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x8.large.c2e</b>: 4 cores, 32 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x2.large.c2x</b>: 8 cores, 16 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x4.xlarge.c2x</b>: 8 cores, 32 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x8.xlarge.c2e</b>: 8 cores, 64 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x8.2xlarge.c2e</b>: 16 cores, 128 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x4.4xlarge.c2e</b>: 32 cores, 128 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x8.4xlarge.c2e</b>: 32 cores, 256 GB (dedicated)</description></item>
        /// <item><description><b>polarx.st.8xlarge.c2e</b>: 60 cores, 470 GB (dedicated)</description></item>
        /// <item><description><b>polarx.st.12xlarge.c2e</b>: 90 cores, 720 GB (dedicated)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4 cores, 32 GB</para>
        /// </summary>
        [NameInMap("CnClass")]
        [Validation(Required=false)]
        public string CnClass { get; set; }

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
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>go-to-the-docks-for-french-fries</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The storage node specifications. This parameter is required for Enterprise Edition instances and is not required for Standard Edition instances.</para>
        /// <para>Enterprise Edition with local disks:</para>
        /// <list type="bullet">
        /// <item><description><b>mysql.n2.medium.25</b>: 2 cores, 4 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n4.medium.25</b>: 2 cores, 8 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n2.large.25</b>: 4 cores, 8 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n4.large.25</b>: 4 cores, 16 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n4.xlarge.25</b>: 8 cores, 32 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n4.2xlarge.25</b>: 16 cores, 64 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.x4.large.25</b>: 4 cores, 16 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.large.25</b>: 4 cores, 32 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x2.xlarge.25</b>: 8 cores, 16 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.xlarge.25</b>: 8 cores, 64 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.2xlarge.25</b>: 16 cores, 128 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x4.4xlarge.25</b>: 32 cores, 128 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.4xlarge.25</b>: 32 cores, 256 GB (dedicated)</description></item>
        /// <item><description><b>mysql.st.8xlarge.25</b>: 60 cores, 470 GB (dedicated)</description></item>
        /// <item><description><b>mysql.st.12xlarge.25</b>: 90 cores, 720 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.45xlarge.25</b>: 180 cores, 1440 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.60xlarge.25</b>: 240 cores, 1920 GB (dedicated)</description></item>
        /// </list>
        /// <para>Enterprise Edition with cloud disks:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx.mysql.n2.medium.c25</b>: 2 cores, 4 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.medium.c25</b>: 2 cores, 8 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n2.large.c25</b>: 4 cores, 8 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.large.c25</b>: 4 cores, 16 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.xlarge.c25</b>: 8 cores, 32 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.2xlarge.c25</b>: 16 cores, 64 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.x4.large.c25</b>: 4 cores, 16 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.large.c25</b>: 4 cores, 32 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x2.xlarge.c25</b>: 8 cores, 16 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.xlarge.c25</b>: 8 cores, 64 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.2xlarge.c25</b>: 16 cores, 128 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x4.4xlarge.c25</b>: 32 cores, 128 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.4xlarge.c25</b>: 32 cores, 256 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.st.8xlarge.c25</b>: 60 cores, 470 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.st.12xlarge.c25</b>: 90 cores, 720 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.45xlarge.c25</b>: 180 cores, 1440 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.60xlarge.c25</b>: 240 cores, 1920 GB (dedicated)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4 cores, 32 GB</para>
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
        /// <item><description><b>PREPAY</b>: subscription</description></item>
        /// <item><description><b>POSTPAY</b>: pay-as-you-go</description></item>
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
        /// <para>The unit of the subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Year</description></item>
        /// <item><description>Month</description></item>
        /// </list>
        /// <para>For pay-as-you-go instances, the default value is Hour.</para>
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
        /// <para>The region in which the instance resides.</para>
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
        /// <para>The secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen-a</para>
        /// </summary>
        [NameInMap("SecondaryZone")]
        [Validation(Required=false)]
        public string SecondaryZone { get; set; }

        /// <summary>
        /// <para>The edition of the instance. Valid values:</para>
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
        /// <para>The region in which the source instance resides.</para>
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
        /// <item><description><b>3azones</b>: three-zone deployment.</description></item>
        /// <item><description><b>1azone</b>: single-zone deployment.</description></item>
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
        /// <para>The subscription duration. Unit: months or years.</para>
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

    }

}
