// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigLayer4RemarkRequest : TeaModel {
        /// <summary>
        /// <para>The port forwarding rule that you want to manage.</para>
        /// <para>This parameter is a string that consists of JSON arrays. Each element in a JSON array indicates a port forwarding rule. You can perform this operation only on one port forwarding rule at a time.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/157484.html">DescribeNetworkRules</a> to query existing port forwarding rules.</para>
        /// </remarks>
        /// <para>Each port forwarding rule contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>InstanceId</b>: the ID of the instance. This field is required and must be of the STRING type.</description></item>
        /// <item><description><b>Protocol</b>: the forwarding protocol. This field is required and must be of the STRING type. Valid values: <b>tcp</b> and <b>udp</b>.</description></item>
        /// <item><description><b>FrontendPort</b>: the forwarding port. This field is required and must be of the INTEGER type.</description></item>
        /// <item><description><b>Remark</b>: the remarks of the port forwarding rule. This field is required and must be of the STRING type. The value can contain letters, digits, and some special characters, such as <c>, . + - * / _</c>. The value can be up to 200 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;InstanceId\&quot;:\&quot;ddosDip-sg-4hr2b3l****\&quot;,\&quot;FrontendPort\&quot;:2020,\&quot;Protocol\&quot;:\&quot;udp\&quot;,\&quot;Remark\&quot;:\&quot;test\&quot;}]</para>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public string Listeners { get; set; }

    }

}
