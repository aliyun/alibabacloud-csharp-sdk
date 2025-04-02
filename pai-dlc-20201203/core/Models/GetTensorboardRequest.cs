// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetTensorboardRequest : TeaModel {
        /// <summary>
        /// <para>The job ID. For more information about how to query the job ID, see <a href="https://help.aliyun.com/document_detail/459676.html">ListJob</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-xxxxxxxx</para>
        /// </summary>
        [NameInMap("JodId")]
        [Validation(Required=false)]
        public string JodId { get; set; }

        /// <summary>
        /// <para>The information about the shared token. You can specify this parameter to obtain the permission to view a TensorBoard job based on the shared token information. You can execute <a href="https://help.aliyun.com/document_detail/2557813.html">GetTensorboardSharedUrl</a> and extract the shared token from the obtained information.</para>
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
        /// <para>The workspace ID. 
        /// &lt;props=&quot;china&quot;&gt;For more information about how to query the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46099</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
