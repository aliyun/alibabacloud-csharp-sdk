// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipMonitorDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EIP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-2zeerraiwb7uj6idcfv****</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The time must be in UTC. Specify the time in the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. For example, <c>2013-01-10T12:00:00Z</c> specifies 20:00:00 (UTC+8) on January 10, 2013.</para>
        /// <para>If the value of seconds (ss) is not 00, the end time is automatically rounded up to the next minute.</para>
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
        /// <para>The duration of each monitoring data entry. Unit: seconds. Valid values: <b>60</b> (default), <b>300</b>, <b>900</b>, and <b>3600</b>.</para>
        /// <list type="bullet">
        /// <item><description>If the value of <b>(EndTime</b> - <b>StartTime</b>)/<b>Period</b> is greater than 200, a maximum of 200 monitoring data entries are returned at a time.</description></item>
        /// <item><description>If the value of (<b>EndTime</b> - <b>StartTime</b>)/<b>Period</b> is less than or equal to 200, only the monitoring data collected between the start time and end time is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the EIP belongs. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The beginning of the time range to query. The time must be in UTC. Specify the time in the ISO 8601 standard in <c>YYYY-MM-DDThh:mm:ssZ</c> format. For example, <c>2013-01-10T12:00:00Z</c> specifies 20:00:00 (UTC+8) on January 10, 2013.</para>
        /// <para>If the value of seconds (ss) is not 00, the start time is automatically rounded up to the next minute.</para>
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
