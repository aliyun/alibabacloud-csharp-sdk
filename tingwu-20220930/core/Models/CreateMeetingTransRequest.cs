// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20220930.Models
{
    public class CreateMeetingTransRequest : TeaModel {
        [NameInMap("AbilityParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> AbilityParams { get; set; }

        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("AsrParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> AsrParams { get; set; }

        [NameInMap("AudioBitRate")]
        [Validation(Required=false)]
        public int? AudioBitRate { get; set; }

        [NameInMap("AudioFormat")]
        [Validation(Required=false)]
        public string AudioFormat { get; set; }

        [NameInMap("AudioLanguage")]
        [Validation(Required=false)]
        public string AudioLanguage { get; set; }

        [NameInMap("AudioOutputEnabled")]
        [Validation(Required=false)]
        public bool? AudioOutputEnabled { get; set; }

        [NameInMap("AudioOutputOssBucket")]
        [Validation(Required=false)]
        public string AudioOutputOssBucket { get; set; }

        [NameInMap("AudioOutputOssPath")]
        [Validation(Required=false)]
        public string AudioOutputOssPath { get; set; }

        [NameInMap("AudioPackage")]
        [Validation(Required=false)]
        public string AudioPackage { get; set; }

        [NameInMap("AudioSampleRate")]
        [Validation(Required=false)]
        public int? AudioSampleRate { get; set; }

        [NameInMap("AudioSegmentsEnabled")]
        [Validation(Required=false)]
        public bool? AudioSegmentsEnabled { get; set; }

        [NameInMap("DocResultEnabled")]
        [Validation(Required=false)]
        public bool? DocResultEnabled { get; set; }

        [NameInMap("LabParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> LabParams { get; set; }

        [NameInMap("MeetingKey")]
        [Validation(Required=false)]
        public string MeetingKey { get; set; }

        [NameInMap("MeetingResultEnabled")]
        [Validation(Required=false)]
        public bool? MeetingResultEnabled { get; set; }

        [NameInMap("MeetingResultOssBucket")]
        [Validation(Required=false)]
        public string MeetingResultOssBucket { get; set; }

        [NameInMap("MeetingResultOssPath")]
        [Validation(Required=false)]
        public string MeetingResultOssPath { get; set; }

        [NameInMap("RealtimeActiveResultLevel")]
        [Validation(Required=false)]
        public int? RealtimeActiveResultLevel { get; set; }

        [NameInMap("RealtimeResultEnabled")]
        [Validation(Required=false)]
        public bool? RealtimeResultEnabled { get; set; }

        [NameInMap("RealtimeResultLevel")]
        [Validation(Required=false)]
        public int? RealtimeResultLevel { get; set; }

        [NameInMap("RealtimeResultMeetingInfoEnabled")]
        [Validation(Required=false)]
        public bool? RealtimeResultMeetingInfoEnabled { get; set; }

        [NameInMap("RealtimeResultWordsEnabled")]
        [Validation(Required=false)]
        public bool? RealtimeResultWordsEnabled { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        [NameInMap("TranslateActiveResultLevel")]
        [Validation(Required=false)]
        public int? TranslateActiveResultLevel { get; set; }

        [NameInMap("TranslateLanguages")]
        [Validation(Required=false)]
        public string TranslateLanguages { get; set; }

        [NameInMap("TranslateResultEnabled")]
        [Validation(Required=false)]
        public bool? TranslateResultEnabled { get; set; }

        [NameInMap("TranslateResultLevel")]
        [Validation(Required=false)]
        public int? TranslateResultLevel { get; set; }

    }

}
