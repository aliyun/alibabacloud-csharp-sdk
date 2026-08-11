// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateOperationTicketRequest : TeaModel {
        /// <summary>
        /// <para>The remarks of the request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Comment</para>
        /// </summary>
        [NameInMap("ApproveComment")]
        [Validation(Required=false)]
        public string ApproveComment { get; set; }

        /// <summary>
        /// <para>The logon name of the asset account for which you want to request O&amp;M access.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("AssetAccountName")]
        [Validation(Required=false)]
        public string AssetAccountName { get; set; }

        /// <summary>
        /// <para>The ID of the asset for which you want to request O&amp;M access.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2758856.html">ListOperationDatabases</a> or <a href="https://help.aliyun.com/document_detail/2758857.html">ListOperationHosts</a> operation to query this parameter.</para>
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
        /// <para>The end time of the validity period for the logon request. Unit: seconds. The value is a UNIX timestamp.</para>
        /// <remarks>
        /// <para>The end time of the validity period must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1679393152</para>
        /// </summary>
        [NameInMap("EffectEndTime")]
        [Validation(Required=false)]
        public long? EffectEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the validity period for the logon request. Unit: seconds. The value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1685600242</para>
        /// </summary>
        [NameInMap("EffectStartTime")]
        [Validation(Required=false)]
        public long? EffectStartTime { get; set; }

        /// <summary>
        /// <para>The instance ID of the bastion host.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query this parameter.</para>
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
        /// <para>The number of logon times allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Only one logon is allowed within the validity period.</description></item>
        /// <item><description><b>false</b>: Unlimited logons are allowed within the validity period.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsOneTimeEffect")]
        [Validation(Required=false)]
        public bool? IsOneTimeEffect { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the protocol for which you want to request O&amp;M access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SSH</description></item>
        /// <item><description>RDP</description></item>
        /// <item><description>MySQL</description></item>
        /// <item><description>PostgreSQL</description></item>
        /// <item><description>Oracle</description></item>
        /// <item><description>SQLServer</description></item>
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
        /// <para>The region ID of the bastion host.</para>
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

    }

}
