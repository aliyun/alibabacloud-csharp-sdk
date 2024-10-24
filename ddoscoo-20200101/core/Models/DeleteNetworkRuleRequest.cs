// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DeleteNetworkRuleRequest : TeaModel {
        /// <summary>
        /// <para>An array that consists of the information about the port forwarding rule. This parameter is a JSON string. The string contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>InstanceId</b>: the ID of the instance. This field is required and must be of the STRING type.</description></item>
        /// <item><description><b>Protocol</b>: the forwarding protocol. This field is required and must be of the STRING type. Valid values: <b>tcp</b> and <b>udp</b>.</description></item>
        /// <item><description><b>FrontendPort</b>: the forwarding port. This field is required and must be of the INTEGER type.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;InstanceId&quot;:&quot;ddoscoo-cn-mp91j1ao****&quot;,&quot;Protocol&quot;:&quot;tcp&quot;,&quot;FrontendPort&quot;:8080}]</para>
        /// </summary>
        [NameInMap("NetworkRule")]
        [Validation(Required=false)]
        public string NetworkRule { get; set; }

    }

}
