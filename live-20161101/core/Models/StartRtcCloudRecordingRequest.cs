// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartRtcCloudRecordingRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>********-7074-<b><b>-9ef5-85c19a4</b></b>*</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>room1024</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("MixLayoutParams")]
        [Validation(Required=false)]
        public StartRtcCloudRecordingRequestMixLayoutParams MixLayoutParams { get; set; }
        public class StartRtcCloudRecordingRequestMixLayoutParams : TeaModel {
            [NameInMap("MixBackground")]
            [Validation(Required=false)]
            public StartRtcCloudRecordingRequestMixLayoutParamsMixBackground MixBackground { get; set; }
            public class StartRtcCloudRecordingRequestMixLayoutParamsMixBackground : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RenderMode")]
                [Validation(Required=false)]
                public int? RenderMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxxx.com/photos/my-test-picture.png">https://xxxx.com/photos/my-test-picture.png</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("UserPanes")]
            [Validation(Required=false)]
            public List<StartRtcCloudRecordingRequestMixLayoutParamsUserPanes> UserPanes { get; set; }
            public class StartRtcCloudRecordingRequestMixLayoutParamsUserPanes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public int? SourceType { get; set; }

                [NameInMap("SubBackground")]
                [Validation(Required=false)]
                public StartRtcCloudRecordingRequestMixLayoutParamsUserPanesSubBackground SubBackground { get; set; }
                public class StartRtcCloudRecordingRequestMixLayoutParamsUserPanesSubBackground : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RenderMode")]
                    [Validation(Required=false)]
                    public int? RenderMode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://xxxx.com/photos/my-test-pane-picture.png">https://xxxx.com/photos/my-test-pane-picture.png</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>userA</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ZOrder")]
                [Validation(Required=false)]
                public int? ZOrder { get; set; }

            }

        }

        [NameInMap("MixTranscodeParams")]
        [Validation(Required=false)]
        public StartRtcCloudRecordingRequestMixTranscodeParams MixTranscodeParams { get; set; }
        public class StartRtcCloudRecordingRequestMixTranscodeParams : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("AudioBitrate")]
            [Validation(Required=false)]
            public long? AudioBitrate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AudioChannels")]
            [Validation(Required=false)]
            public int? AudioChannels { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32000</para>
            /// </summary>
            [NameInMap("AudioSampleRate")]
            [Validation(Required=false)]
            public long? AudioSampleRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FrameFillType")]
            [Validation(Required=false)]
            public int? FrameFillType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("VideoBitrate")]
            [Validation(Required=false)]
            public int? VideoBitrate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>H.264</para>
            /// </summary>
            [NameInMap("VideoCodec")]
            [Validation(Required=false)]
            public string VideoCodec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("VideoFramerate")]
            [Validation(Required=false)]
            public int? VideoFramerate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("VideoGop")]
            [Validation(Required=false)]
            public int? VideoGop { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>480</para>
            /// </summary>
            [NameInMap("VideoHeight")]
            [Validation(Required=false)]
            public int? VideoHeight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>640</para>
            /// </summary>
            [NameInMap("VideoWidth")]
            [Validation(Required=false)]
            public int? VideoWidth { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxxx/test/mycallback">http://xxxx/test/mycallback</a></para>
        /// </summary>
        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordParams")]
        [Validation(Required=false)]
        public StartRtcCloudRecordingRequestRecordParams RecordParams { get; set; }
        public class StartRtcCloudRecordingRequestRecordParams : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>7200</para>
            /// </summary>
            [NameInMap("MaxFileDuration")]
            [Validation(Required=false)]
            public long? MaxFileDuration { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RecordMode")]
            [Validation(Required=false)]
            public int? RecordMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StreamType")]
            [Validation(Required=false)]
            public int? StreamType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StorageParams")]
        [Validation(Required=false)]
        public StartRtcCloudRecordingRequestStorageParams StorageParams { get; set; }
        public class StartRtcCloudRecordingRequestStorageParams : TeaModel {
            [NameInMap("FileInfo")]
            [Validation(Required=false)]
            public List<StartRtcCloudRecordingRequestStorageParamsFileInfo> FileInfo { get; set; }
            public class StartRtcCloudRecordingRequestStorageParamsFileInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{AppId}<em>{ChannelId}</em>{StartTime}_{UserId}</para>
                /// </summary>
                [NameInMap("FileNamePattern")]
                [Validation(Required=false)]
                public string FileNamePattern { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HLS</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{AppId}<em>{ChannelId}</em>{StartTime}_{Sequence}</para>
                /// </summary>
                [NameInMap("SliceNamePattern")]
                [Validation(Required=false)]
                public string SliceNamePattern { get; set; }

            }

            [NameInMap("OSSParams")]
            [Validation(Required=false)]
            public StartRtcCloudRecordingRequestStorageParamsOSSParams OSSParams { get; set; }
            public class StartRtcCloudRecordingRequestStorageParamsOSSParams : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mytest-bucket</para>
                /// </summary>
                [NameInMap("OSSBucket")]
                [Validation(Required=false)]
                public string OSSBucket { get; set; }

                /// <summary>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public int? StorageType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubscribeParams")]
        [Validation(Required=false)]
        public StartRtcCloudRecordingRequestSubscribeParams SubscribeParams { get; set; }
        public class StartRtcCloudRecordingRequestSubscribeParams : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SubscribeUserIdList")]
            [Validation(Required=false)]
            public List<StartRtcCloudRecordingRequestSubscribeParamsSubscribeUserIdList> SubscribeUserIdList { get; set; }
            public class StartRtcCloudRecordingRequestSubscribeParamsSubscribeUserIdList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public int? SourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public int? StreamType { get; set; }

                /// <summary>
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
