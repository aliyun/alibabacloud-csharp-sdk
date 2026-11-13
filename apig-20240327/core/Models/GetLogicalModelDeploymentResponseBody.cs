// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetLogicalModelDeploymentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetLogicalModelDeploymentResponseBodyData Data { get; set; }
        public class GetLogicalModelDeploymentResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>vm-d00000000000000000000</para>
            /// </summary>
            [NameInMap("logicalModelId")]
            [Validation(Required=false)]
            public string LogicalModelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>op-d00000000000000000000</para>
            /// </summary>
            [NameInMap("operationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("revision")]
            [Validation(Required=false)]
            public long? Revision { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("targets")]
            [Validation(Required=false)]
            public List<GetLogicalModelDeploymentResponseBodyDataTargets> Targets { get; set; }
            public class GetLogicalModelDeploymentResponseBodyDataTargets : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>7e4f52a9b0c34d16a268e913f5c2087b</para>
                /// </summary>
                [NameInMap("configRevision")]
                [Validation(Required=false)]
                public string ConfigRevision { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>env-d00000000000000000000</para>
                /// </summary>
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>目标模型配置不可用。</para>
                /// </summary>
                [NameInMap("error")]
                [Validation(Required=false)]
                public string Error { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>api-d00000000000000000000</para>
                /// </summary>
                [NameInMap("httpApiId")]
                [Validation(Required=false)]
                public string HttpApiId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;binding&quot;:&quot;Succeeded&quot;}</para>
                /// </summary>
                [NameInMap("stages")]
                [Validation(Required=false)]
                public Dictionary<string, object> Stages { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Succeeded</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
