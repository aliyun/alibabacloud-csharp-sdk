// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class CreateWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
        /// <para>BB521414-5D38-5E66-AA66-963B2B4200E2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public CreateWorkspaceResponseBodyWorkspace Workspace { get; set; }
        public class CreateWorkspaceResponseBodyWorkspace : TeaModel {
            /// <summary>
            /// <para>API Host。</para>
            /// 
            /// <b>Example:</b>
            /// <para>llm-34o9ts1dai60z5sf.cn-beijing.maas.aliyuncs.com</para>
            /// </summary>
            [NameInMap("apiHost")]
            [Validation(Required=false)]
            public string ApiHost { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1742785623772</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("serviceSite")]
            [Validation(Required=false)]
            public string ServiceSite { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ws-ac3ef438bec22dc5</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("workspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

    }

}
