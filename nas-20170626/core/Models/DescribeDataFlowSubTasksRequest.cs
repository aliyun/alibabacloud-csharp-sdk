// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowSubTasksRequest : TeaModel {
        /// <summary>
        /// <para>The file system ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-370lx1ev9ss27o0****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The filter keys for querying data flow streaming tasks.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeDataFlowSubTasksRequestFilters> Filters { get; set; }
        public class DescribeDataFlowSubTasksRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter key.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DataFlowIds: filters by data flow ID.</description></item>
            /// <item><description>DataFlowTaskIds: filters by data flow task ID.</description></item>
            /// <item><description>DataFlowSubTaskIds: filters by data flow streaming task ID.</description></item>
            /// <item><description>Status: filters by data flow status.</description></item>
            /// <item><description>SrcFilePath: filters by source file path.</description></item>
            /// <item><description>DstFilePath: filters by destination file path.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DataFlowSubTaskIds</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter key. Wildcards are not supported for this parameter.</para>
            /// <list type="bullet">
            /// <item><description>If Key is set to DataFlowIds, Value is set to a data flow ID or part of a data flow ID. You can specify one or more data flow IDs. A maximum of 10 data flow IDs can be specified. Example: <c>df-194433a5be31****</c> or <c>df-194433a512a2****,df-234533a5be31****</c>.</description></item>
            /// <item><description>If Key is set to DataFlowTaskIds, Value is set to a data flow task ID or part of a data flow task ID. You can specify one or more data flow task IDs. A maximum of 10 data flow task IDs can be specified. Example: <c>task-29ee8e890f45****</c> or <c>task-29ee8e890f45****,task-38ae8e890f45****</c>.</description></item>
            /// <item><description>If Key is set to DataFlowSubTaskIds, Value is set to a data flow streaming task ID or part of a data flow streaming task ID. You can specify one or more data flow streaming task IDs. A maximum of 10 data flow streaming task IDs can be specified. Example: <c>subTaskId-370kyfmyknxcyzw****</c> or <c>subTaskId-247kyfmyknxcyzw****,subTaskId-256kyfmyknxcyzw****</c>.</description></item>
            /// <item><description>If Key is set to Status, Value is set to the status of the data flow task, including EXPIRED, CREATED, RUNNING, COMPLETE, CANCELING, FAILED, and CANCELED. Combined queries are supported.</description></item>
            /// <item><description>If Key is set to SrcFilePath, Value is set to the source file path. The maximum length is 1023 characters.</description></item>
            /// <item><description>If Key is set to DstFilePath, Value is set to the destination file path. The maximum length is 1023 characters.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>subTaskId-370kyfmyknxcyzw****</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results per query.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values: 20 to 100.</para>
        /// </description></item>
        /// <item><description><para>Default value: 20.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>If the returned results are truncated, you can use NextToken to initiate a new request to retrieve the content after the current truncation point.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iWk0AQAAAAAvY2FzZS8=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
