// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateSoundCodeRequest : TeaModel {
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("SoundCode")]
        [Validation(Required=false)]
        public string SoundCode { get; set; }

        [NameInMap("SoundCodeContent")]
        [Validation(Required=false)]
        public string SoundCodeContent { get; set; }

    }

}
