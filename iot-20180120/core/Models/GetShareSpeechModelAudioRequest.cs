// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetShareSpeechModelAudioRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ShareTaskId")]
        [Validation(Required=false)]
        public string ShareTaskId { get; set; }

        [NameInMap("SpeechModelCodeList")]
        [Validation(Required=false)]
        public List<string> SpeechModelCodeList { get; set; }

    }

}
