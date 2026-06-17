// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetSupabaseProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the <b>auto pause and resume</b> feature is enabled.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The feature is enabled. The project automatically pauses and resumes based on traffic.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The feature is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoScale")]
        [Validation(Required=false)]
        public string AutoScale { get; set; }

        /// <summary>
        /// <para>The creation time of the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The database IP address whitelist, specified as a comma-separated string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1,100.64.XX.XX/10</para>
        /// </summary>
        [NameInMap("DBSecurityIpList")]
        [Validation(Required=false)]
        public string DBSecurityIpList { get; set; }

        /// <summary>
        /// <para>The password for the Supabase Dashboard. This parameter is not used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxpassword</para>
        /// </summary>
        [NameInMap("DashboardPassword")]
        [Validation(Required=false)]
        public string DashboardPassword { get; set; }

        /// <summary>
        /// <para>The username for the Supabase Dashboard. This parameter is not used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("DashboardUserName")]
        [Validation(Required=false)]
        public string DashboardUserName { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PL0</para>
        /// </description></item>
        /// <item><description><para>PL1</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("DiskPerformanceLevel")]
        [Validation(Required=false)]
        public string DiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>postgres</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The elastic network interface (ENI) ID.</para>
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

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>POSTPAY</c>: pay-as-you-go</para>
        /// </description></item>
        /// <item><description><para><c>PREPAY</c>: subscription</para>
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
        /// <para>The private connection URL for the Supabase Dashboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.11</para>
        /// </summary>
        [NameInMap("PrivateConnectUrl")]
        [Validation(Required=false)]
        public string PrivateConnectUrl { get; set; }

        /// <summary>
        /// <para>The description of the Supabase project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>for-test-project</para>
        /// </summary>
        [NameInMap("ProjectDescription")]
        [Validation(Required=false)]
        public string ProjectDescription { get; set; }

        /// <summary>
        /// <para>The Supabase project ID.</para>
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
        /// <para>The Supabase instance specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1C1G</para>
        /// </summary>
        [NameInMap("ProjectSpec")]
        [Validation(Required=false)]
        public string ProjectSpec { get; set; }

        /// <summary>
        /// <para>The public connection URL for the Supabase Dashboard.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query the available regions.</para>
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
        /// <para>The IP address whitelist, specified as a comma-separated string.</para>
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
        /// <para>The storage space, in GB.</para>
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
        /// <item><description><para><b>cloud_essd_pl0</b></para>
        /// </description></item>
        /// <item><description><para><b>cloud_essd_pl1</b></para>
        /// </description></item>
        /// <item><description><para><b>cloud_essd_pl2</b></para>
        /// </description></item>
        /// <item><description><para><b>cloud_essd_pl3</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd_pl0</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
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
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/208327.html">DescribeRdsVpcs</a> operation to query the available VPCs.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required.</para>
        /// </description></item>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query the available zones.</para>
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
