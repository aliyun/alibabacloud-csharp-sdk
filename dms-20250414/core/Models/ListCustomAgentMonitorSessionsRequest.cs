// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListCustomAgentMonitorSessionsRequest : TeaModel {
        /// <summary>
        /// <para>The custom agent ID.</para>
        /// <list type="bullet">
        /// <item><description>Required only when QueryType is set to CustomAgent.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ca-4y3ca4khkcu**********ysf</para>
        /// </summary>
        [NameInMap("CustomAgentId")]
        [Validation(Required=false)]
        public string CustomAgentId { get; set; }

        /// <summary>
        /// <para>The end time for statistics (epoch millis).</para>
        /// <list type="bullet">
        /// <item><description>Note: The maximum time range is 3 months.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1756742400000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 200. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query scope. Default value: All. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Default: default DataAgent sessions.</description></item>
        /// <item><description>CustomAgent: specified custom agent sessions.</description></item>
        /// <item><description>All: all sessions in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The start time for statistics (epoch millis).</para>
        /// <list type="bullet">
        /// <item><description>Note: The maximum time range is 3 months.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1756656000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>56kv1pvl9uvt9**********bb</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
