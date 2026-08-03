// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowTasksRequest : TeaModel {
        /// <summary>
        /// <para>The file system ID.</para>
        /// <list type="bullet">
        /// <item><description><para>General-purpose CPFS: must start with <c>cpfs-</c>, such as cpfs-099394bd928c****.</para>
        /// </description></item>
        /// <item><description><para>CPFS for Lingjun: must start with <c>bmcpfs-</c>, such as bmcpfs-290w65p03ok64ya****.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-290w65p03ok64ya****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeDataFlowTasksRequestFilters> Filters { get; set; }
        public class DescribeDataFlowTasksRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter key.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DataFlowIds: filters by data flow ID.</description></item>
            /// <item><description>TaskIds: filters by data flow task ID.</description></item>
            /// <item><description>Originator: filters by the initiator of the data flow task.</description></item>
            /// <item><description>TaskActions: filters by the type of the data flow task.</description></item>
            /// <item><description>DataTypes: filters by the data type of the data flow task.</description></item>
            /// <item><description>Status: filters by data flow status.</description></item>
            /// <item><description>CreateTimeBegin: filters data flow tasks created after the specified time.</description></item>
            /// <item><description>CreateTimeEnd: filters data flow tasks created before the specified time.</description></item>
            /// <item><description>StartTimeBegin: filters data flow tasks started after the specified time.</description></item>
            /// <item><description>StartTimeEnd: filters data flow tasks started before the specified time.</description></item>
            /// <item><description>EndTimeBegin: filters data flow tasks ended after the specified time.</description></item>
            /// <item><description>EndTimeEnd: filters data flow tasks ended before the specified time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DataFlowIds</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter key. Wildcards are not supported.</para>
            /// <list type="bullet">
            /// <item><description>If Key is set to DataFlowIds, Value is set to a data flow ID or part of a data flow ID. You can specify one or more data flow IDs. A maximum of 10 data flow IDs can be specified. Example: <c>df-194433a5be31****</c> or <c>df-194433a512a2****,df-234533a5be31****</c>.</description></item>
            /// <item><description>If Key is set to TaskId, Value is set to a data flow task ID or part of a data flow task ID. You can specify one or more data flow task IDs. A maximum of 10 data flow task IDs can be specified. Example: <c>task-38aa8e890f45****</c> or <c>task-38aa8e890f45****,task-29ae8e890f45****</c>.</description></item>
            /// <item><description>If Key is set to TaskActions, Value is set to the type of the data flow task, including <b>Import</b>, <b>Export</b>, <b>Evict</b>, <b>Inventory</b>, <b>StreamImport</b>, and <b>StreamExport</b>. Combined queries are supported. CPFS for Lingjun supports only Import, Export, StreamImport, and StreamExport. StreamImport and StreamExport are supported only by CPFS for Lingjun 2.6.0 and later.</description></item>
            /// <item><description>If Key is set to DataTypes, Value is set to the data type of the data flow task, including MetaAndData, Metadata, and Data. Combined queries are supported.</description></item>
            /// <item><description>If Key is set to Originator, Value is set to the initiator of the data flow task, including User and System.</description></item>
            /// <item><description>If Key is set to Status, Value is set to the status of the data flow task, including Pending, Executing, Failed, Completed, Canceling, and Canceled. Combined queries are supported.</description></item>
            /// <item><description>If Key is set to CreateTimeBegin, Value is set to the earliest creation time of data flow tasks. Format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// <item><description>If Key is set to CreateTimeEnd, Value is set to the latest creation time of data flow tasks. Format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// <item><description>If Key is set to StartTimeBegin, Value is set to the earliest start time of data flow tasks. Format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// <item><description>If Key is set to StartTimeEnd, Value is set to the latest start time of data flow tasks. Format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// <item><description>If Key is set to EndTimeBegin, Value is set to the earliest end time of data flow tasks. Format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// <item><description>If Key is set to EndTimeEnd, Value is set to the latest end time of data flow tasks. Format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>df-194433a5be31****</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of results for each query.</para>
        /// <para>Valid values: 10 to 100.</para>
        /// <para>Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If the return results are truncated, you can use NextToken to initiate a new request to retrieve the content after the truncation point.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to query report information.</para>
        /// <list type="bullet">
        /// <item><description>True (default): queries reports.</description></item>
        /// <item><description>False: does not query reports.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Setting this parameter to False can speed up queries.</description></item>
        /// <item><description>Only CPFS for Lingjun is supported.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("WithReports")]
        [Validation(Required=false)]
        public bool? WithReports { get; set; }

    }

}
