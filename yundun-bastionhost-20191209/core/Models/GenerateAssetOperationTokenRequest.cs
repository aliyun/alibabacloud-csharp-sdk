// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GenerateAssetOperationTokenRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the asset account.</para>
        /// <remarks>
        /// <para>You must specify at least one of <c>AssetAccountId</c> and <c>AssetAccountName</c>. If you specify both parameters, <c>AssetAccountId</c> is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AssetAccountId")]
        [Validation(Required=false)]
        public string AssetAccountId { get; set; }

        /// <summary>
        /// <para>The name of the asset account. If this parameter specifies a custom account, you must enter the actual account name.</para>
        /// <remarks>
        /// <para>If you specify both <c>AssetAccountId</c> and <c>AssetAccountName</c>, <c>AssetAccountId</c> is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("AssetAccountName")]
        [Validation(Required=false)]
        public string AssetAccountName { get; set; }

        /// <summary>
        /// <para>The password that is encoded in Base64. This parameter is required if you want to generate an O\&amp;M token for a custom account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dGVzdHBhc3N3b3Jk</para>
        /// </summary>
        [NameInMap("AssetAccountPassword")]
        [Validation(Required=false)]
        public string AssetAccountPassword { get; set; }

        /// <summary>
        /// <para>The protocol that is used to connect to the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>SSH</b></para>
        /// </description></item>
        /// <item><description><para><b>RDP</b></para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b></para>
        /// </description></item>
        /// <item><description><para><b>PostgreSQL</b></para>
        /// </description></item>
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>SQLServer</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if you want to generate an O\&amp;M token for a custom account.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SSH</para>
        /// </summary>
        [NameInMap("AssetAccountProtocolName")]
        [Validation(Required=false)]
        public string AssetAccountProtocolName { get; set; }

        /// <summary>
        /// <para>The ID of the asset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        /// <summary>
        /// <para>The type of the asset for which you want to generate an O\&amp;M token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Host</b></para>
        /// </description></item>
        /// <item><description><para><b>Database</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Host</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// <para>The name of the database. This parameter is required for a custom account if you set OperationMode to Sso and AssetAccountProtocolName to PostgreSQL or Oracle.</para>
        /// <remarks>
        /// <para>This parameter is supported only by bastion hosts of V3.2.44 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>orcl</para>
        /// </summary>
        [NameInMap("DatabaseSchema")]
        [Validation(Required=false)]
        public string DatabaseSchema { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the ID.</para>
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
        /// <para>The logon attribute. This parameter is required if you set OperationMode to Sso and use a custom Oracle account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>SERVICENAME</b></para>
        /// </description></item>
        /// <item><description><para><b>SID</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only by bastion hosts of V3.2.44 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SID</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("LoginAttribute")]
        [Validation(Required=false)]
        public string LoginAttribute { get; set; }

        /// <summary>
        /// <para>The O\&amp;M mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>WebToken</b>: generates an O\&amp;M token.</para>
        /// </description></item>
        /// <item><description><para><b>Sso</b>: logs on to the client.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only by bastion hosts of V3.2.44 or later. If you do not specify this parameter, WebToken is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Sso</para>
        /// </summary>
        [NameInMap("OperationMode")]
        [Validation(Required=false)]
        public string OperationMode { get; set; }

        /// <summary>
        /// <para>The remarks for the logon. This parameter is required if your administrator enables logon remarks in the control policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("OperationNote")]
        [Validation(Required=false)]
        public string OperationNote { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host instance.</para>
        /// <remarks>
        /// <para>For more information about region IDs, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of the client that you want to use for O\&amp;M on a Linux asset. This parameter is required if you set OperationMode to Sso and the asset protocol to SSH. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ssh</b>: opens a client that supports the SSH protocol to perform O\&amp;M with SSH permissions.</para>
        /// </description></item>
        /// <item><description><para><b>sftp</b>: opens a client that supports the SFTP protocol to perform O\&amp;M with SFTP permissions.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only by bastion hosts of V3.2.44 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ssh</para>
        /// </summary>
        [NameInMap("SsoClient")]
        [Validation(Required=false)]
        public string SsoClient { get; set; }

    }

}
