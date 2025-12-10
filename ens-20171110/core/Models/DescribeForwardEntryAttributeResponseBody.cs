// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeForwardEntryAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-04-26T15:38:27Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The EIP in the DNAT entry. The public IP address is used to access the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36.XXX.XXX.72</para>
        /// </summary>
        [NameInMap("ExternalIp")]
        [Validation(Required=false)]
        public string ExternalIp { get; set; }

        /// <summary>
        /// <para>The external port or port range that is used for port forwarding.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 1 to 65535.</description></item>
        /// <item><description>To specify a port range, separate the first port and the last port with a forward slash (/), such as 10/20.</description></item>
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
        /// <para>The DNAT probe port. The port must be within the internal port range. By default, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("HealthCheckPort")]
        [Validation(Required=false)]
        public string HealthCheckPort { get; set; }

        /// <summary>
        /// <para>The private IP address of the instance that uses the DNAT entry for Internet communication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.XXX.XXX.50</para>
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// <para>The internal port or port range that is used for port forwarding.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 1 to 65535.</description></item>
        /// <item><description>To specify a port range, separate the first port and the last port with a forward slash (/), such as 10/20.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("InternalPort")]
        [Validation(Required=false)]
        public string InternalPort { get; set; }

        /// <summary>
        /// <para>The protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b>: forwards TCP packets.</description></item>
        /// <item><description><b>UDP</b>: forwards UDP packets.</description></item>
        /// <item><description><b>Any</b>: forwards all packets.</description></item>
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
        /// <para>The secondary EIP that is used to access the Internet. You need to select a secondary EIP that is bound to NAT. After the DNAT entry is created, the secondary EIP takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101.XXX.XXX.4</para>
        /// </summary>
        [NameInMap("StandbyExternalIp")]
        [Validation(Required=false)]
        public string StandbyExternalIp { get; set; }

        /// <summary>
        /// <para>The status of the secondary EIP.</para>
        /// <list type="bullet">
        /// <item><description>Running</description></item>
        /// <item><description>Stopping</description></item>
        /// <item><description>Stopped</description></item>
        /// <item><description>Starting</description></item>
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
        /// <item><description>Pending: The DNAT entry is being created or modified.</description></item>
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
