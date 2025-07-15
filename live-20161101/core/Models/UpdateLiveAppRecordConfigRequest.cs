// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveAppRecordConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The interruption duration for merge. If the stream interruption duration exceeds the specified duration, a new recording is generated. The value of this parameter ranges from 15 to 21600 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("DelayTime")]
        [Validation(Required=false)]
        public int? DelayTime { get; set; }

        /// <summary>
        /// <para>The main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The recording end time. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> The time range that is specified by the EndTime and StartTime parameters must be less than or equal to seven days. If the value exceeds seven days, ApsaraVideo Live considers seven days as the time range. This parameter takes effect only for the live stream specified by the StreamName parameter. If the StreamName parameter is not specified, this parameter does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2018-04-16T09:57:21Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable on-demand recording. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disables on-demand recording.</description></item>
        /// <item><description><b>1</b>: enables on-demand recording by using the HTTP callback method.</description></item>
        /// <item><description><b>2</b>: enables on-demand recording by parsing the stream ingest parameters.</description></item>
        /// <item><description><b>7</b>: By default, ApsaraVideo Live does not automatically record live streams. You can call the <a href="https://help.aliyun.com/document_detail/2847882.html">RealTimeRecordCommand</a> operation to manually start or stop recording.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set the OnDemand parameter to <b>1</b>, you need to call the <a href="https://help.aliyun.com/document_detail/2847891.html">AddLiveRecordNotifyConfig</a> operation to configure the OnDemandUrl parameter. Otherwise, ApsaraVideo Live does not perform on-demand recording.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OnDemand")]
        [Validation(Required=false)]
        public int? OnDemand { get; set; }

        /// <summary>
        /// <para>The endpoint of the Object Storage Service (OSS) bucket.</para>
        /// <para>To store live stream recordings in OSS, you need to create an OSS bucket in advance. For more information, see <a href="https://help.aliyun.com/document_detail/84932.html">Configure OSS</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>learn.developer.aliyundoc.com</para>
        /// </summary>
        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The recording details.</para>
        /// </summary>
        [NameInMap("RecordFormat")]
        [Validation(Required=false)]
        public List<UpdateLiveAppRecordConfigRequestRecordFormat> RecordFormat { get; set; }
        public class UpdateLiveAppRecordConfigRequestRecordFormat : TeaModel {
            /// <summary>
            /// <para>The recording cycle. Unit: seconds If you do not specify this parameter, the default value 6 hours is used.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>If a live stream is interrupted during a recording cycle but is resumed within the interruption duration threshold, the stream is recorded in the same recording before and after the interruption.</para>
            /// </description></item>
            /// <item><description><para>If a live stream is interrupted for longer than the interruption duration threshold, a new recording is generated.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CycleDuration")]
            [Validation(Required=false)]
            public int? CycleDuration { get; set; }

            /// <summary>
            /// <para>The recording format. Supported formats include M3U8, Flash Video (FLV), MP4, and Common Media Application Format (CMAF). Valid values:</para>
            /// <remarks>
            /// <para> You need to specify at lease one of the RecordFormat and TranscodeRecordFormat parameters. If you set this parameter to m3u8 or cmaf, you must also specify the RecordFormat.N.SliceOssObjectPrefix and RecordFormat.N.SliceDuration parameters.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>m3u8</description></item>
            /// <item><description>flv</description></item>
            /// <item><description>mp4</description></item>
            /// <item><description>cmaf</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>m3u8</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The duration of a single segment. Unit: seconds</para>
            /// <remarks>
            /// <para> This parameter takes effect only if you set the RecordFormat.N.Format parameter to m3u8 or cmaf.</para>
            /// </remarks>
            /// <para>If you do not specify this parameter, the default value 30 seconds is used. Valid values: 5 to 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SliceDuration")]
            [Validation(Required=false)]
            public int? SliceDuration { get; set; }

        }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The recording start time. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> The start time must be within seven days after the stream ingest starts. This parameter takes effect only for the live stream specified by the StreamName parameter. If the StreamName parameter is not specified, this parameter does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2018-04-10T09:57:21Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the live stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>teststream</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// <para>The transcoded stream recording details.</para>
        /// </summary>
        [NameInMap("TranscodeRecordFormat")]
        [Validation(Required=false)]
        public List<UpdateLiveAppRecordConfigRequestTranscodeRecordFormat> TranscodeRecordFormat { get; set; }
        public class UpdateLiveAppRecordConfigRequestTranscodeRecordFormat : TeaModel {
            /// <summary>
            /// <para>The transcoded stream recording cycle. Unit: seconds If you do not specify this parameter, the default value 6 hours is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21600</para>
            /// </summary>
            [NameInMap("CycleDuration")]
            [Validation(Required=false)]
            public int? CycleDuration { get; set; }

            /// <summary>
            /// <para>The format of the transcoded stream recording. Supported formats include M3U8, FLV, MP4, and CMAF. Valid values:</para>
            /// <remarks>
            /// <para> If you set this parameter to m3u8 or cmaf, you must also specify the TranscodeRecordFormat.N.SliceOssObjectPrefix and TranscodeRecordFormat.N.SliceDuration parameters.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>m3u8</description></item>
            /// <item><description>flv</description></item>
            /// <item><description>mp4</description></item>
            /// <item><description>cmaf</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>m3u8</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The duration of a single segment in the transcoded stream recording. Unit: seconds.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if you set the TranscodeRecordFormat.N.Format parameter to m3u8 or cmaf.</para>
            /// </remarks>
            /// <para>If you do not specify this parameter, the default value 30 seconds is used. Valid values: 5 to 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SliceDuration")]
            [Validation(Required=false)]
            public int? SliceDuration { get; set; }

        }

        /// <summary>
        /// <para>The transcoding template group details.</para>
        /// </summary>
        [NameInMap("TranscodeTemplates")]
        [Validation(Required=false)]
        public List<string> TranscodeTemplates { get; set; }

    }

}
