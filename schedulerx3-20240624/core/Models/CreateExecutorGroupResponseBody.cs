// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class CreateExecutorGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateExecutorGroupResponseBodyData Data { get; set; }
        public class CreateExecutorGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The authentication method used by devices under the product to connect to the IoT platform. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>secret</b>: Uses the device secret for device identity authentication.</description></item>
            /// <item><description><b>id2</b>: Uses IoT Internet Device ID (ID²).</description></item>
            /// <item><description><b>x509</b>: Uses the device X.509 certificate for device identity authentication.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>md5_spell</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The workflow description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my first workflow</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The Kubernetes services that failed to be imported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;cluster&quot;:&quot;xxxxx&quot;,&quot;namespace&quot;:&quot;xxxxx&quot;,&quot;service&quot;:&quot;xxxxx&quot;}]</para>
            /// </summary>
            [NameInMap("FailedService")]
            [Validation(Required=false)]
            public string FailedService { get; set; }

            /// <summary>
            /// <para>The workflow name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myWorkflow</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The domain name rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// <para>The protocol types supported by the domain name. Valid values: HTTP (supports only the HTTP protocol), HTTPS (supports only the HTTPS protocol), and HTTP,HTTPS (supports both HTTP and HTTPS protocols).</para>
            /// 
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The worker ID of the deployment task. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2712224.html">ListWorkerResource</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("WorkerId")]
            [Validation(Required=false)]
            public long? WorkerId { get; set; }

            /// <summary>
            /// <para>The executor type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s_service</para>
            /// </summary>
            [NameInMap("WorkerType")]
            [Validation(Required=false)]
            public string WorkerType { get; set; }

            /// <summary>
            /// <para>The list of specified machines in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;cluster&quot;:&quot;xxxxx&quot;,&quot;namespace&quot;:&quot;xxxxx&quot;,&quot;service&quot;:&quot;xxxxx&quot;}]</para>
            /// </summary>
            [NameInMap("Workers")]
            [Validation(Required=false)]
            public string Workers { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter format error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5EF879D0-3B43-5AD1-9BF7-52418F9C5E73</para>
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
