// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class CreateExecutorsResponseBody : TeaModel {
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
        public CreateExecutorsResponseBodyData Data { get; set; }
        public class CreateExecutorsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The App Group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-app</para>
            /// </summary>
            [NameInMap("AppGroupId")]
            [Validation(Required=false)]
            public long? AppGroupId { get; set; }

            /// <summary>
            /// <para>The application type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public int? AppType { get; set; }

            /// <summary>
            /// <para>A list of Kubernetes Services that failed to import.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;cluster&quot;:&quot;xxxxx&quot;,&quot;namespace&quot;:&quot;xxxxx&quot;,&quot;service&quot;:&quot;xxxxx&quot;}]</para>
            /// </summary>
            [NameInMap("FailedService")]
            [Validation(Required=false)]
            public string FailedService { get; set; }

            /// <summary>
            /// <para>The ID of the worker. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2712224.html">ListWorkerResource</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ins-95mfvqrtg6fkijt1uko000</para>
            /// </summary>
            [NameInMap("WorkerId")]
            [Validation(Required=false)]
            public long? WorkerId { get; set; }

            /// <summary>
            /// <para>The worker type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s_service</para>
            /// </summary>
            [NameInMap("WorkerType")]
            [Validation(Required=false)]
            public string WorkerType { get; set; }

            /// <summary>
            /// <para>A JSON string that represents the list of imported workers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;cluster&quot;:&quot;xxxxx&quot;,&quot;namespace&quot;:&quot;xxxxx&quot;,&quot;service&quot;:&quot;xxxxx&quot;}]</para>
            /// </summary>
            [NameInMap("Workers")]
            [Validation(Required=false)]
            public string Workers { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter error: content is null.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F131C3E0-3FAA-5FA4-A6F3-E974D69EF3C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
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
