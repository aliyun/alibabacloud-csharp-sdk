// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeForwardEntryAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-04-26T15:38:27Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The Elastic IP Address (EIP) that provides public network access in the DNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36.XXX.XXX.72</para>
        /// </summary>
        [NameInMap("ExternalIp")]
        [Validation(Required=false)]
        public string ExternalIp { get; set; }

        /// <summary>
        /// <para>The external port or port range for port forwarding.</para>
        /// <list type="bullet">
        /// <item><description><para>The port range must be between 1 and 65535.</para>
        /// </description></item>
        /// <item><description><para>To forward a port range, separate the start and end ports with a forward slash (/), such as 10/20.</para>
        /// </description></item>
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
        /// <para>The probe port for DNAT. It must fall within the internal port range. The default value is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("HealthCheckPort")]
        [Validation(Required=false)]
        public string HealthCheckPort { get; set; }

        /// <summary>
        /// <para>The private IP address of the instance that communicates over the public network through the DNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.XXX.XXX.50</para>
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// <para>The internal port or port range for port forwarding.</para>
        /// <list type="bullet">
        /// <item><description><para>The port range must be between 1 and 65535.</para>
        /// </description></item>
        /// <item><description><para>To forward a port range, separate the start and end ports with a forward slash (/), such as 10/20.</para>
        /// </description></item>
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
        /// <item><description><para><b>TCP</b>: Forwards TCP messages.</para>
        /// </description></item>
        /// <item><description><para><b>UDP</b>: Forwards UDP messages.</para>
        /// </description></item>
        /// <item><description><para><b>Any</b>: Forwards messages of all protocols.</para>
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
        /// <para>The ID of the NAT Gateway.</para>
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
        /// <para>The standby Elastic IP Address (EIP) that provides public network access. You must select a standby EIP attached to the NAT Gateway. The standby public IP becomes active after the DNAT entry is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101.XXX.XXX.4</para>
        /// </summary>
        [NameInMap("StandbyExternalIp")]
        [Validation(Required=false)]
        public string StandbyExternalIp { get; set; }

        /// <summary>
        /// <para>The status of the standby EIP.</para>
        /// <list type="bullet">
        /// <item><description><para>Running: Enabled.</para>
        /// </description></item>
        /// <item><description><para>Stopping: Being disabled.</para>
        /// </description></item>
        /// <item><description><para>Stopped: Disabled.</para>
        /// </description></item>
        /// <item><description><para>Starting: Being enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Stopped</para>
        /// </summary>
        [NameInMap("StandbyStatus")]
        [Validation(Required=false)]
        public string StandbyStatus { get; set; }

        /// <summary>
        /// <para>The status of the DNAT entry.</para>
        /// <list type="bullet">
        /// <item><description><para>Pending: The configuration is in progress, such as during creation or modification.</para>
        /// </description></item>
        /// <item><description><para>Available: The entry is active.</para>
        /// </description></item>
        /// <item><description><para>Deleting: The entry is being deleted.</para>
        /// </description></item>
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
