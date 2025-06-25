// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GenerateAssetOperationTokenRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account whose assets the O\&amp;M token takes effect.</para>
        /// <remarks>
        /// <para> You must specify at least one of the following parameters: AssetAccountId and AssetAccountName. If you specify both parameters, AssetAccountId takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AssetAccountId")]
        [Validation(Required=false)]
        public string AssetAccountId { get; set; }

        /// <summary>
        /// <para>The name of the host account. If you use a custom account, enter a real account name.</para>
        /// <remarks>
        /// <para> When both AssetAccountId and AssetAccountName are specified, AssetAccountId takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("AssetAccountName")]
        [Validation(Required=false)]
        public string AssetAccountName { get; set; }

        /// <summary>
        /// <para>The Base64-encoded password. This parameter is required if you want to apply for an O\&amp;M token for a custom account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dGVzdHBhc3N3b3Jk</para>
        /// </summary>
        [NameInMap("AssetAccountPassword")]
        [Validation(Required=false)]
        public string AssetAccountPassword { get; set; }

        /// <summary>
        /// <para>The name of the protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SSH</description></item>
        /// <item><description>RDP</description></item>
        /// <item><description>Oracle</description></item>
        /// <item><description>PostgreSQL</description></item>
        /// <item><description>MySQL</description></item>
        /// <item><description>SQLServer</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SSH</para>
        /// </summary>
        [NameInMap("AssetAccountProtocolName")]
        [Validation(Required=false)]
        public string AssetAccountProtocolName { get; set; }

        /// <summary>
        /// <para>The ID of the asset for which you want to apply for an O\&amp;M token.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        /// <summary>
        /// <para>The type of the asset for which you want to apply for an O\&amp;M token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Host</b></description></item>
        /// <item><description><b>Database</b></description></item>
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
        /// <para>The name of the database. If you set OperationMode to Sso and AssetAccountProtocolName to PostgreSQL or Oracle and you select Custom Account for the Database Account parameter, you must specify this parameter.</para>
        /// <remarks>
        /// <para>This parameter is available only for bastion hosts that run V3.2.44 or later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>orcl</para>
        /// </summary>
        [NameInMap("DatabaseSchema")]
        [Validation(Required=false)]
        public string DatabaseSchema { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host for which you want to apply an O\&amp;M token.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the ID of the bastion host.</para>
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
        /// <para>The logon attribute. If you set OperationMode to Sso and AssetAccountProtocolName to Oracle, you must specify this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SERVICENAME</b></description></item>
        /// <item><description><b>SID</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available only for Bastionhost V3.2.44 and later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SID</para>
        /// </summary>
        [NameInMap("LoginAttribute")]
        [Validation(Required=false)]
        public string LoginAttribute { get; set; }

        /// <summary>
        /// <para>The O\&amp;M logon method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>WebToken</b>: O\&amp;M token-based logon.</description></item>
        /// <item><description><b>Sso</b>: local client-based logon.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available only for Bastionhost V3.2.44 and later. If you do not specify this parameter, the default value WebToken is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Sso</para>
        /// </summary>
        [NameInMap("OperationMode")]
        [Validation(Required=false)]
        public string OperationMode { get; set; }

        /// <summary>
        /// <para>The logon remarks. This parameter is required if an administrator enables the feature of logon remarks on the Control Policies page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("OperationNote")]
        [Validation(Required=false)]
        public string OperationNote { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para> For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of the local client that you want to perform O\&amp;M operations on Linux assets. If you set OperationMode to Sso and AssetAccountProtocolName to SSH, you must specify this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ssh</b>: Perform O\&amp;M operations on Linux assets by connecting to a bastion host from an SSH client.</description></item>
        /// <item><description><b>sftp</b>: Perform O\&amp;M operations on Linux assets by connecting to a bastion host from a Secure File Transfer Protocol (SFTP) client.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available only for Bastionhost V3.2.44 and later.</para>
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
