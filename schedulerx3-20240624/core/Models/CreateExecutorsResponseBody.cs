// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class CreateExecutorsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateExecutorsResponseBodyData Data { get; set; }
        public class CreateExecutorsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test-app</para>
            /// </summary>
            [NameInMap("AppGroupId")]
            [Validation(Required=false)]
            public long? AppGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public int? AppType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;cluster&quot;:&quot;xxxxx&quot;,&quot;namespace&quot;:&quot;xxxxx&quot;,&quot;service&quot;:&quot;xxxxx&quot;}]</para>
            /// </summary>
            [NameInMap("FailedService")]
            [Validation(Required=false)]
            public string FailedService { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ins-95mfvqrtg6fkijt1uko000</para>
            /// </summary>
            [NameInMap("WorkerId")]
            [Validation(Required=false)]
            public long? WorkerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>k8s_service</para>
            /// </summary>
            [NameInMap("WorkerType")]
            [Validation(Required=false)]
            public string WorkerType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;cluster&quot;:&quot;xxxxx&quot;,&quot;namespace&quot;:&quot;xxxxx&quot;,&quot;service&quot;:&quot;xxxxx&quot;}]</para>
            /// </summary>
            [NameInMap("Workers")]
            [Validation(Required=false)]
            public string Workers { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Parameter error: content is null.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F131C3E0-3FAA-5FA4-A6F3-E974D69EF3C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
