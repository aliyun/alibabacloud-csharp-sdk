// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateEnvPodMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned result, which indicates whether the operation was successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateEnvPodMonitorResponseBodyData Data { get; set; }
        public class CreateEnvPodMonitorResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether targets are matched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Match successful.</para>
            /// </summary>
            [NameInMap("MatchedMsg")]
            [Validation(Required=false)]
            public string MatchedMsg { get; set; }

            /// <summary>
            /// <para>The number of matched targets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MatchedTargetCount")]
            [Validation(Required=false)]
            public string MatchedTargetCount { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arms-prom</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The name of the created PodMonitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arms-admin-pm1</para>
            /// </summary>
            [NameInMap("PodMonitorName")]
            [Validation(Required=false)]
            public string PodMonitorName { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78901766-3806-4E96-8E47-CFEF59E4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
