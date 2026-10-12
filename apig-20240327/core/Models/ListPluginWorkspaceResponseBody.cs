// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPluginWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListPluginWorkspaceResponseBodyData> Data { get; set; }
        public class ListPluginWorkspaceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Codeup organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>664f1e2xxxx</para>
            /// </summary>
            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <para>The Codeup repository ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678</para>
            /// </summary>
            [NameInMap("repoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The repository name (the English ID of the plugin).</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-custom-plugin</para>
            /// </summary>
            [NameInMap("repoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The workspace ID (prefixed with plw-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>plw-xxxxxxxx</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B690F39C-1BDA-55E0-9E94-5358E758C772</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
