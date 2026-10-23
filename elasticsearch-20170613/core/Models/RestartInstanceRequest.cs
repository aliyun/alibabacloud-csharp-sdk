// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class RestartInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The restart parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <ol>
        /// <item><description>restart nodes example:
        /// {
        ///   &quot;restartType&quot;: &quot;nodeIp&quot;,
        ///   &quot;nodes&quot;: [
        ///  &quot;es-cn-xx-data-j-0&quot;
        ///   ],
        ///   &quot;blueGreenDep&quot;: false
        /// }</description></item>
        /// <item><description>restart instance example:
        /// {
        ///   &quot;restartType&quot;: &quot;instance&quot;,
        ///   &quot;blueGreenDep&quot;: false
        /// }</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can generate the value of this parameter on the client side. Ensure that the value is unique across different requests and contains a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to ignore the cluster state and force a restart. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Ignores the cluster state.</description></item>
        /// <item><description>false: Does not ignore the cluster state. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
