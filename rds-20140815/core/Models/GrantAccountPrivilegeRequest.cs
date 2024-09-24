// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class GrantAccountPrivilegeRequest : TeaModel {
        /// <summary>
        /// <para>The username of the account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The permissions that you want to grant to the account. The number of permissions must be the same as the number of databases that you specify for the DBName parameter. You can specify this parameter based on your business requirements. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: read and write permissions</description></item>
        /// <item><description><b>ReadOnly</b>: read-only permissions</description></item>
        /// <item><description><b>DDLOnly</b>: DDL-only permissions</description></item>
        /// <item><description><b>DMLOnly</b>: DML-only permissions</description></item>
        /// <item><description><b>DBOwner</b>: database owner permissions</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If the instance runs MySQL or MariaDB, you can set this parameter to <b>ReadWrite</b>, <b>ReadOnly</b>, <b>DDLOnly</b>, or <b>DMLOnly</b>.</para>
        /// </description></item>
        /// <item><description><para>If the instance runs SQL Server, you can set this parameter to <b>ReadWrite</b>, <b>ReadOnly</b>, or <b>DBOwner</b>.</para>
        /// </description></item>
        /// <item><description><para>If the instance runs PostgreSQL and uses cloud disks, you can set this parameter to <b>DBOwner</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ReadWrite</para>
        /// </summary>
        [NameInMap("AccountPrivilege")]
        [Validation(Required=false)]
        public string AccountPrivilege { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database on which you want to grant permissions. Separate multiple database names with commas (,).</para>
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
