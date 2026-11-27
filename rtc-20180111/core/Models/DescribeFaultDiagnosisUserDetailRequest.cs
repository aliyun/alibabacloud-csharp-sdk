// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeFaultDiagnosisUserDetailRequest : TeaModel {
        /// <summary>
        /// <para>APP ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0rbd****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>频道ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>311</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>频道创建时间，使用UNIX时间戳表示，单位：秒。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615892596</para>
        /// </summary>
        [NameInMap("CreatedTs")]
        [Validation(Required=false)]
        public long? CreatedTs { get; set; }

        /// <summary>
        /// <para>异常类型。取值：</para>
        /// <list type="bullet">
        /// <item><description><b>JOIN_SLOW</b>：进频道慢 。</description></item>
        /// <item><description><b>AUDIO_STUCK</b>：音频卡顿。</description></item>
        /// <item><description><b>VIDEO_STUCK</b>：视频卡顿。</description></item>
        /// <item><description><b>VIDEO_VAGUE</b>：视频模糊。</description></item>
        /// <item><description><b>HIGH_DELAY</b>：通话延迟高 。</description></item>
        /// <item><description><b>FIRST_FRAME_SLOW</b>：接收首屏慢。</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JOIN_SLOW</para>
        /// </summary>
        [NameInMap("FaultType")]
        [Validation(Required=false)]
        public string FaultType { get; set; }

        /// <summary>
        /// <para>是否查询通话用户信息，为空默认是false。</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("QueryCallUserInfo")]
        [Validation(Required=false)]
        public bool? QueryCallUserInfo { get; set; }

        /// <summary>
        /// <para>用户ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c906531af5f9****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
