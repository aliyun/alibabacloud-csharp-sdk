// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpgradeDetailGatewayStatusRecordValue : TeaModel {
        /// <summary>
        /// <para>The upgrade status of the ingress gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>upgrading</c>: The ingress gateway is being upgraded.</description></item>
        /// <item><description><c>pending</c>: The ingress gateway waits to be upgraded.</description></item>
        /// <item><description><c>finished</c>: The ingress gateway upgrade is complete.</description></item>
        /// <item><description><c>notStart</c>: The ingress gateway upgrade does not start.</description></item>
        /// <item><description><c>failed</c>: The ingress gateway upgrade fails.</description></item>
        /// <item><description><c>unknown</c>: The upgrade status of the ingress gateway is unknown.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>upgrading</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Additional status information of the ingress gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The version of the ingress gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.9.7</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
