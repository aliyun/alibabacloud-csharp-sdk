// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the HSM.</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyInstance Instance { get; set; }
        public class GetInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// <para>The ID of the cluster to which the HSM belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster-w3G9vOJI2****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster_online</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The time when the HSM was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1699515963000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The type of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jnta.SJJ1528-G</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>The time when the HSM expired.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1699496389720</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The ID of the HSM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hsm-cn-g4t3jwsc****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The IP address of the HSM in the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.192.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>Indicates whether the HSM is for trial use. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsTrial")]
            [Validation(Required=false)]
            public bool? IsTrial { get; set; }

            /// <summary>
            /// <para>Indicates whether the HSM is a master HSM. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Master")]
            [Validation(Required=false)]
            public bool? Master { get; set; }

            /// <summary>
            /// <para>The ID of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23576634952****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PqcEnabled")]
            [Validation(Required=false)]
            public int? PqcEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The description of the HSM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hsmOnline</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The status of the HSM. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PENDING: The HSM is disabled.</description></item>
            /// <item><description>ACTIVE: The HSM is enabled.</description></item>
            /// <item><description>EXPIRED: The HSM expired.</description></item>
            /// <item><description>INVALID: The HSM is invalid.</description></item>
            /// <item><description>FAILURE: The HSM failed to be created.</description></item>
            /// <item><description>RESET: The HSM is being reset.</description></item>
            /// <item><description>PAUSED: The HSM is paused.</description></item>
            /// <item><description>MODIFYING: The HSM is being modified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EXPIRED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of HSMs that is classified based on resource isolation. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>vsm: Virtual security modules (VSMs)</description></item>
            /// <item><description>hostedHsm: Dedicated HSMs.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsm</para>
            /// </summary>
            [NameInMap("TenantIsolationType")]
            [Validation(Required=false)]
            public string TenantIsolationType { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch that is configured for the HSM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1mvfs31ltt0wyhf****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The information about the vendor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jnta</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) to which the HSM belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf69i66j9kmoko52p****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The IP addresses in the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18.68.XX.XX</para>
            /// </summary>
            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public string Whitelist { get; set; }

            /// <summary>
            /// <para>The ID of the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-447D-87BC-AC049166F216</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
