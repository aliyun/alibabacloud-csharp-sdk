// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateRtcAsrTaskRequest : TeaModel {
        /// <summary>
        /// <para>The AuthKey that is used to generate the MD5 signature in callbacks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcd</para>
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// <para>The maximum latency at which the task is automatically stopped. Unit: seconds. Valid values: 1 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("AutoTerminateDelay")]
        [Validation(Required=false)]
        public long? AutoTerminateDelay { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically stop the task when the latency exceeds the specified limit. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoTerminateEnabled")]
        [Validation(Required=false)]
        public bool? AutoTerminateEnabled { get; set; }

        /// <summary>
        /// <para>The callback URL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxx.com">http://xxx.com</a></para>
        /// </summary>
        [NameInMap("CallbackURL")]
        [Validation(Required=false)]
        public string CallbackURL { get; set; }

        /// <summary>
        /// <para>The ID of the channel.</para>
        /// <remarks>
        /// <para> This parameter is required and takes effect only if you set the Mode parameter to rtc.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>channelId</para>
        /// </summary>
        [NameInMap("ChannelID")]
        [Validation(Required=false)]
        public string ChannelID { get; set; }

        /// <summary>
        /// <para>The source language of the audio. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ja: Japanese</description></item>
        /// <item><description>yue: Cantonese</description></item>
        /// <item><description>fspk: mixed Mandarin and English</description></item>
        /// <item><description>en: English</description></item>
        /// <item><description>cn: Mandarin</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The type of the stream. Valid values: live and rtc. The value live specifies a regular live stream, such as a Real-Time Messaging Protocol (RTMP) stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The interval at which callbacks are returned. Unit: milliseconds. Valid values: -1 and 0 to 500.</para>
        /// <list type="bullet">
        /// <item><description>\-1: accepts callbacks only for whole sentences, but not for incomplete sentences.</description></item>
        /// <item><description>0 or an empty value: returns callbacks in real time.</description></item>
        /// <item><description>A value that is greater than 0 and less than or equal to 500: returns callbacks at the specified interval.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ReportInterval")]
        [Validation(Required=false)]
        public long? ReportInterval { get; set; }

        /// <summary>
        /// <para>The ID of the user who ingests the stream.</para>
        /// <remarks>
        /// <para> This parameter is required and takes effect only if you set the Mode parameter to rtc. You can specify only one user ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("RtcUserId")]
        [Validation(Required=false)]
        public string RtcUserId { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraVideo Real-time Communication (ARTC) application.</para>
        /// <remarks>
        /// <para> This parameter is required and takes effect only if you set the Mode parameter to rtc.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>appId</para>
        /// </summary>
        [NameInMap("SDKAppID")]
        [Validation(Required=false)]
        public string SDKAppID { get; set; }

        /// <summary>
        /// <para>The URL of the live stream.</para>
        /// <remarks>
        /// <para> This parameter is required and takes effect only if you set the Mode parameter to live.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://xxx</para>
        /// </summary>
        [NameInMap("StreamURL")]
        [Validation(Required=false)]
        public string StreamURL { get; set; }

        /// <summary>
        /// <para>The language into which the subtitles are translated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// <item><description>ja: Japanese</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("TargetLanguages")]
        [Validation(Required=false)]
        public string TargetLanguages { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the translation feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TranslateEnabled")]
        [Validation(Required=false)]
        public bool? TranslateEnabled { get; set; }

    }

}
