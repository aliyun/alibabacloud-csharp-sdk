// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePrivateDnsEndpointDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pd-12345</para>
        /// </summary>
        [NameInMap("AccessInstanceId")]
        [Validation(Required=false)]
        public string AccessInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the access instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AccessInstanceName")]
        [Validation(Required=false)]
        public string AccessInstanceName { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>119898001566xxxx</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <para>The endpoint ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-1nmi412c28c374****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The type of the Cloud Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>internet</b></para>
        /// </description></item>
        /// <item><description><para><b>vpc</b></para>
        /// </description></item>
        /// <item><description><para><b>nat</b></para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public List<string> FirewallType { get; set; }

        /// <summary>
        /// <para>The time when the endpoint was created. This is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1715075765</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <para>The IP protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>TCP</b></para>
        /// </description></item>
        /// <item><description><para><b>UDP</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The UID of the member account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        /// <summary>
        /// <para>The port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The primary DNS server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("PrimaryDns")]
        [Validation(Required=false)]
        public string PrimaryDns { get; set; }

        /// <summary>
        /// <para>The ID of the primary vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-8vbno9zxz8j9qiot****</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        /// <summary>
        /// <para>The IP address of the primary vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.1.1.1</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchIp")]
        [Validation(Required=false)]
        public string PrimaryVSwitchIp { get; set; }

        /// <summary>
        /// <para>The zone of the primary vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen-d</para>
        /// </summary>
        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// <para>The type of the private DNS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PrivateZone</b></para>
        /// </description></item>
        /// <item><description><para><b>Custom</b> (Default)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("PrivateDnsType")]
        [Validation(Required=false)]
        public string PrivateDnsType { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E7F94C7-781F-5192-86CF-DB0850****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The standby DNS server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.2</para>
        /// </summary>
        [NameInMap("StandbyDns")]
        [Validation(Required=false)]
        public string StandbyDns { get; set; }

        /// <summary>
        /// <para>The ID of the standby vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-8vb6jk75wfcwnuq****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <para>The IP address of the standby vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.1.1.2</para>
        /// </summary>
        [NameInMap("StandbyVSwitchIp")]
        [Validation(Required=false)]
        public string StandbyVSwitchIp { get; set; }

        /// <summary>
        /// <para>The zone of the standby vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen-e</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>creating</b>: Creating.</para>
        /// </description></item>
        /// <item><description><para><b>deleting</b>: Deleting.</para>
        /// </description></item>
        /// <item><description><para><b>normal</b>: Normal.</para>
        /// </description></item>
        /// <item><description><para><b>updating</b>: Updating.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6b5lyul0x******</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
