// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the returned host accounts.</para>
        /// </summary>
        [NameInMap("HostAccounts")]
        [Validation(Required=false)]
        public List<ListHostAccountsResponseBodyHostAccounts> HostAccounts { get; set; }
        public class ListHostAccountsResponseBodyHostAccounts : TeaModel {
            /// <summary>
            /// <para>Indicates whether a password is set for the host account.<br> Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: A password is set.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No password is set.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasPassword")]
            [Validation(Required=false)]
            public bool? HasPassword { get; set; }

            /// <summary>
            /// <para>The ID of the host account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostAccountId")]
            [Validation(Required=false)]
            public string HostAccountId { get; set; }

            /// <summary>
            /// <para>The name of the host account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("HostAccountName")]
            [Validation(Required=false)]
            public string HostAccountName { get; set; }

            /// <summary>
            /// <para>The ID of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>The ID of the shared key of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostShareKeyId")]
            [Validation(Required=false)]
            public string HostShareKeyId { get; set; }

            /// <summary>
            /// <para>The name of the shared key of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("HostShareKeyName")]
            [Validation(Required=false)]
            public string HostShareKeyName { get; set; }

            /// <summary>
            /// <para>The fingerprint of the private key of the host account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe:ca:37:42:30:00:9d:95:e6:73:e5:b0:32:0a:<b>:</b></para>
            /// </summary>
            [NameInMap("PrivateKeyFingerprint")]
            [Validation(Required=false)]
            public string PrivateKeyFingerprint { get; set; }

            /// <summary>
            /// <para>The permission type of the account.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Privileged</b>: privileged account</para>
            /// </description></item>
            /// <item><description><para><b>Normal</b>: regular account</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only for Bastionhost instances of V3.2.47 or later.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("PrivilegeType")]
            [Validation(Required=false)]
            public string PrivilegeType { get; set; }

            /// <summary>
            /// <para>The protocol of the host account.<br> Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SSH</para>
            /// </description></item>
            /// <item><description><para>RDP</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SSH</para>
            /// </summary>
            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

            /// <summary>
            /// <para>The password change mode of the account.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Privileged</b>: The password is changed using a privileged account.</para>
            /// </description></item>
            /// <item><description><para><b>Self</b>: The password is changed without using a privileged account.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only for Bastionhost instances of V3.2.47 or later.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Privileged</para>
            /// </summary>
            [NameInMap("RotationMode")]
            [Validation(Required=false)]
            public string RotationMode { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned host accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
