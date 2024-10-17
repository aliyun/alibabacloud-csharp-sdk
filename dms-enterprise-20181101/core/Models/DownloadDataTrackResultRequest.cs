// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DownloadDataTrackResultRequest : TeaModel {
        /// <summary>
        /// <para>The condition to filter columns.</para>
        /// </summary>
        [NameInMap("ColumnFilter")]
        [Validation(Required=false)]
        public DownloadDataTrackResultRequestColumnFilter ColumnFilter { get; set; }
        public class DownloadDataTrackResultRequestColumnFilter : TeaModel {
            /// <summary>
            /// <para>The end value of the range used in the filter condition. This parameter takes effect only when Operator is set to BETWEEN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BetweenEnd")]
            [Validation(Required=false)]
            public string BetweenEnd { get; set; }

            /// <summary>
            /// <para>The start value of the range used in the filter condition. This parameter takes effect only when Operator is set to BETWEEN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BetweenStart")]
            [Validation(Required=false)]
            public string BetweenStart { get; set; }

            /// <summary>
            /// <para>The name of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>account_name</para>
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// <para>The IN list used in the filter condition.</para>
            /// </summary>
            [NameInMap("InList")]
            [Validation(Required=false)]
            public List<string> InList { get; set; }

            /// <summary>
            /// <para>The type of the operator used to configure the filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>EQUAL</b>: retrieves the column whose value is equal to the specified value.</description></item>
            /// <item><description><b>NOT_EQUAL</b>: retrieves the column whose value is not equal to the specified value.</description></item>
            /// <item><description><b>IN</b>: retrieves the column whose value is in the IN list.</description></item>
            /// <item><description><b>BETWEEN</b>: retrieves the column whose value is in the specified range.</description></item>
            /// <item><description><b>LESS</b>: retrieves the column whose value is less than the specified value.</description></item>
            /// <item><description><b>MORE</b>: retrieves the column whose value is greater than the specified value.</description></item>
            /// <item><description><b>NOT_IN</b>: retrieves the column whose value is not in the IN list.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EQUAL</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The value used in the filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The IDs of the events.</para>
        /// </summary>
        [NameInMap("EventIdList")]
        [Validation(Required=false)]
        public List<long?> EventIdList { get; set; }

        /// <summary>
        /// <para>The end time of the time range in which you want to track data operations. The time must be specified in the yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-23 10:00:00</para>
        /// </summary>
        [NameInMap("FilterEndTime")]
        [Validation(Required=false)]
        public string FilterEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the time range in which you want to track data operations. The time must be specified in the yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-23 00:00:00</para>
        /// </summary>
        [NameInMap("FilterStartTime")]
        [Validation(Required=false)]
        public string FilterStartTime { get; set; }

        /// <summary>
        /// <para>The names of the tables for which you want to track data operations.</para>
        /// </summary>
        [NameInMap("FilterTableList")]
        [Validation(Required=false)]
        public List<string> FilterTableList { get; set; }

        /// <summary>
        /// <para>The types of data operations that you want to track.</para>
        /// </summary>
        [NameInMap("FilterTypeList")]
        [Validation(Required=false)]
        public List<string> FilterTypeList { get; set; }

        /// <summary>
        /// <para>The ID of the ticket. You can call the <a href="https://help.aliyun.com/document_detail/144643.html">ListOrders</a> operation to obtain the ticket ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>406****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The type of the SQL statement.</para>
        /// <list type="bullet">
        /// <item><description><b>REVERSE</b>: undoes or rolls back an executed SQL statement, which is equivalent to the UNDO SQL statement.</description></item>
        /// <item><description><b>FORWARD</b>: redoes or re-executes an SQL statement that failed to be executed, which is equivalent to the REDO SQL statement.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REVERSE</para>
        /// </summary>
        [NameInMap("RollbackSQLType")]
        [Validation(Required=false)]
        public string RollbackSQLType { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
