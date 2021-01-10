// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class CreateStatisticsRecordRequest : TeaModel {
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public int? DeviceType { get; set; }

        [NameInMap("BeginAt")]
        [Validation(Required=false)]
        public string BeginAt { get; set; }

        [NameInMap("EndAt")]
        [Validation(Required=false)]
        public string EndAt { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
