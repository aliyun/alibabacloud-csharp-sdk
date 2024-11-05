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

        [NameInMap("LoginAttribute")]
        [Validation(Required=false)]
        public string LoginAttribute { get; set; }

        [NameInMap("OperationMode")]
        [Validation(Required=false)]
        public string OperationMode { get; set; }

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

        [NameInMap("SsoClient")]
        [Validation(Required=false)]
        public string SsoClient { get; set; }

    }

}
