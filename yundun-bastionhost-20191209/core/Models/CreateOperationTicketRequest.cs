// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateOperationTicketRequest : TeaModel {
        /// <summary>
        /// <para>The comments on the ticket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Comment</para>
        /// </summary>
        [NameInMap("ApproveComment")]
        [Validation(Required=false)]
        public string ApproveComment { get; set; }

        /// <summary>
        /// <para>The logon name of the asset account for the O\&amp;M request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("AssetAccountName")]
        [Validation(Required=false)]
        public string AssetAccountName { get; set; }

        /// <summary>
        /// <para>The ID of the asset for which to request O\&amp;M.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2758856.html">ListOperationDatabases</a> and <a href="https://help.aliyun.com/document_detail/2758857.html">ListOperationHosts</a> operations to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        /// <summary>
        /// <para>The end time of the validity period for the logon request. This value is a UNIX timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1679393152</para>
        /// </summary>
        [NameInMap("EffectEndTime")]
        [Validation(Required=false)]
        public long? EffectEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the validity period for the logon request. This value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1685600242</para>
        /// </summary>
        [NameInMap("EffectStartTime")]
        [Validation(Required=false)]
        public long? EffectStartTime { get; set; }

        /// <summary>
        /// <para>The ID of the Bastionhost instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain this parameter.</para>
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
        /// <para>Specifies whether the ticket is valid for a single logon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The ticket is valid for a single logon.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The ticket is valid for multiple logons within the validity period.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsOneTimeEffect")]
        [Validation(Required=false)]
        public bool? IsOneTimeEffect { get; set; }

        /// <summary>
        /// <para>The name of the protocol for the O\&amp;M request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SSH</para>
        /// </description></item>
        /// <item><description><para>RDP</para>
        /// </description></item>
        /// <item><description><para>MySQL</para>
        /// </description></item>
        /// <item><description><para>PostgreSQL</para>
        /// </description></item>
        /// <item><description><para>Oracle</para>
        /// </description></item>
        /// <item><description><para>SQLServer</para>
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
        /// <para>The region ID of the Bastionhost instance.</para>
        /// <remarks>
        /// <para>For more information about regions and zones, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
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
