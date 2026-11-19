// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The account description.</para>
        /// <list type="bullet">
        /// <item><description>Regular expression: <c>^[a-zA-Z一-龥][a-zA-Z一-龥0-9_.-]{1,255}$</c>. The description must start with an English letter or Chinese character, followed by English letters, Chinese characters, digits, underscores (_), periods (.), or hyphens (-). The length must be 2 to 256 characters.</description></item>
        /// <item><description>If the description is invalid, InvalidAccountDescription.Malformed is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// <para>The account name.</para>
        /// <list type="bullet">
        /// <item><description>Regular expression: <c>^[a-z]+[a-z0-9|_]*[a-z0-9]+$</c>. The name must start with a lowercase letter, end with a lowercase letter or digit, and can contain lowercase letters, digits, and underscores (_). The length must be 2 to 16 characters.</description></item>
        /// <item><description>The reserved name <c>root</c> (case-insensitive, built-in system account) cannot be used.</description></item>
        /// <item><description>The name cannot start with <c>__cloud</c> (reserved prefix for system accounts).</description></item>
        /// <item><description>If the name is invalid, <c>InvalidAccountName.Malformed</c> is returned.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin1</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The account password.</para>
        /// <list type="bullet">
        /// <item><description>The length must be 8 to 32 characters. It can contain uppercase letters, lowercase letters, digits, and the following special characters: <c>!@#$%^&amp;*()_+-=</c>.</description></item>
        /// <item><description>The password must contain at least <b>three</b> of the following four character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>If the password is invalid, <c>InvalidAccountPassword.Malformed</c> is returned.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For information about how to handle special characters, see <a href="https://help.aliyun.com/document_detail/471568.html">How do I resolve the connection failure caused by special characters in the account name or password of a connection string?</a></para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456!</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>The account type.<br>Valid values:<br>- <c>normal</c>: replica set account. For a replica set instance, any value is processed as <c>normal</c>.<br>- <c>cs</c>: sharded cluster ConfigServer account.<br>- <c>db</c>: sharded cluster Shard direct connection account. For a sharded cluster instance, any value other than <c>cs</c> is processed as <c>db</c>.<br>Default value: <c>db</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db</para>
        /// </summary>
        [NameInMap("CharacterType")]
        [Validation(Required=false)]
        public string CharacterType { get; set; }

        /// <summary>
        /// <para>The instance ID. For a sharded cluster instance, specify the sharded cluster ID. Account operations are executed from the perspective of the ConfigServer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-uf6e9433e955xxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database to which the account belongs (authentication database).<br>
        /// Default value: <c>admin</c>.<br>Rules: If this parameter is left empty, the request is allowed and the downstream system processes it as <c>admin</c>. If this parameter is specified, the length must be 1 to 63 characters. The value cannot contain <c>/</c>, <c>\\</c>, <c>.</c>, spaces, <c>&quot;</c>, or <c>$</c>, and cannot be <c>local</c>. Otherwise, <c>InvalidParameter</c> is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
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

        /// <summary>
        /// <para>The list of authorization roles for the account. <b>Required for replica set and ConfigServer (cs) accounts</b>. <b>Prohibited for sharded cluster Shard direct connection (db) accounts</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>Globally prohibited</b> (returns <c>InvalidRoles.NotAllowed</c>): <c>root</c>, <c>clusterAdmin</c>, <c>hostManager</c>, <c>clusterManager</c>, <c>__system</c>, <c>__queryableBackup</c>, and <c>restore</c>.</description></item>
        /// <item><description><b>Can be authorized to any database (including admin)</b>: <c>read</c>, <c>userAdmin</c>, and <c>enableSharding</c>.</description></item>
        /// <item><description><b>Can only be authorized to non-admin databases</b> (returns <c>InvalidRoles.InvalidDB</c> if authorized to admin): <c>readWrite</c>, <c>dbAdmin</c>, and <c>dbOwner</c>.</description></item>
        /// <item><description><b>Can only be authorized to the admin database</b>: <c>readAnyDatabase</c>, <c>readWriteAnyDatabase</c>, <c>userAdminAnyDatabase</c>, <c>dbAdminAnyDatabase</c>, <c>clusterMonitor</c>, <c>backup</c>, and <c>alibabaCloudAdmin</c>. (<c>alibabaCloudAdmin</c> is supported only for instances with kernel version 4.4 or later. For earlier versions, <c>InvalidRoles.NotAllowed</c> is returned.)</description></item>
        /// <item><description><b>Custom roles</b>: Roles other than the preceding ones are considered custom roles and must already exist in the instance (you can query them by calling DescribeAccountRoles). Otherwise, <c>InvalidRoles.NotFound</c> is returned. <c>Roles.N.DBName</c> must be the same as the database where the role is defined. Otherwise, <c>InvalidRoles.DBNotMatch</c> is returned.</description></item>
        /// <item><description>If <c>Roles</c> is missing as a whole, <c>MissingRoles</c> is returned. If <c>Roles.N.Role</c> and <c>Roles.N.DBName</c> do not appear in pairs, <c>InvalidRoles.Malformed</c> is returned. If <c>Roles</c> is passed for a sharded cluster Shard direct connection account, <c>InvalidRoles.NotSupported</c> is returned.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Roles")]
        [Validation(Required=false)]
        public List<CreateAccountRequestRoles> Roles { get; set; }
        public class CreateAccountRequestRoles : TeaModel {
            /// <summary>
            /// <para>The database to which the account belongs (authentication database).<br>
            /// Default value: <c>admin</c>.<br>Rules: If this parameter is left empty, the request is allowed and the downstream system processes it as <c>admin</c>. If this parameter is specified, the length must be 1 to 63 characters. The value cannot contain <c>/</c>, <c>\\</c>, <c>.</c>, spaces, <c>&quot;</c>, or <c>$</c>, and cannot be <c>local</c>. Otherwise, <c>InvalidParameter</c> is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <para>The role name. It can be a built-in role or a custom role created on the instance. For value rules, see <a href="https://www.alibabacloud.com/help/en/mongodb/manage-database-accounts-through-the-console">Roles parameter description</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>read</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

    }

}
