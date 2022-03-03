// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateSpeechRequest : TeaModel {
        [NameInMap("EnableSoundCode")]
        [Validation(Required=false)]
        public bool? EnableSoundCode { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProjectCode")]
        [Validation(Required=false)]
        public string ProjectCode { get; set; }

        [NameInMap("SoundCodeConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> SoundCodeConfig { get; set; }

        [NameInMap("SpeechCode")]
        [Validation(Required=false)]
        public string SpeechCode { get; set; }

        [NameInMap("SpeechRate")]
        [Validation(Required=false)]
        public int? SpeechRate { get; set; }

        [NameInMap("Voice")]
        [Validation(Required=false)]
        public string Voice { get; set; }

        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
