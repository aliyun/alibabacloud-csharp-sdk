// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyHostAccountRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the host account to modify.</para>
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
        /// <para>The new name of the host account. The name can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("HostAccountName")]
        [Validation(Required=false)]
        public string HostAccountName { get; set; }

        /// <summary>
        /// <para>The ID of the shared key for the host.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/462973.html">ListHostShareKeys</a> operation to obtain this ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HostShareKeyId")]
        [Validation(Required=false)]
        public string HostShareKeyId { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host instance where the host account to modify resides.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain the bastion host instance ID.</para>
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
        /// <para>The new passphrase of the private key for the host account.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the protocol of the host account is SSH. If the protocol is RDP, you do not need to configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("PassPhrase")]
        [Validation(Required=false)]
        public string PassPhrase { get; set; }

        /// <summary>
        /// <para>The new password of the host account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The new private key of the host account. The private key is a Base64-encoded string.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the protocol of the host account is SSH. If the protocol is RDP, you do not need to configure this parameter. You can call the <a href="https://help.aliyun.com/document_detail/204391.html">GetHostAccount</a> operation to query the protocol used by the host account. You can configure both a password and a private key for the host account. When connecting to an asset, the bastion host preferentially uses the private key.</para>
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
        /// <para>The privilege type of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Privileged</b>: privileged account.</description></item>
        /// <item><description><b>Normal</b>: standard account.<remarks>
        /// <para>Only supported in V3.2.47 and later.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("PrivilegeType")]
        [Validation(Required=false)]
        public string PrivilegeType { get; set; }

        /// <summary>
        /// <para>The ID of the project to which the host of the host account belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host instance where the host account to query resides.</para>
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
        /// <para>The password rotation mode of the account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Privileged</b>: uses a privileged account to rotate the password.</description></item>
        /// <item><description><b>Self</b>: does not use a privileged account to rotate the password.<remarks>
        /// <para>Only supported in V3.2.47 and later.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Self</para>
        /// </summary>
        [NameInMap("RotationMode")]
        [Validation(Required=false)]
        public string RotationMode { get; set; }

    }

}
