// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetPipelineAsyncResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The asynchronous execution result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPipelineAsyncResultResponseBodyData Data { get; set; }
        public class GetPipelineAsyncResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The asynchronous execution query ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("AsyncId")]
            [Validation(Required=false)]
            public long? AsyncId { get; set; }

            /// <summary>
            /// <para>The error code returned when the execution fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DPN.Pipeline.InnerError</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned when the execution fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NullPointException</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The information about the server host that processes the execution request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hostName:hostIp</para>
            /// </summary>
            [NameInMap("HostMachine")]
            [Validation(Required=false)]
            public string HostMachine { get; set; }

            /// <summary>
            /// <para>The scheduling node ID of the pipeline task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_123</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The primary key ID of the pipeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public long? PipelineId { get; set; }

            /// <summary>
            /// <para>The current execution status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SUCCESS: execution succeeded.</description></item>
            /// <item><description>FAILED: execution failed.</description></item>
            /// <item><description>RUNNING: execution in progress.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The publish ID generated after the pipeline task is submitted. You can use this ID to publish the task through the publish domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("SubmitId")]
            [Validation(Required=false)]
            public long? SubmitId { get; set; }

            /// <summary>
            /// <para>The version number generated when the pipeline task is submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error details returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
