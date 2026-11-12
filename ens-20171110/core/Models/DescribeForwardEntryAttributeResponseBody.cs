// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeForwardEntryAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the DNAT entry was created. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-04-26T15:38:27Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The elastic IP address (EIP) that provides public network access in the DNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36.XXX.XXX.72</para>
        /// </summary>
        [NameInMap("ExternalIp")]
        [Validation(Required=false)]
        public string ExternalIp { get; set; }

        /// <summary>
        /// <para>The external port or port range used for port forwarding.</para>
        /// <list type="bullet">
        /// <item><description>The port range must be from 1 to 65535.</description></item>
        /// <item><description>To forward traffic within a port range, separate the start port and the end port with a forward slash (/). Example: 10/20.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("ExternalPort")]
        [Validation(Required=false)]
        public string ExternalPort { get; set; }

        /// <summary>
        /// <para>The ID of the DNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fwd-5tfi6f0rutmd00xrhkag7****</para>
        /// </summary>
        [NameInMap("ForwardEntryId")]
        [Validation(Required=false)]
        public string ForwardEntryId { get; set; }

        /// <summary>
        /// <para>The name of the DNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test0</para>
        /// </summary>
        [NameInMap("ForwardEntryName")]
        [Validation(Required=false)]
        public string ForwardEntryName { get; set; }

        /// <summary>
        /// <para>The health check port for the DNAT entry. The port must be within the internal port range. Default value: null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("HealthCheckPort")]
        [Validation(Required=false)]
        public string HealthCheckPort { get; set; }

        /// <summary>
        /// <para>The private IP address of the instance that communicates with the Internet through the DNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.XXX.XXX.50</para>
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// <para>The internal port or port range used for port forwarding.</para>
        /// <list type="bullet">
        /// <item><description>The port range must be from 1 to 65535.</description></item>
        /// <item><description>To forward traffic within a port range, separate the start port and the end port with a forward slash (/). Example: 10/20.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("InternalPort")]
        [Validation(Required=false)]
        public string InternalPort { get; set; }

        /// <summary>
        /// <para>The protocol type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>TCP</b>: Forwards TCP packets.</para>
        /// </description></item>
        /// <item><description><para><b>UDP</b>: Forwards UDP packets.</para>
        /// </description></item>
        /// <item><description><para><b>Any</b>: Forwards packets of all protocols.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Any</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat-5t7nh1cfm6kxiszlttr38****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6666C5A5-75ED-422E-A022-7121FA18C968</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The standby elastic IP address (EIP) that provides public network access. You must select a standby EIP that is attached to the NAT gateway. The standby public IP address takes effect after the DNAT entry is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101.XXX.XXX.4</para>
        /// </summary>
        [NameInMap("StandbyExternalIp")]
        [Validation(Required=false)]
        public string StandbyExternalIp { get; set; }

        /// <summary>
        /// <para>The status of the standby EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running: The standby EIP is enabled.</description></item>
        /// <item><description>Stopping: The standby EIP is being disabled.</description></item>
        /// <item><description>Stopped: The standby EIP is disabled.</description></item>
        /// <item><description>Starting: The standby EIP is being enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Stopped</para>
        /// </summary>
        [NameInMap("StandbyStatus")]
        [Validation(Required=false)]
        public string StandbyStatus { get; set; }

        /// <summary>
        /// <para>The status of the DNAT entry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending: The DNAT entry is being configured. It may be being created or modified.</description></item>
        /// <item><description>Available: The DNAT entry is available.</description></item>
        /// <item><description>Deleting: The DNAT entry is being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
