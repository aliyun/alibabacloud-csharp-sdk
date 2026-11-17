// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyRouterInterfaceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete the health check IP address configured on the router interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: deletes the health check IP address.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): does not delete the health check IP address.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteHealthCheckIp")]
        [Validation(Required=false)]
        public bool? DeleteHealthCheckIp { get; set; }

        /// <summary>
        /// <para>The description of the router interface. </para>
        /// <para>The description must be 2 to 256 characters in length and must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Router interface</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The health check interval. Unit: milliseconds. The recommended value is <b>2000</b>. This value specifies the time interval at which consecutive probe packets are sent during a health check.</para>
        /// <para>In this example, <b>HcThreshold</b> is set to <b>8</b> and <b>HcRate</b> is set to <b>2000</b>. This means that a probe packet is sent from <b>HealthCheckSourceIp</b> (the source IP address for health checks) to <b>HealthCheckTargetIp</b> (the destination IP address for health checks) every 2,000 milliseconds during a health check. If no response is received for eight consecutive probe packets, the health check fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("HcRate")]
        [Validation(Required=false)]
        public int? HcRate { get; set; }

        /// <summary>
        /// <para>The health check threshold. Unit: packets. The recommended value is <b>8</b>. This value specifies the number of probe packets sent during a health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("HcThreshold")]
        [Validation(Required=false)]
        public int? HcThreshold { get; set; }

        /// <summary>
        /// <para>The source IP address for health checks. It must be an unused IP address in the local VPC.</para>
        /// <remarks>
        /// <para>You can specify this parameter in Express Connect circuit scenarios.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>116.62.XX.XX</para>
        /// </summary>
        [NameInMap("HealthCheckSourceIp")]
        [Validation(Required=false)]
        public string HealthCheckSourceIp { get; set; }

        /// <summary>
        /// <para>The destination IP address for health checks. </para>
        /// <remarks>
        /// <para>This parameter is required after you specify <b>HealthCheckSourceIp</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>116.62.XX.XX</para>
        /// </summary>
        [NameInMap("HealthCheckTargetIp")]
        [Validation(Required=false)]
        public string HealthCheckTargetIp { get; set; }

        /// <summary>
        /// <para>The name of the router interface.</para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It can contain digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEST</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the peer router interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ri-2zeo3xzyf38r4urz****</para>
        /// </summary>
        [NameInMap("OppositeInterfaceId")]
        [Validation(Required=false)]
        public string OppositeInterfaceId { get; set; }

        /// <summary>
        /// <para>The account ID of the peer router interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28768383240243****</para>
        /// </summary>
        [NameInMap("OppositeInterfaceOwnerId")]
        [Validation(Required=false)]
        public long? OppositeInterfaceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the peer vRouter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vrt-bp1jcg5cmxjbl9xgc****</para>
        /// </summary>
        [NameInMap("OppositeRouterId")]
        [Validation(Required=false)]
        public string OppositeRouterId { get; set; }

        /// <summary>
        /// <para>The type of the vRouter to which the peer router interface belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VRouter</b>: vRouter.</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b> (default): Virtual Border Router (VBR).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VBR</para>
        /// </summary>
        [NameInMap("OppositeRouterType")]
        [Validation(Required=false)]
        public string OppositeRouterType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the router interface.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the router interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ri-2zeo3xzyf38r4urz****</para>
        /// </summary>
        [NameInMap("RouterInterfaceId")]
        [Validation(Required=false)]
        public string RouterInterfaceId { get; set; }

    }

}
