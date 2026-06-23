// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateHostAccountRequest : TeaModel {
        /// <summary>
        /// <para>The name of the new host account. The name can be up to 128 characters long.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>accountname</para>
        /// </summary>
        [NameInMap("HostAccountName")]
        [Validation(Required=false)]
        public string HostAccountName { get; set; }

        /// <summary>
        /// <para>The ID of the host for which you want to create a host account.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/200665.html">ListHosts</a> operation to obtain the host ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
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
        /// <para>The ID of the Bastionhost instance where you want to create the host account.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain the instance ID.</para>
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
        /// <para>The passphrase for the private key of the new host account.</para>
        /// <remarks>
        /// <para>You can set this parameter only when ProtocolName is set to SSH. You do not need to set this parameter if ProtocolName is set to RDP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("PassPhrase")]
        [Validation(Required=false)]
        public string PassPhrase { get; set; }

        /// <summary>
        /// <para>The password of the new host account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The private key of the new host account. The value is a Base64-encoded string.</para>
        /// <remarks>
        /// <para>This parameter is used only when ProtocolName is set to SSH. You do not need to set this parameter if ProtocolName is set to RDP. You can set both a password and a private key for the host account. When connecting to the asset, Bastionhost prioritizes the private key for the connection.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LS0tLS1******RCBSU0tLQ==</para>
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// <para>The permission type of the account. If you do not set this parameter, the default value is Normal.</para>
        /// <list type="bullet">
        /// <item><description><para><b>Privileged</b>: privileged account</para>
        /// </description></item>
        /// <item><description><para><b>Normal</b>: normal account</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only in Bastionhost V3.2.47 and later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("PrivilegeType")]
        [Validation(Required=false)]
        public string PrivilegeType { get; set; }

        /// <summary>
        /// <para>The protocol of the new host account. <br>Valid values:<br></para>
        /// <list type="bullet">
        /// <item><description><para>SSH</para>
        /// </description></item>
        /// <item><description><para>RDP</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SSH</para>
        /// </summary>
        [NameInMap("ProtocolName")]
        [Validation(Required=false)]
        public string ProtocolName { get; set; }

        /// <summary>
        /// <para>The region ID of the Bastionhost instance where you want to create the host account.</para>
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

        /// <summary>
        /// <para>The password change mode for the account. If you do not set this parameter, the default value is Self.</para>
        /// <list type="bullet">
        /// <item><description><para><b>Privileged</b>: Use a privileged account to change the password.</para>
        /// </description></item>
        /// <item><description><para><b>Self</b>: Do not use a privileged account to change the password.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only in Bastionhost V3.2.47 and later.</para>
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
