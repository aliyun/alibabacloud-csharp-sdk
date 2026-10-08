// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The description of the account. The description must be 2 to 256 characters in length. It must start with a letter or a Chinese character and can contain digits, Chinese characters, letters, underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para>The description cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The name must be unique and can contain uppercase letters (supported only by MySQL), lowercase letters, digits, or underscores. For specific naming conventions, refer to the tutorials for each engine: <a href="https://help.aliyun.com/document_detail/96089.html">Create a MySQL account</a>, <a href="https://help.aliyun.com/document_detail/96753.html">Create a PostgreSQL account</a>, <a href="https://help.aliyun.com/document_detail/95810.html">Create a SQL Server account</a>, <a href="https://help.aliyun.com/document_detail/97132.html">Create a MariaDB account</a>.</para>
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
        /// <item><description><b>Normal</b> (default): standard account.</description></item>
        /// <item><description><b>Super</b>: privileged account. You can create at most one privileged account per instance.</description></item>
        /// <item><description><b>Sysadmin</b> (SQL Server instances only): database account with SA permissions. Before you create this account, check whether the instance meets the <a href="https://help.aliyun.com/document_detail/170736.html">prerequisites</a>.</description></item>
        /// <item><description><b>GlobalRO</b> (SQL Server instances only): global read-only account. You can create at most two global read-only accounts per instance. The database engine version of the instance must be SQL Server 2016 or later, and the instance type must be dedicated or general-purpose.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/2845728.html">account password policy</a> for the SQL Server instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The policy is applied.</description></item>
        /// <item><description><b>false</b>: The policy is not applied.<remarks>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to true, you must first <a href="https://help.aliyun.com/document_detail/2848317.html">configure the SQL Server account password policy</a>.</description></item>
        /// <item><description>This parameter does not support SQL Server instances of the <a href="https://help.aliyun.com/document_detail/57184.html">shared instance type</a>, <a href="https://help.aliyun.com/document_detail/145468.html">2008 R2 edition</a>, or <a href="https://help.aliyun.com/document_detail/603466.html">serverless type</a>.</description></item>
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
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/610396.html">DescribeDBInstances</a> to query the instance ID.</para>
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
