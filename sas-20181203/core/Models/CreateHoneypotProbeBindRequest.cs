// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotProbeBindRequest : TeaModel {
        /// <summary>
        /// <para>The list of port bindings.</para>
        /// </summary>
        [NameInMap("BindPortList")]
        [Validation(Required=false)]
        public List<CreateHoneypotProbeBindRequestBindPortList> BindPortList { get; set; }
        public class CreateHoneypotProbeBindRequestBindPortList : TeaModel {
            /// <summary>
            /// <para>Specifies whether to bind the port. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The port is bound.</description></item>
            /// <item><description><b>false</b>: The port is not bound.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BindPort")]
            [Validation(Required=false)]
            public bool? BindPort { get; set; }

            /// <summary>
            /// <para>The end port of the probe listener.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("EndPort")]
            [Validation(Required=false)]
            public int? EndPort { get; set; }

            /// <summary>
            /// <para>Specifies whether the port is fixed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The port is fixed.</description></item>
            /// <item><description><b>false</b>: The port is not fixed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Fixed")]
            [Validation(Required=false)]
            public bool? Fixed { get; set; }

            /// <summary>
            /// <para>The protocol type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tcp</b>: TCP protocol.</description></item>
            /// <item><description><b>udp</b>: UDP protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            /// <summary>
            /// <para>The start port of the probe listener.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("StartPort")]
            [Validation(Required=false)]
            public int? StartPort { get; set; }

            /// <summary>
            /// <para>The destination port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("TargetPort")]
            [Validation(Required=false)]
            public int? TargetPort { get; set; }

        }

        /// <summary>
        /// <para>The honeypot ID.</para>
        /// <remarks>
        /// <para>Call the <a href="~~ListHoneypot~~">ListHoneypot</a> operation to obtain this value.
        /// This parameter is required. If this parameter is not specified, the API returns InternalError (400).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dba7d44775be8e0e5888ee3b1a62554a93d2512247cabc38ddeac17a3b3f****</para>
        /// </summary>
        [NameInMap("HoneypotId")]
        [Validation(Required=false)]
        public string HoneypotId { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The probe ID.</para>
        /// <remarks>
        /// <para>Call the <a href="~~ListHoneypotProbe~~">ListHoneypotProbe</a> operation to obtain this parameter.
        /// This parameter is required. If this parameter is not specified, the API returns InvalidParam (400).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>36bad711-d1ac-4419-ac68-c1aa280f****</para>
        /// </summary>
        [NameInMap("ProbeId")]
        [Validation(Required=false)]
        public string ProbeId { get; set; }

        /// <summary>
        /// <para>The list of listener IP addresses.</para>
        /// </summary>
        [NameInMap("ServiceIpList")]
        [Validation(Required=false)]
        public List<string> ServiceIpList { get; set; }

    }

}
