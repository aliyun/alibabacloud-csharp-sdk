// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListMemoriesRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID. If not specified, all agents are matched. The length is limited to 1 to 128 UTF-8 bytes. The value cannot contain a forward slash (/) or an asterisk (*).</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-001</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The maximum number of records per page. Default value: 50. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjEwfQ==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The session ID. If not specified, all sessions are matched. The length is limited to 1 to 128 UTF-8 bytes. The value cannot contain a forward slash (/) or an asterisk (*).</para>
        /// 
        /// <b>Example:</b>
        /// <para>session-001</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The source of the memory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>session_extraction: Extracted from session events.</description></item>
        /// <item><description>content_extraction: Extracted from text or messages.</description></item>
        /// <item><description>direct: Written directly.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>session_extraction</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The business team ID defined by the caller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>team-001</para>
        /// </summary>
        [NameInMap("teamId")]
        [Validation(Required=false)]
        public string TeamId { get; set; }

        /// <summary>
        /// <para>The memory content types. Specify the value as a JSON array string, such as [&quot;skill&quot;]. Valid values: semantic, skill, user_profile, and session_summary. If this parameter is omitted or set to [], all types are queried. The value auto is not supported. Keep the filter conditions consistent when you retrieve subsequent pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;semantic&quot;]</para>
        /// </summary>
        [NameInMap("types")]
        [Validation(Required=false)]
        public string Types { get; set; }

        /// <summary>
        /// <para>The start time for filtering by update time. The time must be in RFC 3339 format with a time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-23T10:00:00Z</para>
        /// </summary>
        [NameInMap("updatedAtFrom")]
        [Validation(Required=false)]
        public string UpdatedAtFrom { get; set; }

        /// <summary>
        /// <para>The end time for filtering by update time. The time must be in RFC 3339 format with a time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-24T10:00:00Z</para>
        /// </summary>
        [NameInMap("updatedAtTo")]
        [Validation(Required=false)]
        public string UpdatedAtTo { get; set; }

        /// <summary>
        /// <para>The user ID. If not specified, all users are matched. The length is limited to 1 to 128 UTF-8 bytes. The value cannot contain a forward slash (/) or an asterisk (*).</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-001</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>Specifies whether the memory is valid. Default value: true. If this parameter is omitted, only valid records are returned. If set to false, revoked records are returned.</para>
        /// </summary>
        [NameInMap("valid")]
        [Validation(Required=false)]
        public bool? Valid { get; set; }

    }

}
