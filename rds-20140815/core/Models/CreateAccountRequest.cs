// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The description of the account. The value must be 2 to 256 characters in length. The value can contain letters, digits, underscores (_), and hyphens (-), and must start with a letter.</para>
        /// <remarks>
        /// <para>: The name cannot start with http:// or https://.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Test Account A</para>
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// <para>The name of the database account.</para>
        /// <list type="bullet">
        /// <item><description><para>The name must be unique.</para>
        /// </description></item>
        /// <item><description><para>The name can contain lowercase letters, digits, and underscores (_). For MySQL databases, the name can contain uppercase letters.</para>
        /// </description></item>
        /// <item><description><para>The name must start with a letter and end with a letter or digit.</para>
        /// </description></item>
        /// <item><description><para>For MySQL databases, the name of the privileged account cannot be the same as that of the standard account. For example, if the name of the privileged account is <c>Test1</c>, the name of the standard account cannot be <c>test1</c>.</para>
        /// </description></item>
        /// <item><description><para>The length of the value must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>If the instance runs MySQL 5.7 or MySQL 8.0, the value must be 2 to 32 characters in length.</description></item>
        /// <item><description>If the instance runs MySQL 5.6, the value must be 2 to 16 characters in length.</description></item>
        /// <item><description>If the instance runs SQL Server, the value must be 2 to 64 characters in length.</description></item>
        /// <item><description>If the instance runs PostgreSQL with cloud disks, the value must be 2 to 63 characters in length.</description></item>
        /// <item><description>If the instance runs PostgreSQL with local disks, the value must be 2 to 16 characters in length.</description></item>
        /// <item><description>If the instance runs MariaDB, the value must be 2 to 16 characters in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>For more information about invalid characters, see <a href="https://help.aliyun.com/document_detail/26317.html">Forbidden keywords</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The password of the account.</para>
        /// <list type="bullet">
        /// <item><description><para>The value must be 8 to 32 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</para>
        /// </description></item>
        /// <item><description><para>Special characters include <c>! @ # $ % ^ &amp; * ( ) _ + - =</c></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>The account type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b> (default): standard account.</description></item>
        /// <item><description><b>Super</b>: privileged account.</description></item>
        /// <item><description><b>Sysadmin</b>: system admin account. The account type is available only for ApsaraDB RDS for SQL Server instances.</description></item>
        /// </list>
        /// <para>Before you create a system admin account, check whether the instance meets all prerequisites. For more information, see <a href="https://help.aliyun.com/document_detail/170736.html">Create a system admin account</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a password policy.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is available only for ApsaraDB RDS for SQL Server instances that do not belong to the shared instance family and do not run SQL Server 2008 R2.</para>
        /// </description></item>
        /// <item><description><para>Before you call this operation, you must configure a password policy for the account of your instance. For more information, see <a href="https://help.aliyun.com/document_detail/2848317.html">Configure a password policy for the account of an ApsaraDB RDS for SQL Server instance</a>.</para>
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
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
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
