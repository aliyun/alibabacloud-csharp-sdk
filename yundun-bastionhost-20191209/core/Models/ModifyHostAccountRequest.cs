// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyHostAccountRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the host account whose information you want to modify.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/204372.html">ListHostAccounts</a> operation to query the ID of the host account.</para>
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
        /// <para>The ID of the shared key that is associated with the host.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/462973.html">ListHostShareKeys</a> operation to query the shared key ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HostShareKeyId")]
        [Validation(Required=false)]
        public string HostShareKeyId { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host in which you want to modify the information about the host account.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the ID of the bastion host.</para>
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
        /// <para>The passphrase for the new private key of the host account.</para>
        /// <remarks>
        /// <para> This parameter is valid only if the protocol used by the host is SSH. You do not need to configure this parameter if the protocol used by the host is Remote Desktop Protocol (RDP).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("PassPhrase")]
        [Validation(Required=false)]
        public string PassPhrase { get; set; }

        /// <summary>
        /// <para>The new password of the host account.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The new private key of the host account. Specify a Base64-encoded string.</para>
        /// <remarks>
        /// <para> This parameter takes effect only if the protocol used by the host is SSH. You do not need to configure this parameter if the protocol used by the host is Remote Desktop Protocol (RDP). You can call the <a href="https://help.aliyun.com/document_detail/204391.html">GetHostAccount</a> operation to query the protocol used by the host. You can configure a password and a private key for the host account at the same time. If both a password and a private key are configured for the host account, Bastionhost preferentially uses the private key for logon.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host in which you want to query the details of the host account.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
