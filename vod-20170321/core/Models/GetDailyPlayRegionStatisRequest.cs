// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetDailyPlayRegionStatisRequest : TeaModel {
        /// <summary>
        /// <para>The playback date, in days. Format: yyyy-MM-dd.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only daily queries are supported.</description></item>
        /// <item><description>Only data within the past year can be queried.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-20</para>
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <para>The media asset region ID. Specify this parameter to perform a filtered query for the playback data of all audio and video files in a specified service region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-beijing: China (Beijing)</description></item>
        /// <item><description>cn-shanghai: China (Shanghai)</description></item>
        /// <item><description>cn-shenzhen: China (Shenzhen)</description></item>
        /// <item><description>ap-northeast-1: Japan (Tokyo)</description></item>
        /// <item><description>ap-southeast-1: Singapore</description></item>
        /// <item><description>ap-southeast-5: Indonesia (Jakarta)</description></item>
        /// <item><description>eu-central-1: Germany (Frankfurt)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("MediaRegion")]
        [Validation(Required=false)]
        public string MediaRegion { get; set; }

    }

}
