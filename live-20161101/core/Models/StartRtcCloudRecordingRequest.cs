// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartRtcCloudRecordingRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the app to which the channel to be recorded belongs. The app must belong to the primary account associated with the current API caller\&quot;s account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>********-7074-<b><b>-9ef5-85c19a4</b></b>*</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the channel to be recorded. Make sure that the channel has active users when you call this operation. Otherwise, the recording task fails to be created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>room1024</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The idle timeout period. When the task remains idle for longer than MaxIdleTime, the task is automatically stopped. Unit: seconds. The value must be within [10,14400], which is a maximum of 4 hours. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("MaxIdleTime")]
        [Validation(Required=false)]
        public long? MaxIdleTime { get; set; }

        /// <summary>
        /// <para>The layout parameters. This parameter is not required in single-stream recording mode and is required in stream mixing recording mode when the output is not audio-only.</para>
        /// </summary>
        [NameInMap("MixLayoutParams")]
        [Validation(Required=false)]
        public StartRtcCloudRecordingRequestMixLayoutParams MixLayoutParams { get; set; }
        public class StartRtcCloudRecordingRequestMixLayoutParams : TeaModel {
            /// <summary>
            /// <para>The global background image for stream mixing.</para>
            /// </summary>
            [NameInMap("MixBackground")]
            [Validation(Required=false)]
            public StartRtcCloudRecordingRequestMixLayoutParamsMixBackground MixBackground { get; set; }
            public class StartRtcCloudRecordingRequestMixLayoutParamsMixBackground : TeaModel {
                /// <summary>
                /// <para>The display mode for the output. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RenderMode")]
                [Validation(Required=false)]
                public int? RenderMode { get; set; }

                /// <summary>
                /// <para>The URL of the background image. The maximum length is 2048 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxxx.com/photos/my-test-picture.png">https://xxxx.com/photos/my-test-picture.png</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>Specifies the window layout information for subscribed users. Only users whose UserId has layout information configured are included in the video. This parameter is required in stream mixing mode when recording non-audio-only files.</para>
            /// </summary>
            [NameInMap("UserPanes")]
            [Validation(Required=false)]
            public List<StartRtcCloudRecordingRequestMixLayoutParamsUserPanes> UserPanes { get; set; }
            public class StartRtcCloudRecordingRequestMixLayoutParamsUserPanes : TeaModel {
                /// <summary>
                /// <para>The pane height as a normalized percentage. The value must be within [0,1]. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <para>The video input stream type for this UserId. If UserId is not specified, this SourceType setting has no effect. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public int? SourceType { get; set; }

                /// <summary>
                /// <para>The background image for the sub-pane. When a user turns off the camera, has not published a stream after joining, or leaves the channel midway, the corresponding image fills the layout position.</para>
                /// </summary>
                [NameInMap("SubBackground")]
                [Validation(Required=false)]
                public StartRtcCloudRecordingRequestMixLayoutParamsUserPanesSubBackground SubBackground { get; set; }
                public class StartRtcCloudRecordingRequestMixLayoutParamsUserPanesSubBackground : TeaModel {
                    /// <summary>
                    /// <para>The display mode for the sub-pane output. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RenderMode")]
                    [Validation(Required=false)]
                    public int? RenderMode { get; set; }

                    /// <summary>
                    /// <para>The URL of the background image. The maximum length is 2048 characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://xxxx.com/photos/my-test-pane-picture.png">https://xxxx.com/photos/my-test-pane-picture.png</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The UserId corresponding to this window.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userA</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The pane width as a normalized percentage. The value must be within [0,1]. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

                /// <summary>
                /// <para>The X coordinate as a normalized percentage. The value must be within [0,1]. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <para>The Y coordinate as a normalized percentage. The value must be within [0,1]. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

                /// <summary>
                /// <para>The stacking order. 0 is the bottom layer, layer 1 is above layer 0, and so on. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

        }

        /// <summary>
        /// <para>The transcoding parameters. This parameter is not required in single-stream recording mode and is required in stream mixing recording mode.</para>
        /// </summary>
        [NameInMap("MixTranscodeParams")]
        [Validation(Required=false)]
        public StartRtcCloudRecordingRequestMixTranscodeParams MixTranscodeParams { get; set; }
        public class StartRtcCloudRecordingRequestMixTranscodeParams : TeaModel {
            /// <summary>
            /// <para>The audio bitrate in kbps. The value must be in the range of [8, 500]. This parameter is required in stream mixing mode.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("AudioBitrate")]
            [Validation(Required=false)]
            public long? AudioBitrate { get; set; }

            /// <summary>
            /// <para>The number of audio channels. Valid values:</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AudioChannels")]
            [Validation(Required=false)]
            public int? AudioChannels { get; set; }

            /// <summary>
            /// <para>The audio sample rate in Hz. Valid values:</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32000</para>
            /// </summary>
            [NameInMap("AudioSampleRate")]
            [Validation(Required=false)]
            public long? AudioSampleRate { get; set; }

            /// <summary>
            /// <para>The frame fill type when a stream is interrupted. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FrameFillType")]
            [Validation(Required=false)]
            public int? FrameFillType { get; set; }

            /// <summary>
            /// <para>The video bitrate in kbps. The value must be in the range of [1, 10000].</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("VideoBitrate")]
            [Validation(Required=false)]
            public int? VideoBitrate { get; set; }

            /// <summary>
            /// <para>The video encoding format. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>H.264</para>
            /// </summary>
            [NameInMap("VideoCodec")]
            [Validation(Required=false)]
            public string VideoCodec { get; set; }

            /// <summary>
            /// <para>The video frame rate in fps. The value must be in the range of [1, 60].</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("VideoFramerate")]
            [Validation(Required=false)]
            public int? VideoFramerate { get; set; }

            /// <summary>
            /// <para>The video GOP. An I-frame is inserted every VideoGop frames. The value must be in the range of [1, 60].</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("VideoGop")]
            [Validation(Required=false)]
            public int? VideoGop { get; set; }

            /// <summary>
            /// <para>The video height in pixels. The value must be in the range of [0, 1920]. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>480</para>
            /// </summary>
            [NameInMap("VideoHeight")]
            [Validation(Required=false)]
            public int? VideoHeight { get; set; }

            /// <summary>
            /// <para>The video width in pixels. The value must be in the range of [0, 1920]. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>640</para>
            /// </summary>
            [NameInMap("VideoWidth")]
            [Validation(Required=false)]
            public int? VideoWidth { get; set; }

        }

        /// <summary>
        /// <para>The authentication key for callback messages. Leave this parameter empty to skip authentication. If specified, the key must be 16 to 64 characters in length and consist of only uppercase and lowercase letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mytestkeymytestkey</para>
        /// </summary>
        [NameInMap("NotifyAuthKey")]
        [Validation(Required=false)]
        public string NotifyAuthKey { get; set; }

        /// <summary>
        /// <para>The specified formats for which a callback message is sent when the recording file upload event (RecordFileUploaded) is triggered.</para>
        /// </summary>
        [NameInMap("NotifyFileUploadedFormat")]
        [Validation(Required=false)]
        public List<string> NotifyFileUploadedFormat { get; set; }

        /// <summary>
        /// <para>The URL for receiving callback messages. Task status messages are pushed to this URL in JSON format by using the POST method. The maximum length is 2048 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxx/test/mycallback">http://xxxx/test/mycallback</a></para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <para>The recording parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordParams")]
        [Validation(Required=false)]
        public StartRtcCloudRecordingRequestRecordParams RecordParams { get; set; }
        public class StartRtcCloudRecordingRequestRecordParams : TeaModel {
            /// <summary>
            /// <para>The maximum duration of a recording file, in seconds. A recording file that exceeds this duration is split. The value must be in the range of [180, 7200], which means a maximum of 2 hours. If this parameter is not specified, the default value is 7200 (2 hours).</para>
            /// 
            /// <b>Example:</b>
            /// <para>7200</para>
            /// </summary>
            [NameInMap("MaxFileDuration")]
            [Validation(Required=false)]
            public long? MaxFileDuration { get; set; }

            /// <summary>
            /// <para>The recording mode. Valid values:</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RecordMode")]
            [Validation(Required=false)]
            public int? RecordMode { get; set; }

            /// <summary>
            /// <para>The media type of the output recording stream. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StreamType")]
            [Validation(Required=false)]
            public int? StreamType { get; set; }

        }

        /// <summary>
        /// <para>The storage parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StorageParams")]
        [Validation(Required=false)]
        public StartRtcCloudRecordingRequestStorageParams StorageParams { get; set; }
        public class StartRtcCloudRecordingRequestStorageParams : TeaModel {
            /// <summary>
            /// <para>The file storage information, which specifies the format, storage location, and naming of recording files. This parameter takes effect only when StorageType is set to OSS.</para>
            /// </summary>
            [NameInMap("FileInfo")]
            [Validation(Required=false)]
            public List<StartRtcCloudRecordingRequestStorageParamsFileInfo> FileInfo { get; set; }
            public class StartRtcCloudRecordingRequestStorageParamsFileInfo : TeaModel {
                /// <summary>
                /// <para>The file naming format. You can select and combine the following variables in any order:</para>
                /// 
                /// <b>Example:</b>
                /// <para>{AppId}<em>{ChannelId}</em>{StartTime}_{UserId}</para>
                /// </summary>
                [NameInMap("FileNamePattern")]
                [Validation(Required=false)]
                public string FileNamePattern { get; set; }

                /// <summary>
                /// <para>The file storage path. Each element in the array corresponds to a directory level. For example, if the value is [&quot;dir1&quot;,&quot;dir2&quot;], the xxx.m3u8 file is saved as dir1/dir2/TaskId/xxx.m3u8. If this parameter is empty, the file is saved as TaskId/xxx.m3u8.</para>
                /// </summary>
                [NameInMap("FilePathPrefix")]
                [Validation(Required=false)]
                public List<string> FilePathPrefix { get; set; }

                /// <summary>
                /// <para>The file storage format. Valid values:</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HLS</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The segment length in seconds. This parameter takes effect only in HLS format. The value must be in the range of [10, 30]. Default value: 30.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("SliceDuration")]
                [Validation(Required=false)]
                public long? SliceDuration { get; set; }

                /// <summary>
                /// <para>The segment naming format. This parameter takes effect only in HLS format. Similar to FileNamePattern, but with an additional variable Sequence:</para>
                /// 
                /// <b>Example:</b>
                /// <para>{AppId}<em>{ChannelId}</em>{StartTime}_{Sequence}</para>
                /// </summary>
                [NameInMap("SliceNamePattern")]
                [Validation(Required=false)]
                public string SliceNamePattern { get; set; }

            }

            /// <summary>
            /// <para>The OSS storage configuration. This parameter is required when the storage method is OSS and is invalid when the storage method is VOD.</para>
            /// </summary>
            [NameInMap("OSSParams")]
            [Validation(Required=false)]
            public StartRtcCloudRecordingRequestStorageParamsOSSParams OSSParams { get; set; }
            public class StartRtcCloudRecordingRequestStorageParamsOSSParams : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket. The bucket must belong to the primary account associated with the current API caller\&quot;s account.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mytest-bucket</para>
                /// </summary>
                [NameInMap("OSSBucket")]
                [Validation(Required=false)]
                public string OSSBucket { get; set; }

                /// <summary>
                /// <para>The endpoint of the OSS storage. The corresponding region ID must be consistent with the selected service registration endpoint.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("OSSEndpoint")]
                [Validation(Required=false)]
                public string OSSEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The storage method. Valid values:</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public int? StorageType { get; set; }

            /// <summary>
            /// <para>The VOD storage configuration. This parameter is required when the storage method is VOD and is invalid when the storage method is OSS.</para>
            /// </summary>
            [NameInMap("VodParams")]
            [Validation(Required=false)]
            public StartRtcCloudRecordingRequestStorageParamsVodParams VodParams { get; set; }
            public class StartRtcCloudRecordingRequestStorageParamsVodParams : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable automatic composition. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AutoCompose")]
                [Validation(Required=false)]
                public int? AutoCompose { get; set; }

                /// <summary>
                /// <para>The ID of the VOD transcoding template group used to transcode the automatically composed video in the VOD service.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>4c34112cfe68248f2f77759c</b></b></para>
                /// </summary>
                [NameInMap("ComposeVodTranscodeGroupId")]
                [Validation(Required=false)]
                public string ComposeVodTranscodeGroupId { get; set; }

                /// <summary>
                /// <para>The storage address configured in the ApsaraVideo VOD console under Media Asset Management &gt; Storage Management. Recording files are first saved to this location and then uploaded to VOD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mytest.oss-cn-shenzhen.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <para>The ID of the VOD transcoding template group.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>8a914d3989e9825eb90530b2</b></b></para>
                /// </summary>
                [NameInMap("VodTranscodeGroupId")]
                [Validation(Required=false)]
                public string VodTranscodeGroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>The subscription parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubscribeParams")]
        [Validation(Required=false)]
        public StartRtcCloudRecordingRequestSubscribeParams SubscribeParams { get; set; }
        public class StartRtcCloudRecordingRequestSubscribeParams : TeaModel {
            /// <summary>
            /// <para>The list of subscribed UserId entries. In single-stream recording mode, each UserId is recorded separately. In stream mixing recording mode, the audio and video of all UserIds are mixed into a single set of audio and video.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SubscribeUserIdList")]
            [Validation(Required=false)]
            public List<StartRtcCloudRecordingRequestSubscribeParamsSubscribeUserIdList> SubscribeUserIdList { get; set; }
            public class StartRtcCloudRecordingRequestSubscribeParamsSubscribeUserIdList : TeaModel {
                /// <summary>
                /// <para>The video input stream type of the UserId. This parameter takes effect only when the subscription is not audio-only (StreamType != 1). Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public int? SourceType { get; set; }

                /// <summary>
                /// <para>The media type of the subscribed UserId. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public int? StreamType { get; set; }

                /// <summary>
                /// <para>The subscribed UserId.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userA</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
