// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The description of the database account.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>It cannot start with http:// or https://.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>It must be 0 to 256 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ceshi</para>
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// <para>The database account name.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The name must be unique.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>It can contain lowercase letters, digits, and underscores (_).</description></item>
        /// <item><description>It must start with a lowercase letter and end with a lowercase letter or digit.</description></item>
        /// <item><description>It must be 2 to 64 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The password of the database account.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Special characters include !@#$%^&amp;*()_+-=</description></item>
        /// <item><description>It must be 8 to 32 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123789Ff!</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp108z124a8o7****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

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
