// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetOpLogRequest : TeaModel {
        /// <summary>
        /// <para>DatabaseName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dmstest@rm-bp1qb97d4b****.mysql.rds.aliyuncs.com:3306[poc_dev]</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the yyyy-MM-DD HH:mm:ss format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-29 10:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The functional module for which you want to query operation logs. If you do not specify this parameter, operation logs for all functional modules are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PERMISSION</b>: permissions</description></item>
        /// <item><description><b>OWNER</b>: data owner</description></item>
        /// <item><description><b>SQL_CONSOLE</b>: data query</description></item>
        /// <item><description><b>SQL_CONSOLE_EXPORT</b>: query result export</description></item>
        /// <item><description><b>DATA_CHANGE</b>: data change</description></item>
        /// <item><description><b>DATA_EXPORT</b>: data export</description></item>
        /// <item><description><b>SQL_REVIEW</b>: SQL review</description></item>
        /// <item><description><b>DT_SYNC</b>: database and table synchronization</description></item>
        /// <item><description><b>DT_DETAIL</b>: database and table details</description></item>
        /// <item><description><b>DB_TASK</b>: task management</description></item>
        /// <item><description><b>INSTANCE_MANAGE</b>: instance management</description></item>
        /// <item><description><b>USER_MANAGE</b>: user management</description></item>
        /// <item><description><b>SECURITY_RULE</b>: security rules</description></item>
        /// <item><description><b>CONFIG_MANAGE</b>: configuration management</description></item>
        /// <item><description><b>RESOURCE_AUTH</b>: resource authorization</description></item>
        /// <item><description><b>ACCESS_WHITE_IP</b>: access IP address whitelist</description></item>
        /// <item><description><b>NDDL</b>: schema design</description></item>
        /// <item><description><b>DSQL_CONSOLE</b>: cross-database data query</description></item>
        /// <item><description><b>DSQL_CONSOLE_EXPORT</b>: cross-database query result export</description></item>
        /// <item><description><b>DATA_TRACT</b>: data tracking</description></item>
        /// <item><description><b>DATA_QUALITY</b>: data quality</description></item>
        /// <item><description><b>DATALINK_MANAGE</b> :DBLink management</description></item>
        /// <item><description><b>DATASEC_MANAGE</b>: sensitive data management</description></item>
        /// <item><description><b>SELL</b>: sales</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SECURITY_RULE</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Pages start from page 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>30</description></item>
        /// <item><description>50</description></item>
        /// <item><description>100</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the yyyy-MM-DD HH:mm:ss format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-23 10:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>UserNick.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("UserNick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

    }

}
