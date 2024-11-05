// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AcceptOperationTicketRequest : TeaModel {
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The maximum number of logons allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The number of logons is unlimited. The O\&amp;M engineer can log on to the specified asset for an unlimited number of times during the validity period.</description></item>
        /// <item><description>1: The O\&amp;M engineer can log on to the specified asset only once during the validity period.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can set this parameter only to 0 if you review an O\&amp;M application on a database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EffectCount")]
        [Validation(Required=false)]
        public string EffectCount { get; set; }

        /// <summary>
        /// <para>The end time of the validity period. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1679393152</para>
        /// </summary>
        [NameInMap("EffectEndTime")]
        [Validation(Required=false)]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the validity period. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1685600242</para>
        /// </summary>
        [NameInMap("EffectStartTime")]
        [Validation(Required=false)]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host.</para>
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
        /// <para>The ID of the O\&amp;M application that you want to approve. You can call the ListOperationTickets operation to query the IDs of all O\&amp;M applications that require review.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OperationTicketId")]
        [Validation(Required=false)]
        public string OperationTicketId { get; set; }

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

    }

}
