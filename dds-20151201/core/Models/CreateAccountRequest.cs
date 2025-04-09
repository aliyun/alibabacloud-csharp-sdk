// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database account. The name must be 4 to 16 characters in length. It can contain lowercase letters, digits, and underscores (_). It must start with a lowercase letter. The account is granted read-only permissions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin1</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The password of the database account. The password must be 8 to 32 characters in length. It can contain at least three types of the following characters: uppercase letters, lowercase letters, digits, and special characters. Special characters include ! # $ % ^ &amp; \* ( ) _ + - =</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456!</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>The type of the account that you want to create. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>db</b> (default): shard account (available)</description></item>
        /// <item><description><b>cs</b>: ConfigServer account</description></item>
        /// <item><description><b>normal</b>: replica set account</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can set this parameter only to <b>db</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>db</para>
        /// </summary>
        [NameInMap("CharacterType")]
        [Validation(Required=false)]
        public string CharacterType { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-uf6e9433e955xxxx</para>
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
