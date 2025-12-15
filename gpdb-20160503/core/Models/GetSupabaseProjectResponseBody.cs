// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetSupabaseProjectResponseBody : TeaModel {
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
        /// <para>The Supabase Dashboard password (Not Used)</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxpassword</para>
        /// </summary>
        [NameInMap("DashboardPassword")]
        [Validation(Required=false)]
        public string DashboardPassword { get; set; }

        /// <summary>
        /// <para>The Supabase Dashboard user name (Not Used)</para>
        /// 
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("DashboardUserName")]
        [Validation(Required=false)]
        public string DashboardUserName { get; set; }

        /// <summary>
        /// <para>The Enterprise SSD (ESSD) performance level of the cluster. Valid values:</para>
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
        /// <para>The type of the database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>postgres</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The version of the database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("Eni")]
        [Validation(Required=false)]
        public string Eni { get; set; }

        [NameInMap("InstanceVersion")]
        [Validation(Required=false)]
        public string InstanceVersion { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The private (VPC) connection URL for the Supabase Dashboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.11</para>
        /// </summary>
        [NameInMap("PrivateConnectUrl")]
        [Validation(Required=false)]
        public string PrivateConnectUrl { get; set; }

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
        /// <para>The name of the Supabase project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>supabase_project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The performance level of the Supabase instance.</para>
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
        /// <para>The region ID of the cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A comma-separated list of IP addresses and CIDR blocks allowed to connect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("SecurityIpList")]
        [Validation(Required=false)]
        public string SecurityIpList { get; set; }

        /// <summary>
        /// <para>The status of the Supabase instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The storage capacity of the instance. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the instance. This parameter must be specified when VPCId is specified.</para>
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
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/208327.html">DescribeRdsVpcs</a> operation to query the available VPC IDs.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required.</para>
        /// </description></item>
        /// </list>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query the most recent region list and zone list.</para>
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
