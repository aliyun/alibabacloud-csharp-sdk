// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetTensorboardRequest : TeaModel {
        /// <summary>
        /// <para>The job ID. Refer to <a href="https://help.aliyun.com/document_detail/459676.html">ListJobs</a> to obtain the job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-xxxxxxxx</para>
        /// </summary>
        [NameInMap("JodId")]
        [Validation(Required=false)]
        public string JodId { get; set; }

        /// <summary>
        /// <para>The sharing token. Specify this parameter to use the sharing token to obtain the permission to view a specific Tensorboard job. You can extract the token from the URL returned by calling <a href="https://help.aliyun.com/document_detail/2557813.html">GetTensorboardSharedUrl</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.e
        /// yJleHAiOjE2OTUyODA0NTMsImlhdCI6MTY5NTE5NDA1MywidXNlcl9pZCI6IjExN
        /// Tc3MDMyNzA5OTQ5MDEiLCJ0YXJnZXRfaWQiOiJ0YjRrOGxjNXhmdTM2b3B0Iiw
        /// idGFyZ2V0X3R5cGUiOiJ0ZW5zb3Jib2FyZCJ9.6eT68J-KMBwwfN2d7fj7u6vyPcf0erfqYeizd2N****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The workspace ID. &lt;props=&quot;china&quot;&gt;Refer to <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID..</para>
        /// 
        /// <b>Example:</b>
        /// <para>46099</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
