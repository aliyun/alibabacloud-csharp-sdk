// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class QueryAppTopologyResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The status code 200 indicates that the request was successful. If another status code is returned, the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned struct.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Data&quot;: {
        ///     &quot;nodes&quot;: [
        ///       {
        ///         &quot;data&quot;: {
        ///           &quot;duration&quot;: 0.2254335260115607,
        ///           &quot;requests&quot;: 1211,
        ///           &quot;type&quot;: &quot;MYSQL&quot;,
        ///           &quot;errors&quot;: 0
        ///         },
        ///         &quot;id&quot;: &quot;ggxw4lnjuz@c0507xxxx##MYSQL&quot;,
        ///         &quot;label&quot;: &quot;mysql-pod:3306(cart_db)&quot;
        ///       }
        ///     ],
        ///     &quot;edges&quot;: [
        ///       {
        ///         &quot;data&quot;: {
        ///           &quot;duration&quot;: 0.03333333333333333,
        ///           &quot;requests&quot;: 600,
        ///           &quot;type&quot;: &quot;UNKNOWN&quot;,
        ///           &quot;errors&quot;: 0
        ///         },
        ///         &quot;id&quot;: &quot;1974097372&quot;,
        ///         &quot;source&quot;: &quot;ggxw4lnjuz@456xxxxx&quot;,
        ///         &quot;target&quot;: &quot;ggxw4lnjuz@c0507xxxx&quot;
        ///       }
        ///     ]
        ///   }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal error. Please try again. Contact the DingTalk service account if the issue                              persists after multiple retries.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78901766-3806-4E96-8E47-CFEF59E4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
