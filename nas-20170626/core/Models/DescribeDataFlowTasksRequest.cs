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
        /// <item><description><para>CPFS General-purpose: The ID must start with <c>cpfs-</c>, such as cpfs-099394bd928c\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// <item><description><para>CPFS for AI Computing: The ID must start with <c>bmcpfs-</c>, such as bmcpfs-290w65p03ok64ya\<em>\</em>\<em>\</em>.</para>
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
        /// <para>A collection of filters.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeDataFlowTasksRequestFilters> Filters { get; set; }
        public class DescribeDataFlowTasksRequestFilters : TeaModel {
            /// <summary>
            /// <para>The filter key.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>DataFlowIds: Filters by data flow ID.</para>
            /// </description></item>
            /// <item><description><para>TaskIds: Filters by data flow task ID.</para>
            /// </description></item>
            /// <item><description><para>Originator: Filters by originator.</para>
            /// </description></item>
            /// <item><description><para>TaskActions: Filters by data flow task type.</para>
            /// </description></item>
            /// <item><description><para>DataTypes: Filters by data type.</para>
            /// </description></item>
            /// <item><description><para>Status: Filters by status.</para>
            /// </description></item>
            /// <item><description><para>CreateTimeBegin: Filters data flow tasks created after the specified time.</para>
            /// </description></item>
            /// <item><description><para>CreateTimeEnd: Filters data flow tasks created before the specified time.</para>
            /// </description></item>
            /// <item><description><para>StartTimeBegin: Filters data flow tasks that started after the specified time.</para>
            /// </description></item>
            /// <item><description><para>StartTimeEnd: Filters data flow tasks that started before the specified time.</para>
            /// </description></item>
            /// <item><description><para>EndTimeBegin: Filters data flow tasks that ended after the specified time.</para>
            /// </description></item>
            /// <item><description><para>EndTimeEnd: Filters data flow tasks that ended before the specified time.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DataFlowIds</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value. This parameter does not support wildcards.</para>
            /// <list type="bullet">
            /// <item><description><para>When <c>Key</c> is <c>DataFlowIds</c>, specify one or more data flow IDs. You can specify up to 10 data flow IDs, separated by commas. For example, <c>df-194433a5be31****</c> or <c>df-194433a512a2****,df-234533a5be31****</c>.</para>
            /// </description></item>
            /// <item><description><para>When <c>Key</c> is <c>TaskId</c>, specify one or more data flow task IDs. You can specify up to 10 data flow task IDs, separated by commas. For example, <c>task-38aa8e890f45****</c> or <c>task-38aa8e890f45****,task-29ae8e890f45****</c>.</para>
            /// </description></item>
            /// <item><description><para>When <c>Key</c> is <c>TaskActions</c>, specify the data flow task type. Valid values are <b>Import</b>, <b>Export</b>, <b>Evict</b>, <b>Inventory</b>, <b>StreamImport</b>, and <b>StreamExport</b>. You can specify multiple values. CPFS for AI Computing supports only Import, Export, StreamImport, and StreamExport. StreamImport and StreamExport are available only in CPFS for AI Computing 2.6.0 and later.</para>
            /// </description></item>
            /// <item><description><para>When <c>Key</c> is <c>DataTypes</c>, specify the data type of the data flow task. Valid values are MetaAndData, Metadata, and Data. You can specify multiple values.</para>
            /// </description></item>
            /// <item><description><para>When <c>Key</c> is <c>Originator</c>, specify the originator of the data flow task. Valid values are User and System.</para>
            /// </description></item>
            /// <item><description><para>When <c>Key</c> is <c>Status</c>, specify the status of the data flow task. Valid values are Pending, Executing, Failed, Completed, Canceling, and Canceled. You can specify multiple values.</para>
            /// </description></item>
            /// <item><description><para>When <c>Key</c> is <c>CreateTimeBegin</c>, specify the earliest creation time. Use the <c>yyyy-MM-ddTHH:mmZ</c> format.</para>
            /// </description></item>
            /// <item><description><para>When <c>Key</c> is <c>CreateTimeEnd</c>, specify the latest creation time. Use the <c>yyyy-MM-ddTHH:mmZ</c> format.</para>
            /// </description></item>
            /// <item><description><para>When <c>Key</c> is <c>StartTimeBegin</c>, specify the earliest start time. Use the <c>yyyy-MM-ddTHH:mmZ</c> format.</para>
            /// </description></item>
            /// <item><description><para>When <c>Key</c> is <c>StartTimeEnd</c>, specify the latest start time. Use the <c>yyyy-MM-ddTHH:mmZ</c> format.</para>
            /// </description></item>
            /// <item><description><para>When <c>Key</c> is <c>EndTimeBegin</c>, specify the earliest end time. Use the <c>yyyy-MM-ddTHH:mmZ</c> format.</para>
            /// </description></item>
            /// <item><description><para>When <c>Key</c> is <c>EndTimeEnd</c>, specify the latest end time. Use the <c>yyyy-MM-ddTHH:mmZ</c> format.</para>
            /// </description></item>
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
        /// <para>The maximum number of results to return per page.</para>
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
        /// <para>The pagination token for the next page of results. If the response is truncated, use this token in your next request to retrieve the subsequent page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to return report information.</para>
        /// <list type="bullet">
        /// <item><description><para>True (default): Includes reports in the response.</para>
        /// </description></item>
        /// <item><description><para>False: Excludes reports from the response.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Set this parameter to False to speed up the query.</para>
        /// </description></item>
        /// <item><description><para>This parameter is supported only in CPFS for AI Computing.</para>
        /// </description></item>
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
