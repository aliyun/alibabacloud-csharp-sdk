// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeSmbAclResponseBody : TeaModel {
        /// <summary>
        /// <para>The ACL information.</para>
        /// </summary>
        [NameInMap("Acl")]
        [Validation(Required=false)]
        public DescribeSmbAclResponseBodyAcl Acl { get; set; }
        public class DescribeSmbAclResponseBodyAcl : TeaModel {
            /// <summary>
            /// <para>Indicates whether anonymous access is allowed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Anonymous access is allowed.</para>
            /// </description></item>
            /// <item><description><para>false: Anonymous access is not allowed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAnonymousAccess")]
            [Validation(Required=false)]
            public bool? EnableAnonymousAccess { get; set; }

            /// <summary>
            /// <para>Indicates whether the SMB AD ACL feature is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para>true: The SMB AD ACL feature is enabled.</para>
            /// </description></item>
            /// <item><description><para>false: The SMB AD ACL feature is not enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Indicates whether encryption in transit is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Encryption in transit is enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Encryption in transit is not enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EncryptData")]
            [Validation(Required=false)]
            public bool? EncryptData { get; set; }

            /// <summary>
            /// <para>The home directory path for each user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home</para>
            /// </summary>
            [NameInMap("HomeDirPath")]
            [Validation(Required=false)]
            public string HomeDirPath { get; set; }

            /// <summary>
            /// <para>Indicates whether unencrypted clients are rejected.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Unencrypted clients are rejected.</para>
            /// </description></item>
            /// <item><description><para>false: Unencrypted clients are not rejected.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RejectUnencryptedAccess")]
            [Validation(Required=false)]
            public bool? RejectUnencryptedAccess { get; set; }

            /// <summary>
            /// <para>The ID of the superuser.</para>
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
