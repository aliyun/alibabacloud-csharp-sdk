// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyRouterInterfaceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete the health check IP addresses configured on the router interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteHealthCheckIp")]
        [Validation(Required=false)]
        public bool? DeleteHealthCheckIp { get; set; }

        /// <summary>
        /// <para>The description of the router interface.</para>
        /// <para>The value must be 2 to 256 characters in length. It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The description of the router interface.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The rate of health checks. Unit: milliseconds. The recommended value is <b>2000</b>. This value specifies the interval at which probe packets are sent during a health check.</para>
        /// <para>In this example, <b>HcThreshold</b> is set to <b>8</b> and <b>HcRate</b> is set to <b>2000</b>. In this example, probe packets are sent from <b>HealthCheckSourceIp</b> (source address) to <b>HealthCheckTargetIp</b> (destination address) every 2,000 seconds. If no response is returned for eight consecutive times, the health check fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("HcRate")]
        [Validation(Required=false)]
        public int? HcRate { get; set; }

        /// <summary>
        /// <para>The healthy threshold. Unit: packets. We recommend that you set the value to <b>8</b>. This value specifies the number of probe packets that are sent during a health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("HcThreshold")]
        [Validation(Required=false)]
        public int? HcThreshold { get; set; }

        /// <summary>
        /// <para>The source IP address that is used to perform health checks. The source IP address must be an idle IP address of the local virtual private cloud (VPC).</para>
        /// <remarks>
        /// <para> You can set this parameter when an Express Connect circuit is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>116.62.XX.XX</para>
        /// </summary>
        [NameInMap("HealthCheckSourceIp")]
        [Validation(Required=false)]
        public string HealthCheckSourceIp { get; set; }

        /// <summary>
        /// <para>The destination IP address that is used to perform health checks.</para>
        /// <remarks>
        /// <para> This parameter is required when <b>HealthCheckSourceIp</b> is specified.</para>
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
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.</para>
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
        /// <para>The ID of the Alibaba Cloud account to which the peer router interface belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28768383240243****</para>
        /// </summary>
        [NameInMap("OppositeInterfaceOwnerId")]
        [Validation(Required=false)]
        public long? OppositeInterfaceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the peer router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vrt-bp1jcg5cmxjbl9xgc****</para>
        /// </summary>
        [NameInMap("OppositeRouterId")]
        [Validation(Required=false)]
        public string OppositeRouterId { get; set; }

        /// <summary>
        /// <para>The type of router to which the peer router interface belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VRouter</b></description></item>
        /// <item><description><b>VBR</b> (default)</description></item>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
