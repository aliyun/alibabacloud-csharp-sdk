// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreatePrivateDnsEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The name of the private instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AccessInstanceName")]
        [Validation(Required=false)]
        public string AccessInstanceName { get; set; }

        /// <summary>
        /// <para>The type of cloud firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>internet</b></description></item>
        /// <item><description><b>vpc</b></description></item>
        /// <item><description><b>nat</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public List<string> FirewallType { get; set; }

        /// <summary>
        /// <para>The IP protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UDP</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud member account.</para>
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
        /// <para>The primary DNS.</para>
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
        /// <para>vsw-uf6b0dkyryer8******</para>
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
        /// <para>The type of private DNS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrivateZone</b></description></item>
        /// <item><description><b>Custom</b> (default)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("PrivateDnsType")]
        [Validation(Required=false)]
        public string PrivateDnsType { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The standby DNS.</para>
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
        /// <para>vsw-8vb6jk75wfcwn******</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <para>The IP address of the standby vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.2.2.2</para>
        /// </summary>
        [NameInMap("StandbyVSwitchIp")]
        [Validation(Required=false)]
        public string StandbyVSwitchIp { get; set; }

        /// <summary>
        /// <para>The VPC instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6b5lyul0x******</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
