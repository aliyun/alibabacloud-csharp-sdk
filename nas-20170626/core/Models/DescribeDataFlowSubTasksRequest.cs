// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowSubTasksRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-370lx1ev9ss27o0****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The filter that is used to query data streaming tasks.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeDataFlowSubTasksRequestFilters> Filters { get; set; }
        public class DescribeDataFlowSubTasksRequestFilters : TeaModel {
            /// <summary>
            /// <para>The filter name.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DataFlowIds: filters data flow subtasks by data flow ID.</description></item>
            /// <item><description>DataFlowTaskIds: filters data flow subtasks by data flow task ID.</description></item>
            /// <item><description>DataFlowSubTaskIds: filters data flow subtasks by data streaming task ID.</description></item>
            /// <item><description>Status: filters data flow subtasks by status.</description></item>
            /// <item><description>SrcFilePath: filters data flow subtasks by source file path.</description></item>
            /// <item><description>DstFilePath: filters data flow subtasks by destination file path.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DataFlowSubTaskIds</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value. This parameter does not support wildcards.</para>
            /// <list type="bullet">
            /// <item><description>If Key is set to DataFlowIds, set Value to a data flow ID or a part of the data flow ID. You can specify a data flow ID or a group of data flow IDs. You can specify a maximum of 10 data flow IDs. Example: <c>df-194433a5be31****</c> or <c>df-194433a5be31****,df-244433a5be31****</c>.</description></item>
            /// <item><description>If Key is set to DataFlowTaskIds, set Value to a data flow task ID or a part of the data flow task ID. You can specify a data flow task ID or a group of data flow task IDs. You can specify a maximum of 10 data flow task IDs. Example:  <c>task-38aa8e890f45****</c> or <c>task-38aa8e890f45****,task-27aa8e890f45****</c>.</description></item>
            /// <item><description>If Key is set to DataFlowSubTaskIds, set Value to a data streaming task ID or a part of the data streaming task ID. You can specify a data streaming task ID or a group of data streaming task IDs. You can specify a maximum of 10 data streaming task IDs. Example: <c>subTaskId-370kyfmyknxcyzw**** </c>or <c>subTaskId-370kyfmyknxcyzw****,subTaskId-280kyfmyknxcyzw****</c>.</description></item>
            /// <item><description>If Key is set to Status, set Value to the status of the data flow task. The status can be EXPIRED, CREATED, RUNNING, COMPLETE, CANCELING, FAILED, or CANCELED. Combined query is supported.</description></item>
            /// <item><description>If Key is set to SrcFilePath, set Value to the path of the source file. The path can be up to 1,023 characters in length.</description></item>
            /// <item><description>If Key is set to DstFilePath, set Value to the path of the destination file. The path can be up to 1,023 characters in length.</description></item>
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
        /// <para>The number of results for each query.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 20 to 100.</description></item>
        /// <item><description>Default value: 20.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iWk0AQAAAAAvY2FzZS8=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
