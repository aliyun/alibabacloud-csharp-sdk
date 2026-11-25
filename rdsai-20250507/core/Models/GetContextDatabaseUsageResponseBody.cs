// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetContextDatabaseUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The query dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Workspace</c>: A single workspace.</description></item>
        /// <item><description><c>Account</c>: All workspaces under the caller account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Workspace</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public string Dimension { get; set; }

        /// <summary>
        /// <para>The end time of the query range passed in the request, exclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The usage list. It returns all seven metering items in a fixed order. If an item has no data within the query range, its usage is 0.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<GetContextDatabaseUsageResponseBodyItems> Items { get; set; }
        public class GetContextDatabaseUsageResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The metering item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KnowledgeBaseRead</para>
            /// </summary>
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            /// <summary>
            /// <para>The usage of the item within the query range. The unit is specified by <c>Unit</c>. The number of calls, tokens, and context evolutions are accumulated over the range. Storage is calculated by averaging the occupancy snapshots of each workspace within the range and rounding to the nearest integer byte. For the account dimension, the average values of all workspaces are summed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

            /// <summary>
            /// <para>The metering unit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Count</c>: The number of calls.</description></item>
            /// <item><description><c>Token</c>: The number of tokens.</description></item>
            /// <item><description><c>MicroCredit</c>: One millionth of a credit.</description></item>
            /// <item><description><c>Byte</c>: Bytes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Count</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The ID of the API request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query range passed in the request, inclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the queried workspace. This field has a value only when <c>Dimension</c> is set to <c>Workspace</c>. It is empty for the account dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-x9z4ctzed9gfu2w</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
