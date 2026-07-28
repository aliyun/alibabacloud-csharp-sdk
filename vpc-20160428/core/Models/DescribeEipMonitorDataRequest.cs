// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipMonitorDataRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the EIP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-2zeerraiwb7uj6idcfv****</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>The end time of the data to retrieve. Specify the time in UTC in the ISO 8601 standard format: <c>YYYY-MM-DDThh:mm:ssZ</c>. For example, <c>2013-01-10T12:00:00Z</c> represents 20:00:00 (UTC+8) on January 10, 2013.</para>
        /// <para>If the specified time is not on the minute, the end time is automatically rounded up to the next minute.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-01-05T03:05:10Z</para>
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
        /// <para>The duration of each monitoring data entry. Unit: seconds. Valid values: <b>60</b> (default), <b>300</b>, <b>900</b>, or <b>3600</b>.</para>
        /// <list type="bullet">
        /// <item><description>If (<b>EndTime</b> – <b>StartTime</b>) / <b>Period</b> is less than or equal to 400, all monitoring data from the start time to the end time is returned.</description></item>
        /// <item><description>If (<b>EndTime</b> – <b>StartTime</b>) / <b>Period</b> is greater than 400, monitoring data cannot be returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The region ID of the EIP.
        /// You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start time of the data to retrieve. Specify the time in UTC in the ISO 8601 standard format: <c>YYYY-MM-DDThh:mm:ssZ</c>. For example, <c>2013-01-10T12:00:00Z</c> represents 20:00:00 (UTC+8) on January 10, 2013.</para>
        /// <para>If the specified time is not on the minute, the start time is automatically rounded up to the next minute.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-01-05T01:05:05Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
