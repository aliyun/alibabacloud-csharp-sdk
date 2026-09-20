// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The account name. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>Starts with a lowercase letter and ends with a letter or digit.</description></item>
        /// <item><description>Contains only lowercase letters, digits, or underscores.</description></item>
        /// <item><description>Is 2 to 16 characters in length.</description></item>
        /// <item><description>Cannot be a reserved username such as root or admin.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The password of the database account. The password must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>Contains at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>The supported special characters are <c>!@#$%^&amp;*()_+-=</c>.</description></item>
        /// <item><description>Is 8 to 32 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test*****</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp150tns0sjxs****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
