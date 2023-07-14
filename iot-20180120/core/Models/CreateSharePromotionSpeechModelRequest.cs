// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateSharePromotionSpeechModelRequest : TeaModel {
        [NameInMap("AudioFormat")]
        [Validation(Required=false)]
        public string AudioFormat { get; set; }

        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("SharePromotionActivityId")]
        [Validation(Required=false)]
        public string SharePromotionActivityId { get; set; }

        [NameInMap("ShareTaskCode")]
        [Validation(Required=false)]
        public string ShareTaskCode { get; set; }

        [NameInMap("SpeechModelType")]
        [Validation(Required=false)]
        public string SpeechModelType { get; set; }

        [NameInMap("SpeechRate")]
        [Validation(Required=false)]
        public int? SpeechRate { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("Voice")]
        [Validation(Required=false)]
        public string Voice { get; set; }

        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
