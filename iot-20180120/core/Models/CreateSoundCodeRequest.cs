// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateSoundCodeRequest : TeaModel {
        [NameInMap("Duration")]
        [Validation(Required=true)]
        public int? Duration { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OpenType")]
        [Validation(Required=false)]
        public string OpenType { get; set; }

        [NameInMap("SoundCodeContent")]
        [Validation(Required=true)]
        public string SoundCodeContent { get; set; }

    }

}
