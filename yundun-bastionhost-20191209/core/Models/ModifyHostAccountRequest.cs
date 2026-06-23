// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyHostAccountRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the ID of the host account to be modified.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/204372.html">ListHostAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HostAccountId")]
        [Validation(Required=false)]
        public string HostAccountId { get; set; }

        /// <summary>
        /// <para>Specifies the modified host account name, which can contain up to 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("HostAccountName")]
        [Validation(Required=false)]
        public string HostAccountName { get; set; }

        /// <summary>
        /// <para>The host shared key ID.</para>
        /// <remarks>
        /// <para>You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/462973.html">ListHostShareKeys</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HostShareKeyId")]
        [Validation(Required=false)]
        public string HostShareKeyId { get; set; }

        /// <summary>
        /// <para>Specifies the ID of the Bastionhost instance where the host account to be modified resides.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the Bastionhost instance ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies the modified security token of the host account\&quot;s private key.</para>
        /// <remarks>
        /// <para>This parameter takes effect when the host account protocol is SSH. This parameter is not required when the host account protocol is RDP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("PassPhrase")]
        [Validation(Required=false)]
        public string PassPhrase { get; set; }

        /// <summary>
        /// <para>Specifies the modified password of the host account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies the modified private key of the host account, which is a Base64-encoded string.</para>
        /// <remarks>
        /// <para>This parameter takes effect when the host account protocol is SSH. This parameter is not required when the host account protocol is RDP. You can call the <a href="https://help.aliyun.com/document_detail/204391.html">GetHostAccount</a> operation to query the protocol used by the host account. You can configure both a password and a private key for a host account. When connecting to an asset, Bastionhost preferentially uses the private key for connection.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN RSA PRIVATE KEY-----
        /// ......
        /// -----END RSA PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// <para>Account permission type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Privileged</b>: privileged account</para>
        /// </description></item>
        /// <item><description><para><b>Normal</b>: regular account</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only in V3.2.47 and later versions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("PrivilegeType")]
        [Validation(Required=false)]
        public string PrivilegeType { get; set; }

        /// <summary>
        /// <para>Specifies the region ID of the Bastionhost instance where the host account to be queried resides.</para>
        /// <remarks>
        /// <para>For the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Account password rotation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Privileged</b>: Use a privileged account to change the password</para>
        /// </description></item>
        /// <item><description><para><b>Self</b>: Do not use a privileged account to change the password</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only in V3.2.47 and later versions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Self</para>
        /// </summary>
        [NameInMap("RotationMode")]
        [Validation(Required=false)]
        public string RotationMode { get; set; }

    }

}
