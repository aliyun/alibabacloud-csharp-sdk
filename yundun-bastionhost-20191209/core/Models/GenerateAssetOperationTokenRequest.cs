// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GenerateAssetOperationTokenRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the asset account for which you want to apply for an O&amp;M token.</para>
        /// <remarks>
        /// <para>You must specify at least one of AssetAccountId and AssetAccountName. If both are specified, AssetAccountId takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AssetAccountId")]
        [Validation(Required=false)]
        public string AssetAccountId { get; set; }

        /// <summary>
        /// <para>The name of the host account. If the account is a custom account, specify the actual account name.</para>
        /// <remarks>
        /// <para>If both AssetAccountId and AssetAccountName are specified, AssetAccountId takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("AssetAccountName")]
        [Validation(Required=false)]
        public string AssetAccountName { get; set; }

        /// <summary>
        /// <para>The Base64-encoded password. This parameter is required when you apply for an O&amp;M token for a custom account.</para>
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
        /// <item><description><b>SSH</b></description></item>
        /// <item><description><b>RDP</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when you apply for an O&amp;M token for a custom account.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SSH</para>
        /// </summary>
        [NameInMap("AssetAccountProtocolName")]
        [Validation(Required=false)]
        public string AssetAccountProtocolName { get; set; }

        /// <summary>
        /// <para>The ID of the asset for which you want to apply for an O&amp;M token.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        /// <summary>
        /// <para>The Asset Type for which you want to apply for a token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Host</b>: host</description></item>
        /// <item><description><b>Database</b>: database</description></item>
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
        /// <para>The name of the database. This parameter is required when OperationMode is set to Sso, AssetAccountProtocolName is set to PostgreSQL or Oracle, and the account is a custom account.</para>
        /// <remarks>
        /// <para>This parameter is supported only in Bastionhost V3.2.44 and later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>orcl</para>
        /// </summary>
        [NameInMap("DatabaseSchema")]
        [Validation(Required=false)]
        public string DatabaseSchema { get; set; }

        /// <summary>
        /// <para>The instance ID of the Bastionhost instance for which you want to apply for an O&amp;M token.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain the value of this parameter.</para>
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
        /// <para>The logon attribute. This parameter is required when OperationMode is set to Sso and the account is a custom Oracle account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SERVICENAME</b></description></item>
        /// <item><description><b>SID</b><remarks>
        /// <para>This parameter is supported only in Bastionhost V3.2.44 and later.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <para>The O&amp;M logon method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>WebToken</b>: obtain an O&amp;M token</description></item>
        /// <item><description><b>Sso</b>: log on by using a local client<remarks>
        /// <para>This parameter is supported only in Bastionhost V3.2.44 and later. If this parameter is left empty, the default value WebToken is used.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Sso</para>
        /// </summary>
        [NameInMap("OperationMode")]
        [Validation(Required=false)]
        public string OperationMode { get; set; }

        /// <summary>
        /// <para>The logon note. This parameter is required when the administrator enables the logon note feature in the control policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("OperationNote")]
        [Validation(Required=false)]
        public string OperationNote { get; set; }

        /// <summary>
        /// <para>The region ID of the Bastionhost instance.</para>
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
        /// <para>The type of the local client to be opened for O&amp;M operations on Linux assets. This parameter is required when OperationMode is set to Sso and the asset protocol is SSH. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ssh</b>: open an SSH client to perform O&amp;M operations with SSH permissions</description></item>
        /// <item><description><b>sftp</b>: open an SFTP client to perform O&amp;M operations with SFTP permissions<remarks>
        /// <para>This parameter is supported only in Bastionhost V3.2.44 and later.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ssh</para>
        /// </summary>
        [NameInMap("SsoClient")]
        [Validation(Required=false)]
        public string SsoClient { get; set; }

    }

}
