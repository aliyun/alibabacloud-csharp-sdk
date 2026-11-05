// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListPermissionRulesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-example</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The principal ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("principalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <para>The principal name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-user</para>
        /// </summary>
        [NameInMap("principalName")]
        [Validation(Required=false)]
        public string PrincipalName { get; set; }

        /// <summary>
        /// <para>The principal type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("principalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-1234567890</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AGENT</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The rule source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgentCore</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The target of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-1234567890</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
