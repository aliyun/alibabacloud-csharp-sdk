// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshAdditionalStatusRequest : TeaModel {
        /// <summary>
        /// <para>The check mode of the ASM instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>normal</c>: checks the Server Load Balancer (SLB) instances created for exposing the API server and Istio Pilot, audit logs, and installation of Logtail for clusters on the data plane.</description></item>
        /// <item><description><c>full</c>: checks control plane logs, access logs, security groups, and the elastic IP addresses (EIPs) of the API server in addition to the check items in normal mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>full</para>
        /// </summary>
        [NameInMap("CheckMode")]
        [Validation(Required=false)]
        public string CheckMode { get; set; }

        /// <summary>
        /// <para>The ID of the ASM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca04bc38979214bf2882be79d39b4****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
