// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateDBRequest : TeaModel {
        /// <summary>
        /// <para>The name of the account that is authorized to access the created database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testaccount</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The permissions granted to the account on the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: read and write permissions.</description></item>
        /// <item><description><b>ReadOnly</b>: read-only permissions.</description></item>
        /// <item><description><b>DMLOnly</b>: DML-only permissions.</description></item>
        /// <item><description><b>DDLOnly</b>: DDL-only permissions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ReadWrite</para>
        /// </summary>
        [NameInMap("AccountPrivilege")]
        [Validation(Required=false)]
        public string AccountPrivilege { get; set; }

        /// <summary>
        /// <para>The character set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>utf8</b></description></item>
        /// <item><description><b>gbk</b></description></item>
        /// <item><description><b>latin1</b></description></item>
        /// <item><description><b>utf8mb4</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>utf8mb4</para>
        /// </summary>
        [NameInMap("Charset")]
        [Validation(Required=false)]
        public string Charset { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-**************</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The description of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db for test</para>
        /// </summary>
        [NameInMap("DbDescription")]
        [Validation(Required=false)]
        public string DbDescription { get; set; }

        /// <summary>
        /// <para>The name of the database to create.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The mode of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>auto</b>: The database supports automatic partitioning. You do not need to specify a partition key when you create a table.</description></item>
        /// <item><description><b>drds</b>: The database does not support automatic partitioning. You must use the dedicated sharding syntax to specify sharding keys when you create a table.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The region where the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the security administrator account.</para>
        /// <remarks>
        /// <para>If the three-role mode is enabled, this parameter is required. If the three-role mode is not enabled, this parameter is not required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>securityAccount</para>
        /// </summary>
        [NameInMap("SecurityAccountName")]
        [Validation(Required=false)]
        public string SecurityAccountName { get; set; }

        /// <summary>
        /// <para>The password of the security administrator account.</para>
        /// <remarks>
        /// <para>If the three-role mode is enabled, this parameter is required. If the three-role mode is not enabled, this parameter is not required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>securityPassword</para>
        /// </summary>
        [NameInMap("SecurityAccountPassword")]
        [Validation(Required=false)]
        public string SecurityAccountPassword { get; set; }

        [NameInMap("StoragePoolName")]
        [Validation(Required=false)]
        public string StoragePoolName { get; set; }

    }

}
