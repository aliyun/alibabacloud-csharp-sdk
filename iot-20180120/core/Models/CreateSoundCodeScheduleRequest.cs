// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateSoundCodeScheduleRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=true)]
        public string EndDate { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=true)]
        public string Name { get; set; }

        [NameInMap("OpenType")]
        [Validation(Required=false)]
        public string OpenType { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=true)]
        public string StartDate { get; set; }

    }

}
