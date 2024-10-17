// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DownloadDataTrackResultShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The condition to filter columns.</para>
        /// </summary>
        [NameInMap("ColumnFilter")]
        [Validation(Required=false)]
        public string ColumnFilterShrink { get; set; }

        /// <summary>
        /// <para>The IDs of the events.</para>
        /// </summary>
        [NameInMap("EventIdList")]
        [Validation(Required=false)]
        public string EventIdListShrink { get; set; }

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
        public string FilterTableListShrink { get; set; }

        /// <summary>
        /// <para>The types of data operations that you want to track.</para>
        /// </summary>
        [NameInMap("FilterTypeList")]
        [Validation(Required=false)]
        public string FilterTypeListShrink { get; set; }

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
