// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class GrantAccountPrivilegeRequest : TeaModel {
        /// <summary>
        /// <para>The username of the account.</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description><b>ReadWrite</b>: read and write permissions</description></item>
        /// <item><description><b>ReadOnly</b>: read-only permissions</description></item>
        /// <item><description><b>DMLOnly</b>: The account is granted the permissions to execute only DML statements on the database.</description></item>
        /// <item><description><b>DDLOnly</b>: The account is granted the permissions to execute only DDL statements on the database.</description></item>
        /// <item><description><b>ReadIndex</b>: The account has the read and index permissions on the database.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The number of <b>AccountPrivilege</b> values must be the consistent with the number of <b>DBName</b> values. Each account permission must correspond to a database name in sequence. For example, you can set <b>DBName</b> to <c>testdb_1,testdb_2</c> and set <b>AccountPrivilege</b> to <c>ReadWrite,ReadOnly</c>. In this case, the specified standard account is granted the <b>read and write</b> permissions on the <b>testdb_1</b> database and the <b>read</b> permission on the <b>testdb_2</b> database.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReadWrite,ReadOnly</para>
        /// </summary>
        [NameInMap("AccountPrivilege")]
        [Validation(Required=false)]
        public string AccountPrivilege { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The names of the databases that the account can access. You can grant the access permissions on one or more databases to the specified standard account. If you need to specify multiple database names, separate the database names with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb_1,testdb_2</para>
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
