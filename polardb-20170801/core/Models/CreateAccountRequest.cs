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
        /// <item><description>It cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>It must be 2 to 256 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testdes</para>
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// <para>The name of the account. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It must start with a lowercase letter and end with a letter or a digit.</description></item>
        /// <item><description>It can contain lowercase letters, digits, and underscores (_).</description></item>
        /// <item><description>It must be 2 to 16 characters in length.</description></item>
        /// <item><description>It cannot be root, admin, or another username that is reserved by the system.</description></item>
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
        /// <para>The password of the account. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>The password must be 8 to 32 characters in length.</description></item>
        /// <item><description>Special characters include <c>! @ # $ % ^ &amp; * ( ) _ + - =</c></description></item>
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
        /// <para>The permissions that are granted to the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: read and write permissions.</description></item>
        /// <item><description><b>ReadOnly</b>: read-only permissions.</description></item>
        /// <item><description><b>DMLOnly</b>: the permissions to execute only DML statements.</description></item>
        /// <item><description><b>DDLOnly</b>: the permissions to execute only DDL statements.</description></item>
        /// <item><description><b>ReadIndex</b>: the read-only and index permissions.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><c>AccountPrivilege</c> is valid only after you specify <c>DBName</c>.</para>
        /// </description></item>
        /// <item><description><para>If multiple database names are specified by the <c>DBName</c> parameter, you must grant permissions on the databases. Separate multiple permissions with commas (,), and make sure that the length of the value of <c>AccountPrivilege</c> does not exceed 900. For example, if you want to grant the account the read and write permissions on DB1 and the read-only permissions on DB2, set <c>DBName</c> to <c>DB1,DB2</c> and set <c>AccountPrivilege</c> to <c>ReadWrite,ReadOnly</c>.</para>
        /// </description></item>
        /// <item><description><para>This parameter is valid only for standard accounts of PolarDB for MySQL clusters.</para>
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
        /// <para>The type of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: standard account</description></item>
        /// <item><description><b>Super</b>: privileged account.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you leave this parameter empty, the default value <b>Super</b> is used.</para>
        /// </description></item>
        /// <item><description><para>You can create multiple privileged accounts for a PolarDB for PostgreSQL (Compatible with Oracle) cluster or a PolarDB for PostgreSQL cluster. A privileged account has more permissions than a standard account. For more information, see <a href="https://help.aliyun.com/document_detail/68508.html">Create a database account</a>.</para>
        /// </description></item>
        /// <item><description><para>You can create only one privileged account for a PolarDB for MySQL cluster. A privileged account has more permissions than a standard account. For more information, see <a href="https://help.aliyun.com/document_detail/68508.html">Create a database account</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. The token is case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5c******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
        /// <para>The name of the database that can be accessed by the account. To enter multiple database names, separate the names with commas (,).</para>
        /// <remarks>
        /// <para> This parameter is valid only for standard accounts of PolarDB for MySQL clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
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
