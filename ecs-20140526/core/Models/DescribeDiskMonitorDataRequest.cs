// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiskMonitorDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the disk to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp1bq5g3dxxo1x4o****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The end time of the data. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. If the value of seconds (ss) is not 00, the end time is automatically set to the beginning of the next minute.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2014-07-23T12:09:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The granularity of the data. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><ol start="60">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="600">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="3600">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// </list>
        /// <para>Default value: 60.</para>
        /// <remarks>
        /// <para>The value of (EndTime – StartTime) / Period must be less than or equal to 400. A maximum of 400 data entries can be returned at a time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start time of the data. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. If the value of seconds (ss) is not 00, the start time is automatically set to the beginning of the next minute.</para>
        /// <remarks>
        /// <para>You can query the monitoring information of up to the last 30 days. The <c>StartTime</c> parameter cannot be more than 30 days earlier than the current time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2014-07-23T12:07:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
