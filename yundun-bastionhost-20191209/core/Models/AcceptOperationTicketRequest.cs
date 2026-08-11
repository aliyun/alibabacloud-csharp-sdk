// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AcceptOperationTicketRequest : TeaModel {
        /// <summary>
        /// <para>The approval remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The limit on the number of logons allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: No limit on the number of logons. The O&amp;M engineer can log on an unlimited number of times during the validity period.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: The O&amp;M engineer can log on only once during the validity period.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The logon limit for database asset O&amp;M approval can only be set to unlimited.</description></item>
        /// <item><description>If an empty character string is passed, the default value is unlimited.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EffectCount")]
        [Validation(Required=false)]
        public string EffectCount { get; set; }

        /// <summary>
        /// <para>The end time of the validity period for logon (in seconds, UNIX timestamp format).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1679393152</para>
        /// </summary>
        [NameInMap("EffectEndTime")]
        [Validation(Required=false)]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the validity period for logon (in seconds, UNIX timestamp format).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1685600242</para>
        /// </summary>
        [NameInMap("EffectStartTime")]
        [Validation(Required=false)]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host instance.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain this parameter.</para>
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
        /// <para>The ID of the O&amp;M request to approve.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2584313.html">ListOperationTickets</a> operation to query all OperationTicketId values that require approval.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OperationTicketId")]
        [Validation(Required=false)]
        public string OperationTicketId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

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
