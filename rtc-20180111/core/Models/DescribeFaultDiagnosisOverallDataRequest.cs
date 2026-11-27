// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeFaultDiagnosisOverallDataRequest : TeaModel {
        /// <summary>
        /// <para>The app ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4eah****</para>
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
        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public long? EndTs { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615824000</para>
        /// </summary>
        [NameInMap("StartTs")]
        [Validation(Required=false)]
        public long? StartTs { get; set; }

        /// <summary>
        /// <para>The statistical dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>JOIN_SLOW_USER</b>: the number of users who joined the channel slowly</description></item>
        /// <item><description><b>AUDIO_STUCK_USER</b>: the number of users who experienced audio stuttering</description></item>
        /// <item><description><b>VIDEO_STUCK_USER</b>: the number of users who experienced video stuttering</description></item>
        /// <item><description><b>VIDEO_VAGUE_USER</b>: the number of users who experienced blurry video</description></item>
        /// <item><description><b>HIGH_DELAY_USER</b>: the number of users who experienced high call latency</description></item>
        /// <item><description><b>FIRST_FRAME_SLOW_USER</b>: the number of users who experienced slow first screen rendering</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JOIN_SLOW_USER</para>
        /// </summary>
        [NameInMap("StatDim")]
        [Validation(Required=false)]
        public string StatDim { get; set; }

    }

}
