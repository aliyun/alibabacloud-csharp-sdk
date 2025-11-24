// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeClusterPrometheusResponseBody : TeaModel {
        /// <summary>
        /// <para>The public endpoint of the Prometheus service that is used to monitor a cluster in the ASM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p.com</para>
        /// </summary>
        [NameInMap("Prometheus")]
        [Validation(Required=false)]
        public string Prometheus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD65C0AD-D3C6-48D3-8D93-38D2015C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
