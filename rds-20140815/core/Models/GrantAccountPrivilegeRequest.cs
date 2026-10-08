// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class GrantAccountPrivilegeRequest : TeaModel {
        /// <summary>
        /// <para>The account name. You can call <a href="https://help.aliyun.com/document_detail/610454.html">DescribeAccounts</a> to query the account name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The type of account permission. If you specify multiple values for DBName, you must specify the same number of permission types in the same order, separated by commas (,).</para>
        /// <para>The supported permission types vary by database engine. Valid values:</para>
        /// <remarks>
        /// <para>For more information about account permissions, see <a href="https://help.aliyun.com/document_detail/146395.html">MySQL/MariaDB permission list</a>, <a href="https://help.aliyun.com/document_detail/95692.html">SQL Server permission list</a>, and <a href="https://help.aliyun.com/document_detail/257684.html">PostgreSQL permission list</a>.</para>
        /// </remarks>
        /// <details>
        /// <summary>ApsaraDB RDS for MySQL/ApsaraDB RDS for MariaDB</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: read and write.</description></item>
        /// <item><description><b>ReadOnly</b>: read-only.</description></item>
        /// <item><description><b>DDLOnly</b>: DDL only.</description></item>
        /// <item><description><b>DMLOnly</b>: DML only.</description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// <summary>ApsaraDB RDS for SQL Server</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: read and write. This permission corresponds to the <c>db_datawriter</c> and <c>db_datareader</c> database roles in SQL Server.</description></item>
        /// <item><description><b>ReadOnly</b>: read-only. This permission corresponds to the <c>db_datareader</c> database role in SQL Server.</description></item>
        /// <item><description><b>DBOwner</b>: database owner. This permission corresponds to the <c>db_owner</c> database role in SQL Server.<remarks>
        /// <para>For more information about database-level roles, see <a href="https://learn.microsoft.com/en-us/sql/relational-databases/security/authentication-access/database-level-roles?view=sql-server-ver16">Microsoft official documentation</a>.</para>
        /// </remarks>
        /// </details></description></item>
        /// </list>
        /// <details>
        /// <summary>ApsaraDB RDS for PostgreSQL</summary>
        /// 
        /// <para><b>DBOwner</b>: database owner.</para>
        /// <remarks>
        /// <para>For fine-grained permission management, see <a href="https://help.aliyun.com/document_detail/352149.html">Best practices for PostgreSQL permission management</a>.</para>
        /// </remarks>
        /// </details>
        /// 
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReadWrite</para>
        /// </summary>
        [NameInMap("AccountPrivilege")]
        [Validation(Required=false)]
        public string AccountPrivilege { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/610396.html">DescribeDBInstances</a> to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database to which you want to grant access permissions. To grant permissions on multiple databases at a time, separate the database names with commas (,), such as <c>db1,db2,db3</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDB1</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
