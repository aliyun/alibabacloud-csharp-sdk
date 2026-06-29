// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdatePipelineResponseBody : TeaModel {
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
        /// <para>The update result of the pipeline or workflow node.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdatePipelineResponseBodyData Data { get; set; }
        public class UpdatePipelineResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name and IP address of the server that executed the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hostName:hostIp</para>
            /// </summary>
            [NameInMap("HostMachine")]
            [Validation(Required=false)]
            public string HostMachine { get; set; }

            /// <summary>
            /// <para>The scheduling node ID of the pipeline or workflow node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The pipeline or workflow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public long? PipelineId { get; set; }

            /// <summary>
            /// <para>The submit ID generated upon successful submission of the pipeline or workflow, which is added to the pending publish list and can be published through the publish domain. This value is not returned for workflow nodes because they only support PROD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("SubmitId")]
            [Validation(Required=false)]
            public long? SubmitId { get; set; }

            /// <summary>
            /// <para>The version number pending publish. This value is not returned for workflow nodes because they only support PROD.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
