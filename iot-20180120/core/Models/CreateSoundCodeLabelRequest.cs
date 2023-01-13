// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateSoundCodeLabelRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("Label")]
        [Validation(Required=true)]
        public string Label { get; set; }

        [NameInMap("ScheduleCode")]
        [Validation(Required=true)]
        public string ScheduleCode { get; set; }

    }

}
