// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeSmbAclResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the ACL feature.</para>
        /// </summary>
        [NameInMap("Acl")]
        [Validation(Required=false)]
        public DescribeSmbAclResponseBodyAcl Acl { get; set; }
        public class DescribeSmbAclResponseBodyAcl : TeaModel {
            /// <summary>
            /// <para>Indicates whether the file system allows anonymous access. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The file system allows anonymous access.</description></item>
            /// <item><description>false: The file system does not allow anonymous access.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAnonymousAccess")]
            [Validation(Required=false)]
            public bool? EnableAnonymousAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether the ACL feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The ACL feature is enabled.</description></item>
            /// <item><description>false: The ACL feature is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Indicates whether encryption in transit is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Encryption in transit is enabled.</description></item>
            /// <item><description>false: Encryption in transit is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EncryptData")]
            [Validation(Required=false)]
            public bool? EncryptData { get; set; }

            /// <summary>
            /// <para>The home directory of each user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home</para>
            /// </summary>
            [NameInMap("HomeDirPath")]
            [Validation(Required=false)]
            public string HomeDirPath { get; set; }

            /// <summary>
            /// <para>Indicates whether the file system denies access from non-encrypted clients. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The file system denies access from non-encrypted clients.</description></item>
            /// <item><description>false: The file system allows access from non-encrypted clients.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RejectUnencryptedAccess")]
            [Validation(Required=false)]
            public bool? RejectUnencryptedAccess { get; set; }

            /// <summary>
            /// <para>The ID of a super admin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S-1-0-0</para>
            /// </summary>
            [NameInMap("SuperAdminSid")]
            [Validation(Required=false)]
            public string SuperAdminSid { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98696EF0-1607-4E9D-B01D-F20930B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
