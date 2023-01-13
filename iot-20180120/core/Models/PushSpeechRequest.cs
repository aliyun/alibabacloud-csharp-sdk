// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class PushSpeechRequest : TeaModel {
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("ProjectCode")]
        [Validation(Required=true)]
        public string ProjectCode { get; set; }

        [NameInMap("PushMode")]
        [Validation(Required=true)]
        public string PushMode { get; set; }

        [NameInMap("SpeechCodeList")]
        [Validation(Required=true)]
        public List<string> SpeechCodeList { get; set; }

    }

}
