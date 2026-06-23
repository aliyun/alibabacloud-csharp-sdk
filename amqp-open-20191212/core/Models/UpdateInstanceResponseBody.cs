// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class UpdateInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data. It includes the order ID and instance ID. For example:</para>
        /// <pre><code class="language-json">&quot;Data&quot;: {
        ///     &quot;instanceId&quot;: &quot;amqp-cn-xxxxx&quot;,
        ///     &quot;orderId&quot;: 22222
        ///   }
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;instanceId\&quot;: \&quot;rabbitmq-serverless-cn-lf63qsjlf06\&quot;, \&quot;orderId\&quot;: 234170302080010}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceNotExist</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. Each request has a unique ID. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>628705FD-03EE-4ABE-BB21-E1672960***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
