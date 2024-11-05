// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListOperationHostAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The host accounts returned.</para>
        /// </summary>
        [NameInMap("HostAccounts")]
        [Validation(Required=false)]
        public List<ListOperationHostAccountsResponseBodyHostAccounts> HostAccounts { get; set; }
        public class ListOperationHostAccountsResponseBodyHostAccounts : TeaModel {
            /// <summary>
            /// <para>Indicates whether a password is configured for the host account.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasPassword")]
            [Validation(Required=false)]
            public bool? HasPassword { get; set; }

            /// <summary>
            /// <para>The host account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostAccountId")]
            [Validation(Required=false)]
            public string HostAccountId { get; set; }

            /// <summary>
            /// <para>The host account name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("HostAccountName")]
            [Validation(Required=false)]
            public string HostAccountName { get; set; }

            /// <summary>
            /// <para>The host ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>１</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>The ID of the shared key that is associated with the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HostShareKeyId")]
            [Validation(Required=false)]
            public string HostShareKeyId { get; set; }

            /// <summary>
            /// <para>The fingerprint of the private key for the host account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe:ca:37:42:30:00:9d:95:e6:73:e5:b0:32:0a:<b>:</b></para>
            /// </summary>
            [NameInMap("PrivateKeyFingerprint")]
            [Validation(Required=false)]
            public string PrivateKeyFingerprint { get; set; }

            /// <summary>
            /// <para>The protocol that is used by the host account.</para>
            /// <list type="bullet">
            /// <item><description><b>SSH</b></description></item>
            /// <item><description><b>RDP</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SSH</para>
            /// </summary>
            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

            /// <summary>
            /// <para>Indicates whether the Secure File Transfer Protocol (SFTP) channels or the SSH channels are enabled for the host account that uses the SSH protocol.</para>
            /// </summary>
            [NameInMap("SSHConfig")]
            [Validation(Required=false)]
            public ListOperationHostAccountsResponseBodyHostAccountsSSHConfig SSHConfig { get; set; }
            public class ListOperationHostAccountsResponseBodyHostAccountsSSHConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether SFTP channels are enabled for the account.</para>
                /// </summary>
                [NameInMap("EnableSFTPChannel")]
                [Validation(Required=false)]
                public bool? EnableSFTPChannel { get; set; }

                /// <summary>
                /// <para>Indicates whether SSH channels are enabled for the account.</para>
                /// </summary>
                [NameInMap("EnableSSHChannel")]
                [Validation(Required=false)]
                public bool? EnableSSHChannel { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of host accounts returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
