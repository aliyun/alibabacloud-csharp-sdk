// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetContextDatabaseUsageRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query range, exclusive. It must be later than <c>StartTime</c>. Use the ISO 8601 time format, such as <c>2026-08-01T00:00:00Z</c> (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The start time of the query range, inclusive. Use the ISO 8601 time format, such as <c>2026-07-01T00:00:00Z</c> (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to query. If specified, only the data of this workspace under the caller account is queried. Locked workspaces can also be queried. If omitted, all workspaces under the caller account are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-x9z4ctzed9gfu2w</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
