// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The description of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// <para>The account name. The name must be 4 to 16 characters in length and can contain lowercase letters, digits, and underscores (_). It must start with a lowercase letter. The account has read-only permissions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin1</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The account password. The password must be 8 to 32 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include ! @ # $ % ^ &amp; * ( ) _ + - =</para>
        /// <remarks>
        /// <para>For information about how to handle special characters, see <a href="https://help.aliyun.com/document_detail/471568.html">What do I do if a connection fails because the username or password in the connection string contains special characters?</a></para>
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
        /// <para>The type of the account to be created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>db</b>: shard account. This is the default value.</description></item>
        /// <item><description><b>cs</b>: Configserver account.</description></item>
        /// <item><description><b>normal</b>: replica set account.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Currently, only <b>db</b> accounts are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>db</para>
        /// </summary>
        [NameInMap("CharacterType")]
        [Validation(Required=false)]
        public string CharacterType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-uf6e9433e955xxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database to which the account belongs. This is the database where the account is created or on which the account operates. Default value: admin. The name must be 1 to 63 characters in length and cannot contain /, \, ., spaces, double quotation marks (&quot;), or $. The name cannot be local.</para>
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
        /// <para>The list of authorized roles for the account.</para>
        /// </summary>
        [NameInMap("Roles")]
        [Validation(Required=false)]
        public List<CreateAccountRequestRoles> Roles { get; set; }
        public class CreateAccountRequestRoles : TeaModel {
            /// <summary>
            /// <para>The authorized database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <para>The granted permissions.</para>
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
