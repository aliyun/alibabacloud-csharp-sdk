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
        /// <item><description><para>General-purpose CPFS: must start with <c>cpfs-</c>, for example, cpfs-099394bd928c****.</para>
        /// </description></item>
        /// <item><description><para>CPFS for Lingjun: must start with <c>bmcpfs-</c>, for example, bmcpfs-290w65p03ok64ya****.</para>
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
        /// <para>The collection of filter keys.</para>
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
            /// <item><description>DataFlowIds: Filters by data flow ID.</description></item>
            /// <item><description>TaskIds: Filters by data flow task ID.</description></item>
            /// <item><description>Originator: Filters by the originator of the data flow task.</description></item>
            /// <item><description>TaskActions: Filters by the type of the data flow task.</description></item>
            /// <item><description>DataTypes: Filters by the data type of the data flow task.</description></item>
            /// <item><description>Status: Filters by the data flow status.</description></item>
            /// <item><description>CreateTimeBegin: Filters data flow tasks created after a specified time.</description></item>
            /// <item><description>CreateTimeEnd: Filters data flow tasks created before a specified time.</description></item>
            /// <item><description>StartTimeBegin: Filters data flow tasks started after a specified time.</description></item>
            /// <item><description>StartTimeEnd: Filters data flow tasks started before a specified time.</description></item>
            /// <item><description>EndTimeBegin: Filters data flow tasks ended after a specified time.</description></item>
            /// <item><description>EndTimeEnd: Filters data flow tasks ended before a specified time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DataFlowIds</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter key. This parameter does not support wildcards.</para>
            /// <list type="bullet">
            /// <item><description>When Key is set to DataFlowIds, Value is set to the data flow ID or a part of the data flow ID. It can be a single DataFlowId or a list of DataFlowIds. You can specify up to 10 data flow IDs. Example: <c>df-194433a5be31****</c> or <c>df-194433a512a2****,df-234533a5be31****</c>.</description></item>
            /// <item><description>When Key is set to TaskIds, Value is set to the data flow task ID or a part of the data flow task ID. It can be a single task ID or a list of task IDs. You can specify up to 10 data flow task IDs. Example: <c>task-38aa8e890f45****</c> or <c>task-38aa8e890f45****,task-29ae8e890f45****</c>.</description></item>
            /// <item><description>When Key is set to TaskActions, Value is set to the task type of the data flow. Valid values: <b>Import</b>, <b>Export</b>, <b>Evict</b>, <b>Inventory</b>, <b>StreamImport</b>, and <b>StreamExport</b>. Combined queries are supported. Currently, CPFS for Lingjun only supports Import, Export, StreamImport, and StreamExport. StreamImport and StreamExport are supported only in CPFS for Lingjun 2.6.0 and later.</description></item>
            /// <item><description>When Key is set to DataTypes, Value is set to the data type of the data flow task. Valid values: MetaAndData, Metadata, and Data. Combined queries are supported.</description></item>
            /// <item><description>When Key is set to Originator, Value is set to the originator of the data flow task. Valid values: User and System.</description></item>
            /// <item><description>When Key is set to Status, Value is set to the status of the data flow task. Valid values: Pending, Executing, Failed, Completed, Canceling, and Canceled. Combined queries are supported.</description></item>
            /// <item><description>When Key is set to CreateTimeBegin, Value is set to the minimum creation time of the data flow task. Format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// <item><description>When Key is set to CreateTimeEnd, Value is set to the maximum creation time of the data flow task. Format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// <item><description>When Key is set to StartTimeBegin, Value is set to the minimum start time of the data flow task. Format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// <item><description>When Key is set to StartTimeEnd, Value is set to the maximum start time of the data flow task. Format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// <item><description>When Key is set to EndTimeBegin, Value is set to the minimum end time of the data flow task. Format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// <item><description>When Key is set to EndTimeEnd, Value is set to the maximum end time of the data flow task. Format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
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
        /// <para>The maximum number of entries to return for a single request.</para>
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
        /// <para>The next token. If the returned results of a request are truncated, you can use NextToken to initiate another request and obtain the remaining results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to query report information.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>True: Queries reports. This is the default value.</description></item>
        /// <item><description>False: Does not query reports.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Setting this parameter to false can accelerate the query speed.</description></item>
        /// <item><description>Only CPFS for Lingjun supports this parameter.</description></item>
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
