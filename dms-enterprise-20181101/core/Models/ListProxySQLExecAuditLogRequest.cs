// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListProxySQLExecAuditLogRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The value of this parameter must be a timestamp that follows the UNIX time format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1636962846000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The execution status of the SQL statement. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FAIL</b>: The execution of the SQL statement fails.</description></item>
        /// <item><description><b>CANCEL</b>: The execution of the SQL statement is canceled.</description></item>
        /// <item><description><b>SUCCESS</b>: The SQL statement is executed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("ExecState")]
        [Validation(Required=false)]
        public string ExecState { get; set; }

        /// <summary>
        /// <para>The alias of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testNickName</para>
        /// </summary>
        [NameInMap("OpUserName")]
        [Validation(Required=false)]
        public string OpUserName { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum values: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of SQL statement. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SELECT</b></description></item>
        /// <item><description><b>INSERT</b></description></item>
        /// <item><description><b>DELETE</b></description></item>
        /// <item><description><b>CREATE_TABLE</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> You can choose Operation Audit &gt; Secure Access Proxy in the top navigation bar of the DMS console to view more types of SQL statements.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("SQLType")]
        [Validation(Required=false)]
        public string SQLType { get; set; }

        /// <summary>
        /// <para>The name of the database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SearchName")]
        [Validation(Required=false)]
        public string SearchName { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value of this parameter must be a timestamp that follows the UNIX time format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1636876446000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14****</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
