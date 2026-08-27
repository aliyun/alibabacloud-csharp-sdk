// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetSupabaseProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether <b>auto start/stop</b> is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled. When enabled, Supabase automatically pauses and resumes based on traffic conditions.</description></item>
        /// <item><description>false: Disabled. When disabled, the auto start/stop feature of Supabase is turned off.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoScale")]
        [Validation(Required=false)]
        public string AutoScale { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The database whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1,100.64.XX.XX/10</para>
        /// </summary>
        [NameInMap("DBSecurityIpList")]
        [Validation(Required=false)]
        public string DBSecurityIpList { get; set; }

        /// <summary>
        /// <para>The Supabase Dashboard password (not currently in use).</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxpassword</para>
        /// </summary>
        [NameInMap("DashboardPassword")]
        [Validation(Required=false)]
        public string DashboardPassword { get; set; }

        /// <summary>
        /// <para>The Supabase Dashboard username (not currently in use).</para>
        /// 
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("DashboardUserName")]
        [Validation(Required=false)]
        public string DashboardUserName { get; set; }

        /// <summary>
        /// <para>The cloud disk performance level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0</description></item>
        /// <item><description>PL1</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("DiskPerformanceLevel")]
        [Validation(Required=false)]
        public string DiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The database engine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>postgres</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The DPI engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The elastic network interfaces (ENIs) ID, which identifies the network interface controller (NIC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-xxxxxx</para>
        /// </summary>
        [NameInMap("Eni")]
        [Validation(Required=false)]
        public string Eni { get; set; }

        /// <summary>
        /// <para>The current instance version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.0.3</para>
        /// </summary>
        [NameInMap("InstanceVersion")]
        [Validation(Required=false)]
        public string InstanceVersion { get; set; }

        [NameInMap("Lightweight")]
        [Validation(Required=false)]
        public string Lightweight { get; set; }

        /// <summary>
        /// <para>The billing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>POSTPAY: Pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para>PREPAY: Subscription.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The internal network connection string of the Supabase Dashboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.11</para>
        /// </summary>
        [NameInMap("PrivateConnectUrl")]
        [Validation(Required=false)]
        public string PrivateConnectUrl { get; set; }

        /// <summary>
        /// <para>The detailed description of the Supabase project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>for-test-project</para>
        /// </summary>
        [NameInMap("ProjectDescription")]
        [Validation(Required=false)]
        public string ProjectDescription { get; set; }

        /// <summary>
        /// <para>The Supabase instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sbp-545434</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The Supabase project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>supabase_project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The Supabase instance specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1C1G</para>
        /// </summary>
        [NameInMap("ProjectSpec")]
        [Validation(Required=false)]
        public string ProjectSpec { get; set; }

        /// <summary>
        /// <para>The public network connection string of the Supabase Dashboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.154.11.10</para>
        /// </summary>
        [NameInMap("PublicConnectUrl")]
        [Validation(Required=false)]
        public string PublicConnectUrl { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query available region IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of IP addresses in the IP whitelist group, separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("SecurityIpList")]
        [Validation(Required=false)]
        public string SecurityIpList { get; set; }

        /// <summary>
        /// <para>The Supabase instance status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The storage size. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_essd_pl0</b></description></item>
        /// <item><description><b>cloud_essd_pl1</b></description></item>
        /// <item><description><b>cloud_essd_pl2</b></description></item>
        /// <item><description><b>cloud_essd_pl3</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd_pl0</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. This parameter is required if a VPC ID is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1cpq8mr64paltkb****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/208327.html">DescribeRdsVpcs</a> operation to query available VPC IDs.</description></item>
        /// <item><description>This parameter is required.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp*******************</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query available zone IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
