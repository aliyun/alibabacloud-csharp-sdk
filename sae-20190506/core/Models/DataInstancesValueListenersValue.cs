// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DataInstancesValueListenersValue : TeaModel {
        /// <summary>
        /// <para>The listener protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCPSSL</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The listener port of the NLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The status of the NLB listener.</para>
        /// <list type="bullet">
        /// <item><description><b>Creating</b>: The listener is being created.</description></item>
        /// <item><description><b>Configuring</b>: The listener is being configured.</description></item>
        /// <item><description><b>Bounded</b>: The listener runs as expected.</description></item>
        /// <item><description><b>Unbinding</b>: The listener is being deleted.</description></item>
        /// <item><description><b>Failed</b>: The listener is unavailable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Bounded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The open ports of the NLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("TargetPort")]
        [Validation(Required=false)]
        public int? TargetPort { get; set; }

        /// <summary>
        /// <para>The server certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123157******</para>
        /// </summary>
        [NameInMap("CertIds")]
        [Validation(Required=false)]
        public string CertIds { get; set; }

    }

}
