// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveAppRecordConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the stream belongs. The template takes effect only when the AppName value matches the AppName in the ingest URL. To match all application names, set this parameter to an asterisk (*).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The stream discontinuity merging duration. If the live stream is disconnected for longer than the specified merging duration, a new file is generated. Valid values: 15 to 21600. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("DelayTime")]
        [Validation(Required=false)]
        public int? DelayTime { get; set; }

        /// <summary>
        /// <para>The streaming domain of the streamer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The recording end time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// <remarks>
        /// <para>The difference between EndTime and StartTime cannot exceed 7 days. If it exceeds 7 days, the value is calculated as 7 days. This parameter is valid only for stream-level recording (when StreamName is not empty).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2018-04-16T09:57:21Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The on-demand or manual recording mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): disabled. Automatic recording is used.</description></item>
        /// <item><description><b>1</b>: on-demand recording through HTTP callback. You must first configure OnDemandUrl by calling the <a href="https://help.aliyun.com/document_detail/2847891.html">AddLiveRecordNotifyConfig</a> operation. Otherwise, recording is not performed by default.</description></item>
        /// <item><description><b>2</b>: on-demand recording by parsing stream ingest parameters.</description></item>
        /// <item><description><b>7</b>: manual recording. Recording is not performed by default. You can call the <a href="https://help.aliyun.com/document_detail/2847882.html">RealTimeRecordCommand</a> operation to manually start or stop recording.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OnDemand")]
        [Validation(Required=false)]
        public int? OnDemand { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// <para>To store live recordings in OSS, create an OSS bucket in advance. For more information, see <a href="https://help.aliyun.com/document_detail/84932.html">Configure OSS</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveBucket****</para>
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>The endpoint of the OSS bucket.</para>
        /// <para>To store live recordings in OSS, create an OSS bucket in advance. For more information, see <a href="https://help.aliyun.com/document_detail/84932.html">Configure OSS</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-beijing.aliyuncs.com</para>
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
        public List<AddLiveAppRecordConfigRequestRecordFormat> RecordFormat { get; set; }
        public class AddLiveAppRecordConfigRequestRecordFormat : TeaModel {
            /// <summary>
            /// <para>The recording length per epoch. Unit: seconds.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If this parameter is not specified, the default value varies by recording format: 6 hours for m3u8 and cmaf formats, and 1 hour for flv and mp4 formats.</description></item>
            /// <item><description>If a live stream is disconnected within a recording epoch but resumes stream ingest within the stream discontinuity merging duration, recording continues in the same file. This is Normal behavior.</description></item>
            /// <item><description>A recording file is generated only after the live stream is disconnected for longer than the stream discontinuity merging duration.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CycleDuration")]
            [Validation(Required=false)]
            public int? CycleDuration { get; set; }

            /// <summary>
            /// <para>The format. M3U8, FLV, MP4, and CMAF are supported. Valid values:</para>
            /// <remarks>
            /// <para>Notice: At least one of RecordFormat and TranscodeRecordFormat must be set. If you select m3u8 or cmaf, you must also set the request parameters RecordFormat.N.SliceOssObjectPrefix and RecordFormat.N.SliceDuration.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>m3u8.</description></item>
            /// <item><description>flv.</description></item>
            /// <item><description>mp4.</description></item>
            /// <item><description>cmaf.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Settings for RecordFormat and TranscodeRecordFormat: at least one must be specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>m3u8</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The name of the recording file stored in OSS.</para>
            /// <list type="bullet">
            /// <item><description>The file name must be less than 256 bytes and supports variable matching, including {AppName}, {StreamName}, {Sequence}, {StartTime}, {EndTime}, {EscapedStartTime}, and {EscapedEndTime}.</description></item>
            /// <item><description>The value must contain {StartTime} or {EscapedStartTime} and {EndTime} or {EscapedEndTime}.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>record/{AppName}/{StreamName}/{Sequence}<em>{EscapedStartTime}</em>{EscapedEndTime}</para>
            /// </summary>
            [NameInMap("OssObjectPrefix")]
            [Validation(Required=false)]
            public string OssObjectPrefix { get; set; }

            /// <summary>
            /// <para>The segment length of a single segment. Unit: seconds.</para>
            /// <remarks>
            /// <para>Notice: This parameter takes effect only when RecordFormat.N.Format is set to m3u8 or cmaf.</para>
            /// </remarks>
            /// <para>If this parameter is not specified, the default value is 30 seconds. Valid values: 5 to 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SliceDuration")]
            [Validation(Required=false)]
            public int? SliceDuration { get; set; }

            /// <summary>
            /// <para>The segment name.</para>
            /// <remarks>
            /// <para>Notice: This parameter is required only when RecordFormat.N.Format is set to m3u8 or cmaf.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>The default segment length is 30 seconds. The value must be less than 256 bytes and supports variable matching, including {AppName}, {StreamName}, {UnixTimestamp}, and {Sequence}.</description></item>
            /// <item><description>The value must contain the {UnixTimestamp} and {Sequence} variables.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>record/{AppName}/{StreamName}/{UnixTimestamp}_{Sequence}</para>
            /// </summary>
            [NameInMap("SliceOssObjectPrefix")]
            [Validation(Required=false)]
            public string SliceOssObjectPrefix { get; set; }

        }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The recording start time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// <remarks>
        /// <para>The specified time must be within 7 days of the actual stream ingest start time. This parameter is valid only for stream-level recording (when StreamName is not empty).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2018-04-10T09:57:21Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The stream name. The template takes effect only when the StreamName value matches the StreamName in the ingest URL. To match all stream names under the specified AppName, set this parameter to an asterisk (*).</para>
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
        public List<AddLiveAppRecordConfigRequestTranscodeRecordFormat> TranscodeRecordFormat { get; set; }
        public class AddLiveAppRecordConfigRequestTranscodeRecordFormat : TeaModel {
            /// <summary>
            /// <para>The recording length per epoch for transcoding stream recording. Unit: seconds.</para>
            /// <remarks>
            /// <para>If this parameter is not specified, the default value varies by recording format: 6 hours for m3u8 and cmaf formats, and 1 hour for flv and mp4 formats.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>21600</para>
            /// </summary>
            [NameInMap("CycleDuration")]
            [Validation(Required=false)]
            public int? CycleDuration { get; set; }

            /// <summary>
            /// <para>The transcoding stream recording format. M3U8, FLV, MP4, and CMAF are supported. Valid values:</para>
            /// <remarks>
            /// <para>Notice: If you select m3u8 or cmaf, you must also set the request parameters TranscodeRecordFormat.N.SliceOssObjectPrefix and TranscodeRecordFormat.N.SliceDuration.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>m3u8.</description></item>
            /// <item><description>flv.</description></item>
            /// <item><description>mp4.</description></item>
            /// <item><description>cmaf.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Settings: if you select m3u8 or cmaf format, the corresponding slice parameters must also be configured.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>m3u8</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The name of the transcoded stream recording file stored in OSS.</para>
            /// <list type="bullet">
            /// <item><description>The file name must be less than 256 bytes and supports variable matching, including {AppName}, {StreamName}, {Sequence}, {StartTime}, {EndTime}, {EscapedStartTime}, and {EscapedEndTime}.</description></item>
            /// <item><description>The value must contain {StartTime} or {EscapedStartTime} and {EndTime} or {EscapedEndTime}.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>record/{AppName}/{StreamName}/{Sequence}<em>{EscapedStartTime}</em>{EscapedEndTime}</para>
            /// </summary>
            [NameInMap("OssObjectPrefix")]
            [Validation(Required=false)]
            public string OssObjectPrefix { get; set; }

            /// <summary>
            /// <para>The segment length of a single segment for transcoding stream recording. Unit: seconds.</para>
            /// <remarks>
            /// <para>Notice: This parameter takes effect only when TranscodeRecordFormat.N.Format (transcoding stream recording format) is set to m3u8 or cmaf.</para>
            /// </remarks>
            /// <para>If this parameter is not specified, the default value is 30 seconds. Valid values: 5 to 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SliceDuration")]
            [Validation(Required=false)]
            public int? SliceDuration { get; set; }

            /// <summary>
            /// <para>The segment name for transcoded stream recording.</para>
            /// <remarks>
            /// <para>Notice: This parameter is required only when TranscodeRecordFormat.N.Format is set to m3u8 or cmaf.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>The default segment length is 30 seconds. The value must be less than 256 bytes and supports variable matching, including {AppName}, {StreamName}, {UnixTimestamp}, and {Sequence}.</description></item>
            /// <item><description>The value must contain the {UnixTimestamp} and {Sequence} variables.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>record/{AppName}/{StreamName}/{UnixTimestamp}_{Sequence}</para>
            /// </summary>
            [NameInMap("SliceOssObjectPrefix")]
            [Validation(Required=false)]
            public string SliceOssObjectPrefix { get; set; }

        }

        /// <summary>
        /// <para>The transcoding template group for transcoded stream recording.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sd</para>
        /// </summary>
        [NameInMap("TranscodeTemplates")]
        [Validation(Required=false)]
        public List<string> TranscodeTemplates { get; set; }

    }

}
