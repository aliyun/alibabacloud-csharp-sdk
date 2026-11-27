// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeQualityOverallDataRequest : TeaModel {
        /// <summary>
        /// <para>APP ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0rbd****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The End Time of the query, represented as a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615910399</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>The Start Time of the query, represented as a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615824000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <para>The Metric Types to query, separated by commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>JOIN_CHANNEL_SUC_RATE</b>: Channel Join Success Rate.</description></item>
        /// <item><description><b>JOIN_CHANNEL_SUC_FIVE_SEC_RATE</b>: Five-second Channel Join Success Rate.</description></item>
        /// <item><description><b>VIDEO_FIRST_PIC_DUR</b>: Time to First Video Frame.</description></item>
        /// <item><description><b>AUDIO_STUCK_RATE</b>: Audio Lag Rate.</description></item>
        /// <item><description><b>VIDEO_STUCK_RATE</b>: Video Lag Rate.</description></item>
        /// <item><description><b>AUDIO_DELAY</b>: Audio Delay.</description></item>
        /// <item><description><b>VIDEO_DELAY</b>: Video Delay.</description></item>
        /// <item><description><b>AUDIO_HIGH_QUALITY_TRANSMISSION_RATE</b>: Audio High-quality Transmission Rate.</description></item>
        /// <item><description><b>VIDEO_HIGH_QUALITY_TRANSMISSION_RATE</b>: Video High-quality Transmission Rate.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JOIN_CHANNEL_SUC_RATE</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string Types { get; set; }

    }

}
