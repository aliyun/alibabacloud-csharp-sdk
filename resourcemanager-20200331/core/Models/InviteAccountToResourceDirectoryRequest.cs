// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class InviteAccountToResourceDirectoryRequest : TeaModel {
        /// <summary>
        /// <para>The remarks.</para>
        /// <para>Maximum length: 1024 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Welcome to join</para>
        /// </summary>
        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<InviteAccountToResourceDirectoryRequestTag> Tag { get; set; }
        public class InviteAccountToResourceDirectoryRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID or logon email address of the account that is invited.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:someone@example.com">someone@example.com</a></para>
        /// </summary>
        [NameInMap("TargetEntity")]
        [Validation(Required=false)]
        public string TargetEntity { get; set; }

        /// <summary>
        /// <para>The type of the account that is invited. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Account: account ID.</description></item>
        /// <item><description>Email: logon email address of the account.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Email</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
