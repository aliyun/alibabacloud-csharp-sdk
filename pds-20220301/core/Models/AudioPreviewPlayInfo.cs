// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AudioPreviewPlayInfo : TeaModel {
        [NameInMap("meta")]
        [Validation(Required=false)]
        public AudioPreviewPlayInfoMeta Meta { get; set; }
        public class AudioPreviewPlayInfoMeta : TeaModel {
            [NameInMap("duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

        }

        [NameInMap("offline_audio_list")]
        [Validation(Required=false)]
        public List<AudioPreviewPlayInfoOfflineAudioList> OfflineAudioList { get; set; }
        public class AudioPreviewPlayInfoOfflineAudioList : TeaModel {
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
