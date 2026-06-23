// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetHostAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the queried host account.</para>
        /// </summary>
        [NameInMap("HostAccount")]
        [Validation(Required=false)]
        public GetHostAccountResponseBodyHostAccount HostAccount { get; set; }
        public class GetHostAccountResponseBodyHostAccount : TeaModel {
            /// <summary>
            /// <para>Indicates whether a password is set for the host account. Valid values:</para>
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
            /// <para>The ID of the host to which the host account belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>The ID of the shared key for the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HostShareKeyId")]
            [Validation(Required=false)]
            public string HostShareKeyId { get; set; }

            /// <summary>
            /// <para>The name of the shared key for the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("HostShareKeyName")]
            [Validation(Required=false)]
            public string HostShareKeyName { get; set; }

            /// <summary>
            /// <para>The fingerprint information of the private key.</para>
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
            /// <item><description><para><b>Privileged</b>: Privileged account</para>
            /// </description></item>
            /// <item><description><para><b>Normal</b>: Regular account</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only in V3.2.47 and later.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("PrivilegeType")]
            [Validation(Required=false)]
            public string PrivilegeType { get; set; }

            /// <summary>
            /// <para>The protocol name of the host account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>SSH</b></para>
            /// </description></item>
            /// <item><description><para><b>RDP</b></para>
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
            /// <para>The password rotation mode of the account.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Privileged</b>: Use a privileged account to rotate passwords</para>
            /// </description></item>
            /// <item><description><para><b>Self</b>: Do not use a privileged account to rotate passwords</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only in V3.2.47 and later.</para>
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
        /// <para>The unique identifier generated by Alibaba Cloud for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
