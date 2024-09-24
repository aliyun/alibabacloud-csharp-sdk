// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateHoneypotProbeBindRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the honeypot to which the probe is bound.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f52e8624-e43c-473c-8312-e0fed384****</para>
        /// </summary>
        [NameInMap("BindId")]
        [Validation(Required=false)]
        public string BindId { get; set; }

        /// <summary>
        /// <para>The ports that are bound to the probe.</para>
        /// </summary>
        [NameInMap("BindPortList")]
        [Validation(Required=false)]
        public List<UpdateHoneypotProbeBindRequestBindPortList> BindPortList { get; set; }
        public class UpdateHoneypotProbeBindRequestBindPortList : TeaModel {
            /// <summary>
            /// <para>Specifies whether to bind a port. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BindPort")]
            [Validation(Required=false)]
            public bool? BindPort { get; set; }

            /// <summary>
            /// <para>The end port on which the probe monitors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("EndPort")]
            [Validation(Required=false)]
            public int? EndPort { get; set; }

            /// <summary>
            /// <para>Specifies whether the port is fixed. Valid values:</para>
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
            /// <para>The UUID of the port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3183</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The type of the protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tcp</b></description></item>
            /// <item><description><b>udp</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            /// <summary>
            /// <para>The start port on which the probe monitors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("StartPort")]
            [Validation(Required=false)]
            public int? StartPort { get; set; }

            /// <summary>
            /// <para>The destination port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("TargetPort")]
            [Validation(Required=false)]
            public int? TargetPort { get; set; }

        }

        /// <summary>
        /// <para>The operation that the probe performs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>forward_honey</b>: forward traffic to a honeypot</description></item>
        /// <item><description><b>scan_port</b>: monitor and scan</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>forward_honey</para>
        /// </summary>
        [NameInMap("BindType")]
        [Validation(Required=false)]
        public string BindType { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The honeypot ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListHoneypot~~">ListHoneypot</a> operation to obtain the IDs of honeypots.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dba7d44775be8e0e5888ee3b1a62554a93d2512247cabc38ddeac17a3b3f****</para>
        /// </summary>
        [NameInMap("HoneypotId")]
        [Validation(Required=false)]
        public string HoneypotId { get; set; }

        /// <summary>
        /// <para>The port ID of the probe service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1906</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned per page.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ports that are monitored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;tcp\&quot;:\&quot;1-65535\&quot;,\&quot;udp\&quot;:\&quot;1-65535\&quot;}</para>
        /// </summary>
        [NameInMap("Ports")]
        [Validation(Required=false)]
        public string Ports { get; set; }

        /// <summary>
        /// <para>The probe ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListHoneypotProbe~~">ListHoneypotProbe</a> operation to query the IDs of probes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>36bad711-d1ac-4419-ac68-c1aa280f****</para>
        /// </summary>
        [NameInMap("ProbeId")]
        [Validation(Required=false)]
        public string ProbeId { get; set; }

        /// <summary>
        /// <para>The IP addresses that are monitored.</para>
        /// </summary>
        [NameInMap("ServiceIpList")]
        [Validation(Required=false)]
        public List<string> ServiceIpList { get; set; }

        /// <summary>
        /// <para>The status of the port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SetStatus")]
        [Validation(Required=false)]
        public int? SetStatus { get; set; }

    }

}
