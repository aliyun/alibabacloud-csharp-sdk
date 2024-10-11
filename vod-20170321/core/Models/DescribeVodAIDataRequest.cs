// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodAIDataRequest : TeaModel {
        /// <summary>
        /// <para>The type of video AI. If you leave this parameter empty, statistics on video AI of all types are returned. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AIVideoCensor</b>: automated review</description></item>
        /// <item><description><b>AIVideoFPShot</b>: media fingerprinting</description></item>
        /// <item><description><b>AIVideoTag</b>: smart tagging</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AIVideoCensor</para>
        /// </summary>
        [NameInMap("AIType")]
        [Validation(Required=false)]
        public string AIType { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-01T15:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region in which you want to query data. If you leave this parameter empty, data in all regions is returned. Separate multiple regions with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-shanghai</b>: China (Shanghai)</description></item>
        /// <item><description><b>cn-beijing</b>: China (Beijing)</description></item>
        /// <item><description><b>eu-central-1</b>: Germany (Frankfurt)</description></item>
        /// <item><description><b>ap-southeast-1</b>: Singapore</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-01T13:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
