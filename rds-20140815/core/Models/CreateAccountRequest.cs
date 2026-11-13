// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The description of the account. It must be 2 to 256 characters in length. It must start with a letter or a Chinese character and can contain letters, Chinese characters, digits, underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para>It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testuser</para>
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// <para>The name of the database account.</para>
        /// <remarks>
        /// <para>The name must be unique and can contain uppercase letters (supported only by MySQL), lowercase letters, digits, and underscores (_). For specific naming rules, see the tutorials for each engine: <a href="https://help.aliyun.com/document_detail/96089.html">Create an ApsaraDB RDS for MySQL account</a>, <a href="https://help.aliyun.com/document_detail/96753.html">Create an ApsaraDB RDS for PostgreSQL account</a>, <a href="https://help.aliyun.com/document_detail/95810.html">Create an ApsaraDB RDS for SQL Server account</a>, and <a href="https://help.aliyun.com/document_detail/97132.html">Create an ApsaraDB RDS for MariaDB account</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The password of the database account.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The password must be 8 to 32 characters in length.</description></item>
        /// <item><description>The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters (<c>!@#$%^&amp;*()_+-=</c>).</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>The type of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b> (default): Standard account.</description></item>
        /// <item><description><b>Super</b>: Privileged account. You can create only one privileged account for each instance.</description></item>
        /// <item><description><b>Sysadmin</b> (ApsaraDB RDS for SQL Server only): Database account with SA permissions. Before you create an account of this type, check whether the instance meets the <a href="https://help.aliyun.com/document_detail/170736.html">prerequisites</a>.</description></item>
        /// <item><description><b>GlobalRO</b> (ApsaraDB RDS for SQL Server only): Global read-only account. You can create up to two global read-only accounts for each instance. The database engine version of the instance must be SQL Server 2016 or later, and the instance family must be dedicated or general-purpose.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>Specifies whether to apply the <a href="https://help.aliyun.com/document_detail/2845728.html">account password policy</a> to the ApsaraDB RDS for SQL Server instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Applies the policy.</description></item>
        /// <item><description><b>false</b>: Does not apply the policy.<remarks>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to true, you must <a href="https://help.aliyun.com/document_detail/2848317.html">configure the account password policy for ApsaraDB RDS for SQL Server</a> in advance.</description></item>
        /// <item><description>This parameter is not supported for ApsaraDB RDS for SQL Server instances of the <a href="https://help.aliyun.com/document_detail/57184.html">shared instance type</a>, <a href="https://help.aliyun.com/document_detail/145468.html">SQL Server 2008 R2</a>, or <a href="https://help.aliyun.com/document_detail/603466.html">Serverless</a> type.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CheckPolicy")]
        [Validation(Required=false)]
        public bool? CheckPolicy { get; set; }

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
