// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetClusterAllUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. 200 means success, other status codes are exceptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response parameters in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;RequestId&quot;: &quot;41877338-646B-5DD6-BFBE-F89F1E7245AD&quot;,
        ///   &quot;Data&quot;: &quot;{\&quot;clusterType\&quot;:\&quot;ManagedKubernetes\&quot;,\&quot;remoteWriteUrl\&quot;:\&quot;http:/&quot; }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The prompt information of the returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40B10E04-81E8-4643-970D-F1B38F2E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the query is successful:</para>
        /// <list type="bullet">
        /// <item><description>true: success</description></item>
        /// <item><description>false: failure</description></item>
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
