// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreatePluginWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreatePluginWorkspaceResponseBodyData Data { get; set; }
        public class CreatePluginWorkspaceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12345678</para>
            /// </summary>
            [NameInMap("repoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

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
        /// <para>01A02219-8028-57D8-9D60-2D167FF9118E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
