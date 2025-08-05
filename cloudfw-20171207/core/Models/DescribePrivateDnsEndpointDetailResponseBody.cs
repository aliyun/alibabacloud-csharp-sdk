// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePrivateDnsEndpointDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pd-12345</para>
        /// </summary>
        [NameInMap("AccessInstanceId")]
        [Validation(Required=false)]
        public string AccessInstanceId { get; set; }

        [NameInMap("AccessInstanceName")]
        [Validation(Required=false)]
        public string AccessInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>119898001566xxxx</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ep-1nmi412c28c374****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public List<string> FirewallType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1715075765</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("PrimaryDns")]
        [Validation(Required=false)]
        public string PrimaryDns { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-8vbno9zxz8j9qiot****</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.1.1.1</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchIp")]
        [Validation(Required=false)]
        public string PrimaryVSwitchIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shenzhen-d</para>
        /// </summary>
        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("PrivateDnsType")]
        [Validation(Required=false)]
        public string PrivateDnsType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4E7F94C7-781F-5192-86CF-DB0850****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.1.1.2</para>
        /// </summary>
        [NameInMap("StandbyDns")]
        [Validation(Required=false)]
        public string StandbyDns { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-8vb6jk75wfcwnuq****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.1.1.2</para>
        /// </summary>
        [NameInMap("StandbyVSwitchIp")]
        [Validation(Required=false)]
        public string StandbyVSwitchIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shenzhen-e</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-uf6b5lyul0x******</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
