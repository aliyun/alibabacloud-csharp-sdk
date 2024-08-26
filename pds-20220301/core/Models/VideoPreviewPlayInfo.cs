// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class VideoPreviewPlayInfo : TeaModel {
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("live_transcoding_task_list")]
        [Validation(Required=false)]
        public List<VideoPreviewPlayInfoLiveTranscodingTaskList> LiveTranscodingTaskList { get; set; }
        public class VideoPreviewPlayInfoLiveTranscodingTaskList : TeaModel {
            [NameInMap("keep_original_resolution")]
            [Validation(Required=false)]
            public bool? KeepOriginalResolution { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("template_id")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("master_url")]
        [Validation(Required=false)]
        public string MasterUrl { get; set; }

        [NameInMap("meta")]
        [Validation(Required=false)]
        public VideoPreviewPlayInfoMeta Meta { get; set; }
        public class VideoPreviewPlayInfoMeta : TeaModel {
            [NameInMap("duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            [NameInMap("height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            [NameInMap("width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        [NameInMap("offline_video_transcoding_list")]
        [Validation(Required=false)]
        public List<VideoPreviewPlayInfoOfflineVideoTranscodingList> OfflineVideoTranscodingList { get; set; }
        public class VideoPreviewPlayInfoOfflineVideoTranscodingList : TeaModel {
            [NameInMap("keep_original_resolution")]
            [Validation(Required=false)]
            public bool? KeepOriginalResolution { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("template_id")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
