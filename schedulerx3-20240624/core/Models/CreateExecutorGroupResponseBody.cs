// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class CreateExecutorGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateExecutorGroupResponseBodyData Data { get; set; }
        public class CreateExecutorGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>md5_spell</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my first workflow</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;cluster&quot;:&quot;xxxxx&quot;,&quot;namespace&quot;:&quot;xxxxx&quot;,&quot;service&quot;:&quot;xxxxx&quot;}]</para>
            /// </summary>
            [NameInMap("FailedService")]
            [Validation(Required=false)]
            public string FailedService { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>myWorkflow</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

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
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
