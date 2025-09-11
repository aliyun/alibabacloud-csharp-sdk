// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowTasksRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <list type="bullet">
        /// <item><description>The IDs of CPFS file systems must start with <c>cpfs-</c>. Example: cpfs-099394bd928c\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>The IDs of CPFS for LINGJUN file systems must start with <c>bmcpfs-</c>. Example: bmcpfs-290w65p03ok64ya\<em>\</em>\<em>\</em>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> CPFS is not supported on the international site.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The details about filters.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeDataFlowTasksRequestFilters> Filters { get; set; }
        public class DescribeDataFlowTasksRequestFilters : TeaModel {
            /// <summary>
            /// <para>The filter name.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DataFlowIds: filters data flow tasks by data flow ID.</description></item>
            /// <item><description>TaskIds: filters data flow tasks by task ID.</description></item>
            /// <item><description>Originator: filters data flow tasks by task initiator.</description></item>
            /// <item><description>TaskActions: filters data flow tasks by task type.</description></item>
            /// <item><description>DataTypes: filters data flow tasks by data type.</description></item>
            /// <item><description>Status: filters data flow tasks by data flow status.</description></item>
            /// <item><description>CreateTimeBegin: filters data flow tasks that are created after a specified time.</description></item>
            /// <item><description>CreateTimeEnd: filters data flow tasks that are created before a specified time.</description></item>
            /// <item><description>StartTimeBegin: filters data flow tasks that are started after a specified time.</description></item>
            /// <item><description>StartTimeEnd: filters data flow tasks that are started before a specified time.</description></item>
            /// <item><description>EndTimeBegin: filters data flow tasks that are stopped after a specified time.</description></item>
            /// <item><description>EndTimeEnd: filters data flow tasks that are stopped before a specified time.</description></item>
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
            /// <item><description>If Key is set to DataFlowIds, set Value to a data flow ID or a part of the data flow ID. You can specify a data flow ID or a group of data flow IDs. You can specify a maximum of 10 data flow IDs. Example: <c>df-194433a5be31****</c> or <c>df-194433a512a2****,df-234533a5be31****</c>.</description></item>
            /// <item><description>If Key is set to TaskId, set Value to a data flow task ID or a part of the data flow task ID. You can specify a data flow task ID or a group of data flow task IDs. You can specify a maximum of 10 data flow task IDs. Example: <c>task-38aa8e890f45****</c> or <c>task-38aa8e890f45****,task-29ae8e890f45****</c>.</description></item>
            /// <item><description>If Key is set to TaskActions, set Value to the type of data flow task. The task type can be <b>Import</b>, <b>Export</b>, <b>Evict</b>, <b>Inventory</b>, <b>StreamImport</b>, or <b>StreamExport</b>. Combined query is supported. CPFS for LINGJUN supports only the Import, Export, StreamImport, and StreamExport tasks. Only CPFS for LINGJUN V2.6.0 and later support the StreamImport and StreamExport tasks.</description></item>
            /// <item><description>If Key is set to DataTypes, set Value to the data type of the data flow task. The data type can be MetaAndData, Metadata, or Data. Combined query is supported.</description></item>
            /// <item><description>If Key is set to Originator, set Value to the initiator of the data flow task. The initiator can be User or System.</description></item>
            /// <item><description>If Key is set to Status, set Value to the status of the data flow task. The status can be Pending, Executing, Failed, Completed, Canceling, or Canceled. Combined query is supported.</description></item>
            /// <item><description>If Key is set to CreateTimeBegin, set Value to the beginning of the time range to create the data flow task. Time format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// <item><description>If Key is set to CreateTimeEnd, set Value to the end of the time range to create the data flow task. Time format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// <item><description>If Key is set to StartTimeBegin, set Value to the beginning of the time range to start the data flow task. Time format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// <item><description>If Key is set to StartTimeEnd, set Value to the end of the time range to start the data flow task. Time format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// <item><description>If Key is set to EndTimeBegin, set Value to the beginning of the time range to stop the data flow task. Time format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// <item><description>If Key is set to EndTimeEnd, set Value to the end of the time range to stop the data flow task. Time format: <c>yyyy-MM-ddThh:mmZ</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dfid-12345678</para>
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
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("WithReports")]
        [Validation(Required=false)]
        public bool? WithReports { get; set; }

    }

}
