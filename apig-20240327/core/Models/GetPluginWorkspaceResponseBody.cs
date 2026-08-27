// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetPluginWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPluginWorkspaceResponseBodyData Data { get; set; }
        public class GetPluginWorkspaceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>664f1e2xxxx</para>
            /// </summary>
            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>987654</para>
            /// </summary>
            [NameInMap("pipelineRunId")]
            [Validation(Required=false)]
            public string PipelineRunId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345678</para>
            /// </summary>
            [NameInMap("repoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-custom-plugin</para>
            /// </summary>
            [NameInMap("repoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://apigw-console-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/%7Buid%7D/plugin/plugin_1756262400.wasm">https://apigw-console-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/{uid}/plugin/plugin_1756262400.wasm</a></para>
            /// </summary>
            [NameInMap("wasmUrl")]
            [Validation(Required=false)]
            public string WasmUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>plw-xxxxxxxx</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4AFA893B-A75B-5002-AACF-84CABE06197A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
