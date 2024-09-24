// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotProbeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable Address Resolution Protocol (ARP) spoofing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Arp")]
        [Validation(Required=false)]
        public bool? Arp { get; set; }

        /// <summary>
        /// <para>The ID of the business group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022011817324588686</para>
        /// </summary>
        [NameInMap("BusinessGroupId")]
        [Validation(Required=false)]
        public string BusinessGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the management node.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListHoneypotNode~~">ListHoneypotNode</a> operation to query the IDs of management nodes.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a882e590-b87b-45a6-87b9-d0a3e5a0****</para>
        /// </summary>
        [NameInMap("ControlNodeId")]
        [Validation(Required=false)]
        public string ControlNodeId { get; set; }

        /// <summary>
        /// <para>The name of the probe.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testHoneyPotProbe</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The configuration of the probe.</para>
        /// </summary>
        [NameInMap("HoneypotBindList")]
        [Validation(Required=false)]
        public List<CreateHoneypotProbeRequestHoneypotBindList> HoneypotBindList { get; set; }
        public class CreateHoneypotProbeRequestHoneypotBindList : TeaModel {
            /// <summary>
            /// <para>The listener ports.</para>
            /// </summary>
            [NameInMap("BindPortList")]
            [Validation(Required=false)]
            public List<CreateHoneypotProbeRequestHoneypotBindListBindPortList> BindPortList { get; set; }
            public class CreateHoneypotProbeRequestHoneypotBindListBindPortList : TeaModel {
                /// <summary>
                /// <para>Specifies whether to bind a port. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: yes</description></item>
                /// <item><description><b>false</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("BindPort")]
                [Validation(Required=false)]
                public bool? BindPort { get; set; }

                /// <summary>
                /// <para>The end of the port range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("EndPort")]
                [Validation(Required=false)]
                public int? EndPort { get; set; }

                /// <summary>
                /// <para>Specifies whether the port is a fixed port. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: no</description></item>
                /// <item><description><b>1</b>: yes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Fixed")]
                [Validation(Required=false)]
                public bool? Fixed { get; set; }

                /// <summary>
                /// <para>The start of the port range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("StartPort")]
                [Validation(Required=false)]
                public int? StartPort { get; set; }

                /// <summary>
                /// <para>The destination port.</para>
                /// <remarks>
                /// <para>If <b>HoneypotId</b> is specified, this parameter is required.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public int? TargetPort { get; set; }

            }

            /// <summary>
            /// <para>The ID of the honeypot.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~ListHoneypot~~">ListHoneypot</a> operation to query the IDs of honeypots.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1a5eda2d40f92ac87d6b63e1a5ad4b76fe0d4110c4a3e2fa85438a29ae55****</para>
            /// </summary>
            [NameInMap("HoneypotId")]
            [Validation(Required=false)]
            public string HoneypotId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable ping scan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Ping")]
        [Validation(Required=false)]
        public bool? Ping { get; set; }

        /// <summary>
        /// <para>The type of the probe. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>host_probe</b>: host probe</description></item>
        /// <item><description><b>vpc_black_hole_probe</b>: virtual private cloud (VPC) probe</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>host_probe</para>
        /// </summary>
        [NameInMap("ProbeType")]
        [Validation(Required=false)]
        public string ProbeType { get; set; }

        /// <summary>
        /// <para>The version of the probe.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0</para>
        /// </summary>
        [NameInMap("ProbeVersion")]
        [Validation(Required=false)]
        public string ProbeVersion { get; set; }

        /// <summary>
        /// <para>The IP address of the proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("ProxyIp")]
        [Validation(Required=false)]
        public string ProxyIp { get; set; }

        /// <summary>
        /// <para>The UUID of the instance.</para>
        /// <remarks>
        /// <para>If <b>ProbeType</b> is set to <b>host_probe</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>e4af3620-6895-4e2f-a641-a9d8fb53****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// <remarks>
        /// <para>If <b>ProbeType</b> is set to <b>vpc_black_hole_probe</b>, this parameter is required. You can call the <a href="~~DescribeVpcHoneyPotList~~">DescribeVpcHoneyPotList</a> operation to query the IDs of VPCs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-zm0asrkpv1q8gnk7mn4dn</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
