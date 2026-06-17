// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateAccountZonalRequest : TeaModel {
        /// <summary>
        /// <para>The description of the account. The description must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </description></item>
        /// <item><description><para>Be 2 to 256 characters in length.</para>
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
        /// <para>The account name. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Start with a lowercase letter and end with a letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>Contain only lowercase letters, digits, and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>Be 2 to 16 characters in length.</para>
        /// </description></item>
        /// <item><description><para>Cannot be a reserved username, such as root or admin.</para>
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
        /// <para>The account password. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
        /// </description></item>
        /// <item><description><para>Be 8 to 32 characters in length.</para>
        /// </description></item>
        /// <item><description><para>Special characters are <c>!@#$%^&amp;*()_+-=</c>.</para>
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
        /// <para>The permissions of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ReadWrite: read and write permissions.</para>
        /// </description></item>
        /// <item><description><para>ReadOnly: read-only permissions.</para>
        /// </description></item>
        /// <item><description><para>DMLOnly: DML permissions only.</para>
        /// </description></item>
        /// <item><description><para>DDLOnly: DDL permissions only.</para>
        /// </description></item>
        /// <item><description><para>ReadIndex: read and index permissions.</para>
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
        /// <para>The account type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Normal: a standard account.</para>
        /// </description></item>
        /// <item><description><para>Super: a privileged account.</para>
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
        /// <para>A client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token is case-sensitive and can contain a maximum of 64 ASCII characters.</para>
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
        /// <para>The name of the database that the destination account can access. You can specify multiple database names. Separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The node type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
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
        /// <para>Specifies whether to grant permissions on all current and future databases in the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0 or empty: Does not grant permissions.</para>
        /// </description></item>
        /// <item><description><para>1: Grants permissions.</para>
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
