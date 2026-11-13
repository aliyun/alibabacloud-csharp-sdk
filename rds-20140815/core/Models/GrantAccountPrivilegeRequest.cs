// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class GrantAccountPrivilegeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the account. You can call the <a href="https://help.aliyun.com/document_detail/610454.html">DescribeAccounts</a> operation to query the account name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The permission type of the account. If you specify multiple values for DBName, you must specify the same number of permission types in the same order and separate them with commas (,).</para>
        /// <para>The supported permission types vary based on the database engine. Valid values:</para>
        /// <remarks>
        /// <para>For more information about account permissions, see <a href="https://help.aliyun.com/document_detail/146395.html">MySQL and MariaDB permissions</a>, <a href="https://help.aliyun.com/document_detail/95692.html">SQL Server permissions</a>, and <a href="https://help.aliyun.com/document_detail/257684.html">PostgreSQL permissions</a>.</para>
        /// </remarks>
        /// <details>
        /// <summary>RDS MySQL and RDS MariaDB</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: Read and write.</description></item>
        /// <item><description><b>ReadOnly</b>: Read-only.</description></item>
        /// <item><description><b>DDLOnly</b>: DDL only.</description></item>
        /// <item><description><b>DMLOnly</b>: DML only.</description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// <summary>RDS SQL Server</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: Read and write. This permission corresponds to the <c>db_datawriter</c> and <c>db_datareader</c> database roles in SQL Server.</description></item>
        /// <item><description><b>ReadOnly</b>: Read-only. This permission corresponds to the <c>db_datareader</c> database role in SQL Server.</description></item>
        /// <item><description><b>DBOwner</b>: Database owner. This permission corresponds to the <c>db_owner</c> database role in SQL Server.<remarks>
        /// <para>For more information about database-level roles, see <a href="https://learn.microsoft.com/en-us/sql/relational-databases/security/authentication-access/database-level-roles?view=sql-server-ver16">Microsoft documentation</a>.</para>
        /// </remarks>
        /// </details></description></item>
        /// </list>
        /// <details>
        /// <summary>RDS PostgreSQL</summary>
        /// 
        /// <para><b>DBOwner</b>: Database owner.</para>
        /// <remarks>
        /// <para>For more information about fine-grained management of account permissions, see <a href="https://help.aliyun.com/document_detail/352149.html">Best practices for PostgreSQL permission management</a>.</para>
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
        /// <para>Instance ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/610396.html">DescribeDBInstances</a> operation to query instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database to which you want to grant access. To grant access to multiple databases at a time, separate multiple database names with commas (,), such as <c>db1,db2,db3</c>.</para>
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
