// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveEditingJobResponseBody : TeaModel {
        /// <summary>
        /// 直播剪辑任务
        /// </summary>
        [NameInMap("LiveEditingJob")]
        [Validation(Required=false)]
        public GetLiveEditingJobResponseBodyLiveEditingJob LiveEditingJob { get; set; }
        public class GetLiveEditingJobResponseBodyLiveEditingJob : TeaModel {
            [NameInMap("Clips")]
            [Validation(Required=false)]
            public string Clips { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("LiveStreamConfig")]
            [Validation(Required=false)]
            public GetLiveEditingJobResponseBodyLiveEditingJobLiveStreamConfig LiveStreamConfig { get; set; }
            public class GetLiveEditingJobResponseBodyLiveEditingJobLiveStreamConfig : TeaModel {
                /// <summary>
                /// 播流所属应用名称
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// 播流所属域名
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// 播流所属流名
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }
            [NameInMap("MediaProduceConfig")]
            [Validation(Required=false)]
            public GetLiveEditingJobResponseBodyLiveEditingJobMediaProduceConfig MediaProduceConfig { get; set; }
            public class GetLiveEditingJobResponseBodyLiveEditingJobMediaProduceConfig : TeaModel {
                /// <summary>
                /// 剪辑模式，默认Accurate
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }
            [NameInMap("MediaURL")]
            [Validation(Required=false)]
            public string MediaURL { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }
            [NameInMap("OutputMediaConfig")]
            [Validation(Required=false)]
            public GetLiveEditingJobResponseBodyLiveEditingJobOutputMediaConfig OutputMediaConfig { get; set; }
            public class GetLiveEditingJobResponseBodyLiveEditingJobOutputMediaConfig : TeaModel {
                /// <summary>
                /// 输出成品的码率，单位为Kbps。可以不填，默认值是多个素材的最高码率
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public long? Bitrate { get; set; }

                /// <summary>
                /// 当 OutputMediaTarget 的目标为 vod-media 时，指定 fileName(包含文件后缀，不含路径）作为输出文件名
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// 输出成品的高。可以不填，默认值是多个素材的最大高
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// 输出成片的文件地址
                /// </summary>
                [NameInMap("MediaURL")]
                [Validation(Required=false)]
                public string MediaURL { get; set; }

                /// <summary>
                /// 当 OutputMediaTarget 的目标为 vod-media 时， 指定 storage location 来存储媒资到 VOD; storage location 是 VOD 中的文件存储位置， 不包含 http:// 的前缀， 如:  outin-xxxxxx.oss-cn-shanghai.aliyuncs.com
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// 合成成片输出到vod，指定vod转码模板组。如不需要VOD转码，请填写 "VOD_NO_TRANSCODE".
                /// </summary>
                [NameInMap("VodTemplateGroupId")]
                [Validation(Required=false)]
                public string VodTemplateGroupId { get; set; }

                /// <summary>
                /// 输出成品的宽。可以不填，默认值是多个素材的最大宽
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }
        };

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
