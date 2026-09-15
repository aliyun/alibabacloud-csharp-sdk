// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListSandboxesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of records per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. When paginating, keep workspaceId, agentId, searchText, sessionId, and maxResults unchanged.</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>When explicitly specified, this parameter cannot be empty or consist entirely of whitespace. The value can contain up to 36 characters and allows only hexadecimal characters and hyphens. This parameter can be used together with sessionId, combined with AND logic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2f360</para>
        /// </summary>
        [NameInMap("searchText")]
        [Validation(Required=false)]
        public string SearchText { get; set; }

        /// <summary>
        /// <para>When explicitly specified, this parameter cannot be empty or consist entirely of whitespace. The value must be valid UTF-8 of 1 to 128 bytes and cannot contain forward slashes (/), vertical bars (|), control characters, or format characters. The original case and leading/trailing spaces are preserved. This parameter can be used together with searchText, combined with AND logic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session-a</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
