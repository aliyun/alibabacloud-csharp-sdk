// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeUsageOverallDataRequest : TeaModel {
        /// <summary>
        /// <para>The app ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2hz****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615910399</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615824000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <para>The metric types to query. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TOTAL_CALL_DURATION</b>: total duration.</description></item>
        /// <item><description><b>VIDEO_CALL_DURATION</b>: video communication duration.</description></item>
        /// <item><description><b>AUDIO_CALL_DURATION</b>: audio communication duration.</description></item>
        /// <item><description><b>CALL_CHANNEL_COUNT</b>: communication channel count.</description></item>
        /// <item><description><b>HIGHLY_CONCURRENT_CHANNEL_COUNT</b>: highly concurrent communication channel count.</description></item>
        /// <item><description><b>CHANNEL_CONCURRENT_PEAK</b>: peak concurrent channel count.</description></item>
        /// <item><description><b>ONLINE_USER_PEAK</b>: peak online user count.</description></item>
        /// <item><description><b>TOTAL_CALL_USER</b>: total call users.</description></item>
        /// <item><description><b>TOTAL_INOUT_NUM</b>: total inbound and outbound visits.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ONLINE_USER_PEAK</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string Types { get; set; }

    }

}
