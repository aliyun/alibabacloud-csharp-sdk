// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListResultExportJobHistoryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (3.0) cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (3.0) clusters in the specified region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-7xv5ty5m9o4v****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The database user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("DatabaseUser")]
        [Validation(Required=false)]
        public string DatabaseUser { get; set; }

        /// <summary>
        /// <para>The end time of the query. Specify the time in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-25T06:54:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The sorting conditions for SQL statements based on specified fields. The value is in JSON format and is an ordered JSON array that specifies composite sorting based on the sequence of the input array. The array contains the <c>Field</c> and <c>Type</c> fields. Example: <c>[{&quot;Field&quot;:&quot;CreateTimee&quot;, &quot;Type&quot;: &quot;desc&quot; }]</c>. Details:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c>: the name of the field by which to sort the statements. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>CreateTime</c>: the execution start time.</description></item>
        /// <item><description><c>Status</c>: the execution status.</description></item>
        /// <item><description><c>DatabaseUser</c>: the username.</description></item>
        /// <item><description><c>TimeCost</c>: the execution duration.</description></item>
        /// <item><description><c>ResourceGroup</c>: the resource group.</description></item>
        /// <item><description><c>ExportRows</c>: the number of exported rows.</description></item>
        /// <item><description><c>Progress</c>: the export progress.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c>: the sorting type. Valid values (case-insensitive):</para>
        /// <list type="bullet">
        /// <item><description><c>Desc</c>: descending order.</description></item>
        /// <item><description><c>Asc</c>: ascending order.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public ListResultExportJobHistoryRequestOrder Order { get; set; }
        public class ListResultExportJobHistoryRequestOrder : TeaModel {
            /// <summary>
            /// <para>The name of the field by which to sort. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CreateTime</description></item>
            /// <item><description>DatabaseUser</description></item>
            /// <item><description>TimeCost</description></item>
            /// <item><description>ResourceGroup</description></item>
            /// <item><description>Status</description></item>
            /// <item><description>Progress</description></item>
            /// <item><description>ExportRows</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DatabaseUser</para>
            /// </summary>
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// <para>The sorting type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Desc</b>: descending order.</description></item>
            /// <item><description><b>Asc</b>: ascending order.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Desc</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The page number. The value must be an integer greater than 0 and less than or equal to the maximum value of the Integer data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b> (default)</description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the regions and zones supported by AnalyticDB for MySQL, including region IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group in which the task is executed. You can filter tasks by resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_default</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the <i>yyyy-MM-ddTHH:mm:ssZ</i> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-01T12:01:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The list of task execution statuses. You can filter tasks by status.</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

    }

}
