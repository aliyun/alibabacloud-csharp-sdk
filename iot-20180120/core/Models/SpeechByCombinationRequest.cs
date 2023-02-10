// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class SpeechByCombinationRequest : TeaModel {
        [NameInMap("AudioFormat")]
        [Validation(Required=false)]
        public string AudioFormat { get; set; }

        [NameInMap("CombinationList")]
        [Validation(Required=false)]
        public List<string> CombinationList { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("EnforceFlag")]
        [Validation(Required=false)]
        public bool? EnforceFlag { get; set; }

        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("SpeechId")]
        [Validation(Required=false)]
        public string SpeechId { get; set; }

    }

}
