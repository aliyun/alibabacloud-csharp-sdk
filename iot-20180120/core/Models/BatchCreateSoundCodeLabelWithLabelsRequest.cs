// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchCreateSoundCodeLabelWithLabelsRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=true)]
        public List<string> Labels { get; set; }

        [NameInMap("ScheduleCode")]
        [Validation(Required=true)]
        public string ScheduleCode { get; set; }

    }

}
