// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetCustomAgentImagePreparationResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The preparation query result. Refer to the phase for the asynchronous execution status.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetCustomAgentImagePreparationResponseBodyData Data { get; set; }
        public class GetCustomAgentImagePreparationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The target agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-example</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The error information. This field is returned only when the task fails. Otherwise, the value is null.</para>
            /// </summary>
            [NameInMap("error")]
            [Validation(Required=false)]
            public GetCustomAgentImagePreparationResponseBodyDataError Error { get; set; }
            public class GetCustomAgentImagePreparationResponseBodyDataError : TeaModel {
                /// <summary>
                /// <para>The business error code for image preparation. This code is used to identify the failure type. For the specific cause, refer to the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ImageSyncFailed</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The specific cause of the failure. This may include underlying errors such as image not found, authentication failure, network timeout, or certificate verification error. Passwords, tokens, or authentication headers are not returned. If the underlying system does not provide a cause, a general description is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tls: failed to verify certificate: x509: certificate signed by unknown authority</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The failed phase. This field is returned only when the status is FAILED. Otherwise, the value is null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COPYING</para>
            /// </summary>
            [NameInMap("failedPhase")]
            [Validation(Required=false)]
            public string FailedPhase { get; set; }

            /// <summary>
            /// <para>The current phase. Only SUCCEEDED indicates that the deployment of the target version is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FAILED</para>
            /// </summary>
            [NameInMap("phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The console submission task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-example:1</para>
            /// </summary>
            [NameInMap("preparationId")]
            [Validation(Required=false)]
            public string PreparationId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426614174000</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
