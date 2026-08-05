// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveAppRecordConfigRequest : TeaModel {
        /// <summary>
        /// <para>The AppName of the live stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The window in seconds for merging fragmented recording after an interruption. If a stream disconnects and reconnects within this window, the recording will continue in the same file. Valid values: 15 to 21600.</para>
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
        /// <para>The recording end time. Format: <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z (UTC time).</para>
        /// <remarks>
        /// <para>This parameter is only effective for stream-level recordings. The interval between EndTime and StartTime cannot exceed 7 days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2018-04-16T09:57:21Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies the recording mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: disables on-demand recording.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: On-demand recording via HTTP callback.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: On-demand recording by parsing parameters in the ingest URL.</para>
        /// </description></item>
        /// <item><description><para><b>7</b>: Manual recording. You can call the <a href="https://help.aliyun.com/document_detail/2847882.html">RealTimeRecordCommand</a> API to manually start or stop recording.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set OnDemand to <b>1</b>, you need to call the <a href="https://help.aliyun.com/document_detail/2847891.html">AddLiveRecordNotifyConfig</a> API to configure the OnDemandUrl parameter. Otherwise, ApsaraVideo Live does not perform on-demand recording.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OnDemand")]
        [Validation(Required=false)]
        public int? OnDemand { get; set; }

        /// <summary>
        /// <para>The endpoint for OSS storage. You must create an OSS bucket before using this feature. See <a href="https://help.aliyun.com/document_detail/84932.html">Configure OSS</a>.</para>
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
            /// <para>The duration of a single recording cycle in seconds. If not specified, the default value is 6 hours</para>
            /// <remarks>
            /// <para>If a live stream is interrupted during a recording cycle but resumes normal streaming within the merge window, recording will continue in the same file. A recording file is generated only when a live stream is interrupted for longer than the merge window.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CycleDuration")]
            [Validation(Required=false)]
            public int? CycleDuration { get; set; }

            /// <summary>
            /// <para>The recording format. Valid values:</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>If you choose m3u8 or cmaf, you must also set SliceOssObjectPrefix and SliceDuration. At least one of RecordFormat or TranscodeRecordFormat must be specified.</para>
            /// <list type="bullet">
            /// <item><description><para>m3u8</para>
            /// </description></item>
            /// <item><description><para>flv</para>
            /// </description></item>
            /// <item><description><para>mp4</para>
            /// </description></item>
            /// <item><description><para>cmaf</para>
            /// </description></item>
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
            /// <para>This parameter takes effect only if you set the RecordFormat.N.Format parameter to m3u8 or cmaf.</para>
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
        /// <para>The recording start time. Format: <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z (UTC time).</para>
        /// <remarks>
        /// <para>This parameter is only effective for stream-level recordings (i.e., when <c>StreamName</c> is specified). The time must be within 7 days of the actual stream start time.</para>
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
        /// <para>The transcoded stream recording configuration.</para>
        /// </summary>
        [NameInMap("TranscodeRecordFormat")]
        [Validation(Required=false)]
        public List<UpdateLiveAppRecordConfigRequestTranscodeRecordFormat> TranscodeRecordFormat { get; set; }
        public class UpdateLiveAppRecordConfigRequestTranscodeRecordFormat : TeaModel {
            /// <summary>
            /// <para>The transcoded stream recording cycle. Unit: seconds. If you do not specify this parameter, the default value 6 hours is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21600</para>
            /// </summary>
            [NameInMap("CycleDuration")]
            [Validation(Required=false)]
            public int? CycleDuration { get; set; }

            /// <summary>
            /// <para>The format of the transcoded stream recording. Valid values:</para>
            /// <remarks>
            /// <para>If you choose m3u8 or cmaf, you must specify the TranscodeRecordFormat.N.SliceOssObjectPrefix and TranscodeRecordFormat.N.SliceDuration parameters.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>m3u8</para>
            /// </description></item>
            /// <item><description><para>flv</para>
            /// </description></item>
            /// <item><description><para>mp4</para>
            /// </description></item>
            /// <item><description><para>cmaf</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>m3u8</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The duration of a single segment for transcoded stream recording. Unit: seconds.</para>
            /// <remarks>
            /// <para>This parameter takes effect only if you set the TranscodeRecordFormat.N.Format parameter to m3u8 or cmaf.</para>
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
