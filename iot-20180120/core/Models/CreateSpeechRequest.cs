// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateSpeechRequest : TeaModel {
        [NameInMap("AudioFormat")]
        [Validation(Required=false)]
        public string AudioFormat { get; set; }

        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("EnableSoundCode")]
        [Validation(Required=false)]
        public bool? EnableSoundCode { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProjectCode")]
        [Validation(Required=true)]
        public string ProjectCode { get; set; }

        [NameInMap("SoundCodeConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> SoundCodeConfig { get; set; }

        [NameInMap("SpeechRate")]
        [Validation(Required=false)]
        public int? SpeechRate { get; set; }

        [NameInMap("SpeechType")]
        [Validation(Required=false)]
        public string SpeechType { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("Voice")]
        [Validation(Required=true)]
        public string Voice { get; set; }

        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
