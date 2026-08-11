// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateHostAccountRequest : TeaModel {
        /// <summary>
        /// <para>The name of the host account to create. The name can be up to 128 characters in length.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/200665.html">ListHosts</a> operation to query this parameter.</para>
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
        /// <para>The ID of the Bastionhost instance where the host for which you want to create a host account resides.</para>
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
        /// <para>The passphrase of the private key for the host account to create.</para>
        /// <remarks>
        /// <para>You can configure this parameter when ProtocolName is set to SSH. You do not need to configure this parameter when ProtocolName is set to RDP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("PassPhrase")]
        [Validation(Required=false)]
        public string PassPhrase { get; set; }

        /// <summary>
        /// <para>The password of the host account to create.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The private key of the host account to create. The value is a Base64-encoded string.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when ProtocolName is set to SSH. You do not need to configure this parameter when ProtocolName is set to RDP. You can configure both a password and a private key for the host account. When connecting to an asset, Bastionhost preferentially uses the private key.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LS0tLS1******RCBSU0tLQ==</para>
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// <para>The privilege type of the account. Default value: Normal.</para>
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
        /// <para>The project ID.</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The protocol name of the host account to create.
        /// <br>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SSH</description></item>
        /// <item><description>RDP</description></item>
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
        /// <para>The region ID of the Bastionhost instance where the host for which you want to create a host account resides.</para>
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
        /// <para>The password rotation mode of the account. Default value: Self.</para>
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
