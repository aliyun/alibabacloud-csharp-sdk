// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class UpdateExecutorGroupResponseBody : TeaModel {
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
        /// <para>The updated executor group information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateExecutorGroupResponseBodyData Data { get; set; }
        public class UpdateExecutorGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The authentication type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Anonymous</b>: No authentication is required.</description></item>
            /// <item><description><b>Application</b>: Authentication is required.<remarks>
            /// <para>The default value is <b>Anonymous</b>.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EDIT</para>
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
            /// <para>The network data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;OfficeSiteId\&quot;:\&quot;cn-hangzhou+dir-8801187585\&quot;,\&quot;VSwitchIds\&quot;:[null]}</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// <para>The protocol types supported by the domain name. HTTP: Only the HTTP protocol is supported. HTTPS: Only the HTTPS protocol is supported. HTTP,HTTPS: Both HTTP and HTTPS protocols are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
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
        /// <para>Parameter check error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C78E2AD2-5985-515B-BAD2-31A248AFC263</para>
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
