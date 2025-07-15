// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateRtcCloudRecordingRequest : TeaModel {
        [NameInMap("MixLayoutParams")]
        [Validation(Required=false)]
        public UpdateRtcCloudRecordingRequestMixLayoutParams MixLayoutParams { get; set; }
        public class UpdateRtcCloudRecordingRequestMixLayoutParams : TeaModel {
            [NameInMap("MixBackground")]
            [Validation(Required=false)]
            public UpdateRtcCloudRecordingRequestMixLayoutParamsMixBackground MixBackground { get; set; }
            public class UpdateRtcCloudRecordingRequestMixLayoutParamsMixBackground : TeaModel {
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
            public List<UpdateRtcCloudRecordingRequestMixLayoutParamsUserPanes> UserPanes { get; set; }
            public class UpdateRtcCloudRecordingRequestMixLayoutParamsUserPanes : TeaModel {
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
                public UpdateRtcCloudRecordingRequestMixLayoutParamsUserPanesSubBackground SubBackground { get; set; }
                public class UpdateRtcCloudRecordingRequestMixLayoutParamsUserPanesSubBackground : TeaModel {
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubscribeParams")]
        [Validation(Required=false)]
        public UpdateRtcCloudRecordingRequestSubscribeParams SubscribeParams { get; set; }
        public class UpdateRtcCloudRecordingRequestSubscribeParams : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SubscribeUserIdList")]
            [Validation(Required=false)]
            public List<UpdateRtcCloudRecordingRequestSubscribeParamsSubscribeUserIdList> SubscribeUserIdList { get; set; }
            public class UpdateRtcCloudRecordingRequestSubscribeParamsSubscribeUserIdList : TeaModel {
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>73-8501-</b></b>-8ac1-72295a</b>****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
