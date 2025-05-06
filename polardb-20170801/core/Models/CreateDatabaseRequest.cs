// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The name of the account that is authorized to access the database. You can call the <a href="https://help.aliyun.com/document_detail/98107.html">DescribeAccounts</a> operation to query account information.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can specify only a standard account. By default, privileged accounts have all permissions on all databases. You do not need to grant privileged accounts the permissions to access the database.</description></item>
        /// <item><description>This parameter is required for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters. This parameter is optional for PolarDB for MySQL clusters.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testacc</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The permissions that are granted to the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: read and write permissions.</description></item>
        /// <item><description><b>ReadOnly</b>: read-only permissions.</description></item>
        /// <item><description><b>DMLOnly</b>: permissions only to execute DML statements on the database.</description></item>
        /// <item><description><b>DDLOnly</b>: permissions only to execute DDL statements on the database.</description></item>
        /// <item><description><b>ReadIndex</b>: read-only and index permissions.</description></item>
        /// </list>
        /// <para>The default value is <b>ReadWrite</b>.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is valid only when the <b>AccountName</b> parameter is specified.</para>
        /// </description></item>
        /// <item><description><para>For a PolarDB for PostgreSQL (Compatible with Oracle) or PolarDB for PostgreSQL cluster, this parameter is optional. If <b>AccountName</b> is specified, it is the account of the database owner.</para>
        /// </description></item>
        /// <item><description><para>For a PolarDB for MySQL cluster, this parameter is optional.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ReadWrite</para>
        /// </summary>
        [NameInMap("AccountPrivilege")]
        [Validation(Required=false)]
        public string AccountPrivilege { get; set; }

        /// <summary>
        /// <para>The character set that is used by the cluster. For more information, see <a href="https://help.aliyun.com/document_detail/99716.html">Character set tables</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>utf8</para>
        /// </summary>
        [NameInMap("CharacterSetName")]
        [Validation(Required=false)]
        public string CharacterSetName { get; set; }

        /// <summary>
        /// <para>The language that defines the collation rules in the database.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The language must be compatible with the character set that is specified by <b>CharacterSetName</b>.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required for a PolarDB for PostgreSQL (Compatible with Oracle) or PolarDB for PostgreSQL cluster. This parameter is optional for a PolarDB for MySQL cluster. To view the valid values of this parameter, perform the following steps: Log on to the PolarDB console and click the ID of the cluster. In the left-side navigation pane, choose <b>Settings and Management</b> &gt; <b>Databases</b>. Then, click <b>Create Database</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>C</para>
        /// </summary>
        [NameInMap("Collate")]
        [Validation(Required=false)]
        public string Collate { get; set; }

        /// <summary>
        /// <para>The language that indicates the character type of the database.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The language must be compatible with the character set that is specified by <b>CharacterSetName</b>.</description></item>
        /// <item><description>The value that you specify must be the same as the value of <b>Collate</b>.</description></item>
        /// <item><description>This parameter is required for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters. This parameter is optional for PolarDB for MySQL clusters.</description></item>
        /// </list>
        /// </remarks>
        /// <para>To view the valid values for this parameter, perform the following steps: Log on to the PolarDB console and click the ID of a cluster. In the left-side navigation pane, choose <b>Settings and Management</b> &gt; <b>Databases</b>. Then, click <b>Create Database</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C</para>
        /// </summary>
        [NameInMap("Ctype")]
        [Validation(Required=false)]
        public string Ctype { get; set; }

        /// <summary>
        /// <para>The ID of cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The description of the database. The description must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>It must be 2 to 256 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for a PolarDB for Oracle or PolarDB for PostgreSQL cluster. This parameter is optional for a PolarDB for MySQL cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testdesc</para>
        /// </summary>
        [NameInMap("DBDescription")]
        [Validation(Required=false)]
        public string DBDescription { get; set; }

        /// <summary>
        /// <para>The name of the database. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The name must start with a lowercase letter and end with a lowercase letter or a digit. The name must be 1 to 64 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Do not use reserved words as database names, such as <c>test</c> or <c>mysql</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDB</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
