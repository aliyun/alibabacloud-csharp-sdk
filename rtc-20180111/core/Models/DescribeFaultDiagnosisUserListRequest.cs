// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeFaultDiagnosisUserListRequest : TeaModel {
        /// <summary>
        /// <para>The app ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0rbd****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the channel to search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>311</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615892596</para>
        /// </summary>
        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public long? EndTs { get; set; }

        /// <summary>
        /// <para>The fault types to filter. Separate multiple fault types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>JOIN_SLOW</b>: Slow channel joining.</description></item>
        /// <item><description><b>AUDIO_STUCK</b>: Audio stuttering. </description></item>
        /// <item><description><b>VIDEO_STUCK</b>: Video stuttering.</description></item>
        /// <item><description><b>VIDEO_VAGUE</b>: Blurry video.</description></item>
        /// <item><description><b>HIGH_DELAY</b>: High call latency.</description></item>
        /// <item><description><b>FIRST_FRAME_SLOW</b>: Slow first frame rendering.</description></item>
        /// </list>
        /// <para>For more information about fault types, see <a href="https://help.aliyun.com/document_detail/2639494.html">Fault types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JOIN_SLOW,AUDIO_STUCK</para>
        /// </summary>
        [NameInMap("FaultTypes")]
        [Validation(Required=false)]
        public string FaultTypes { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615806196</para>
        /// </summary>
        [NameInMap("StartTs")]
        [Validation(Required=false)]
        public long? StartTs { get; set; }

        /// <summary>
        /// <para>The ID of the user to search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c906531af5f9****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
