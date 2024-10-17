// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDataImportSQLPreCheckDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ticket ID. You can call the <a href="https://help.aliyun.com/document_detail/144643.html">ListOrders</a> operation to query the ticket ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumer")]
        [Validation(Required=false)]
        public long? PageNumer { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the SQL statement. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SELECT</b></description></item>
        /// <item><description><b>INSERT</b></description></item>
        /// <item><description><b>DELETE</b></description></item>
        /// <item><description><b>CREATE_TABLE</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>You can log on to the Data Management (DMS) console and choose <b>Security and Specifications</b> &gt; <b>Operation Audit</b> in the top navigation bar to view more types of SQL statements.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>INSERT</para>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The state of the ticket. If you leave this parameter empty, all the states are queried by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INIT</b>: The ticket is being initialized.</description></item>
        /// <item><description><b>RUNNING</b>: The ticket is in progress.</description></item>
        /// <item><description><b>SUCCESS</b>: The ticket is complete.</description></item>
        /// <item><description><b>TIMEOUT</b>: The ticket is skipped due to timeout.</description></item>
        /// <item><description><b>FAIL</b>: The ticket fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
