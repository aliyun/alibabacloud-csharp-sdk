// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class RetryLogicalModelDeploymentResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. Ok is returned for a successful request, and a specific business error code is returned for a failed request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business result returned by the logical model operation.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public RetryLogicalModelDeploymentResponseBodyData Data { get; set; }
        public class RetryLogicalModelDeploymentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The logical model ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vm-d00000000000000000000</para>
            /// </summary>
            [NameInMap("logicalModelId")]
            [Validation(Required=false)]
            public string LogicalModelId { get; set; }

            /// <summary>
            /// <para>The persistent delivery ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>op-d00000000000000000000</para>
            /// </summary>
            [NameInMap("operationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// <para>The configuration version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("revision")]
            [Validation(Required=false)]
            public long? Revision { get; set; }

            /// <summary>
            /// <para>The current processing status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The configuration targets and stage results.</para>
            /// </summary>
            [NameInMap("targets")]
            [Validation(Required=false)]
            public List<RetryLogicalModelDeploymentResponseBodyDataTargets> Targets { get; set; }
            public class RetryLogicalModelDeploymentResponseBodyDataTargets : TeaModel {
                /// <summary>
                /// <para>The semantic version of the target configuration. It is used only for delivery recovery and does not record the API release time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7e4f52a9b0c34d16a268e913f5c2087b</para>
                /// </summary>
                [NameInMap("configRevision")]
                [Validation(Required=false)]
                public string ConfigRevision { get; set; }

                /// <summary>
                /// <para>The related configuration environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env-d00000000000000000000</para>
                /// </summary>
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// <para>The configuration error summary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The target model configuration is unavailable</para>
                /// </summary>
                [NameInMap("error")]
                [Validation(Required=false)]
                public string Error { get; set; }

                /// <summary>
                /// <para>The related API configuration target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-d00000000000000000000</para>
                /// </summary>
                [NameInMap("httpApiId")]
                [Validation(Required=false)]
                public string HttpApiId { get; set; }

                /// <summary>
                /// <para>The plugin stage results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;binding&quot;:&quot;Succeeded&quot;}</para>
                /// </summary>
                [NameInMap("stages")]
                [Validation(Required=false)]
                public Dictionary<string, object> Stages { get; set; }

                /// <summary>
                /// <para>The status of the configuration target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Succeeded</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message that describes the request processing result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID generated by the system to trace the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
