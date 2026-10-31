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
            /// <para>The check result of the commit details. The value is a JSON character string and is returned only for asynchronous commit links. The structure is consistent with the commit details on the product page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;success&quot;:true}</para>
            /// </summary>
            [NameInMap("CheckDetail")]
            [Validation(Required=false)]
            public string CheckDetail { get; set; }

            /// <summary>
            /// <para>The error code returned when an execution exception occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DPN.Pipeline.InnerError</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned when an execution exception occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NullPointException</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The server host information for request execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hostName:hostIp</para>
            /// </summary>
            [NameInMap("HostMachine")]
            [Validation(Required=false)]
            public string HostMachine { get; set; }

            /// <summary>
            /// <para>The ID of the scheduling node for the pipeline task.</para>
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
            /// <para>The current execution status. Valid values: SUCCESS: The execution is successful. FAILED: The execution fails. RUNNING: The execution is in progress.</para>
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
            /// <para>The version number generated after the pipeline task is submitted.</para>
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
        /// <para>The details of the backend response exception.</para>
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
