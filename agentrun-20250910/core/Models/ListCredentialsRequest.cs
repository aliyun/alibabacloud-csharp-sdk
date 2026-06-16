// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListCredentialsRequest : TeaModel {
        /// <summary>
        /// <para>Filters the results by credential type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credentialAuthType</para>
        /// </summary>
        [NameInMap("credentialAuthType")]
        [Validation(Required=false)]
        public string CredentialAuthType { get; set; }

        /// <summary>
        /// <para>Filters the results by credential name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credentialName</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        /// <summary>
        /// <para>Filters the results by credential source type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credentialSourceType</para>
        /// </summary>
        [NameInMap("credentialSourceType")]
        [Validation(Required=false)]
        public string CredentialSourceType { get; set; }

        /// <summary>
        /// <para>Filters the results based on the credential\&quot;s enabled status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The page number of the results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of credentials to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters the results by provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>Unique identifier of the workspace</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-1</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>Multiple workspace identifiers</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-1,ws-2</para>
        /// </summary>
        [NameInMap("workspaceIds")]
        [Validation(Required=false)]
        public string WorkspaceIds { get; set; }

    }

}
