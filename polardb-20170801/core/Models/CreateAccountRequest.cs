// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The description of the account. The description must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </description></item>
        /// <item><description><para>It must be 2 to 256 characters in length.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testdes</para>
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// <para>The name of the database account. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>It must start with a lowercase letter and end with a letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>It can contain lowercase letters, digits, and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>It must be 2 to 16 characters in length.</para>
        /// </description></item>
        /// <item><description><para>It cannot be a reserved keyword, such as root or admin.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testacc</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The password of the database account. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>It must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
        /// </description></item>
        /// <item><description><para>It must be 8 to 32 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The special characters are <c>!@#$%^&amp;*()_+-=</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test1111</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>The privilege level to grant on the specified databases. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ReadWrite</b>: read and write permissions</para>
        /// </description></item>
        /// <item><description><para><b>ReadOnly</b>: read-only permissions</para>
        /// </description></item>
        /// <item><description><para><b>DMLOnly</b>: DML permissions only</para>
        /// </description></item>
        /// <item><description><para><b>DDLOnly</b>: DDL permissions only</para>
        /// </description></item>
        /// <item><description><para><b>ReadIndex</b>: read-only and index permissions</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when you specify the <c>DBName</c> parameter.</para>
        /// </description></item>
        /// <item><description><para>If you specify multiple databases in <c>DBName</c>, you must specify a corresponding permission for each in <c>AccountPrivilege</c>, separated by commas. The <c>AccountPrivilege</c> string cannot exceed 900 characters. For example, to grant read and write permissions to database DB1 and read-only permissions to database DB2, set <c>DBName</c> to <c>DB1,DB2</c> and set <c>AccountPrivilege</c> to <c>ReadWrite,ReadOnly</c>.</para>
        /// </description></item>
        /// <item><description><para>This parameter applies only to standard accounts on PolarDB for MySQL clusters.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ReadWrite</para>
        /// </summary>
        [NameInMap("AccountPrivilege")]
        [Validation(Required=false)]
        public string AccountPrivilege { get; set; }

        /// <summary>
        /// <para>The type of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: a standard account.</para>
        /// </description></item>
        /// <item><description><para><b>Super</b>: a privileged account.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter, the system creates a <b>Super</b> account by default.</para>
        /// </description></item>
        /// <item><description><para>You can create multiple privileged accounts on PolarDB for PostgreSQL (Oracle-Compatible) and PolarDB for PostgreSQL clusters. A privileged account has more permissions than a standard account. For more information, see <a href="https://help.aliyun.com/document_detail/68508.html">Create database accounts</a>.</para>
        /// </description></item>
        /// <item><description><para>For a PolarDB for MySQL cluster, you can create only one privileged account. For more information, see <a href="https://help.aliyun.com/document_detail/68508.html">Create database accounts</a>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>A client-generated token to ensure request idempotency. The token must be unique across requests. It is case-sensitive and can be up to 64 ASCII characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5c******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the database that the account can access. To specify multiple databases, separate the database names with a comma (,).</para>
        /// <remarks>
        /// <para>This parameter applies only to standard accounts on PolarDB for MySQL clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The type of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Search</b>: For creating an account on a PolarDB Search node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Search</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to grant the account permissions on all current and future databases in the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0 or do not specify</b>: The specified permissions are not granted to all databases.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Grants the specified permissions to all current and future databases.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when you specify the <c>AccountPrivilege</c> parameter.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to <c>1</c>, the permissions specified in <c>AccountPrivilege</c> are granted to all databases.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PrivForAllDB")]
        [Validation(Required=false)]
        public string PrivForAllDB { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
