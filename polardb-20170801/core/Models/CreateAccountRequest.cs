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
        /// <item><description>Cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>Is 2 to 256 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testdes</para>
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// <para>The account name. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>Starts with a lowercase letter and ends with a letter or digit.</description></item>
        /// <item><description>Contains only lowercase letters, digits, or underscores (_).</description></item>
        /// <item><description>Is 2 to 16 characters in length.</description></item>
        /// <item><description>Cannot use certain reserved usernames such as root or admin.</description></item>
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
        /// <para>The account password. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>Contains at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>Is 8 to 32 characters in length.</description></item>
        /// <item><description>Special characters include <c>!@#$%^&amp;*()_+-=</c>.</description></item>
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
        /// <para>The permissions of the account. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: read and write</description></item>
        /// <item><description><b>ReadOnly</b>: read-only</description></item>
        /// <item><description><b>DMLOnly</b>: DML only</description></item>
        /// <item><description><b>DDLOnly</b>: DDL only</description></item>
        /// <item><description><b>ReadIndex</b>: read-only and index</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The DBName parameter must be specified for AccountPrivilege to take effect.</description></item>
        /// <item><description>If you specify multiple database names for the DBName parameter, you must grant the corresponding permissions to each database. Separate multiple permissions with commas (,) and make sure that the total length of the AccountPrivilege string does not exceed 900 characters. For example, to grant read and write permissions on database DB1 and read-only permissions on database DB2, set DBName to <c>DB1,DB2</c> and set AccountPrivilege to <c>ReadWrite,ReadOnly</c>.</description></item>
        /// <item><description>This parameter is supported only for standard accounts of PolarDB for MySQL clusters.</description></item>
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
        /// <para>The account type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: standard account. </description></item>
        /// <item><description><b>Super</b>: privileged account. </description></item>
        /// <item><description><b>DynamoDB</b>: DynamoDB account.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If this parameter is left empty, a <b>Super</b> account is created by default.</description></item>
        /// <item><description>If the cluster is a PolarDB for PostgreSQL (Compatible with Oracle) or PolarDB for PostgreSQL cluster, you can create multiple privileged accounts for each cluster. Privileged accounts have more permissions than standard accounts. For more information, see <a href="https://help.aliyun.com/document_detail/68508.html">Create a database account</a>.</description></item>
        /// <item><description>If the cluster is a PolarDB for MySQL cluster, you can create at most one privileged account for each cluster. Privileged accounts have more permissions than standard accounts. For more information, see <a href="https://help.aliyun.com/document_detail/68508.html">Create a database account</a>.</description></item>
        /// <item><description>DynamoDB accounts are dedicated accounts created for the DynamoDB compatibility feature of PolarDB for PostgreSQL. For more information, see <a href="https://help.aliyun.com/document_detail/2979941.html">DynamoDB usage instructions</a>.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value. Make sure that the value is unique among different requests. The token is case-sensitive and cannot exceed 64 ASCII characters in length.</para>
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
        /// <para>The name of the database that the account is authorized to access. You can specify multiple database names separated by commas (,).</para>
        /// <remarks>
        /// <para>This parameter is supported only for standard accounts of PolarDB for MySQL clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Search: required when creating an account for a PolarDB Search node</description></item>
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
        /// <para>Specifies whether to grant permissions on all existing databases and all new databases in the current cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0 or empty</b>: does not grant permissions.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: grants permissions.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The AccountPrivilege parameter must be specified for this parameter to take effect.</description></item>
        /// <item><description>If this parameter is set to <c>1</c>, the permissions specified by AccountPrivilege are granted on all databases.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
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
