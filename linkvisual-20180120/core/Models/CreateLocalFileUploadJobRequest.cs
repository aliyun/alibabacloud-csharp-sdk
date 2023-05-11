// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class CreateLocalFileUploadJobRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("TimeSlot")]
        [Validation(Required=false)]
        public List<CreateLocalFileUploadJobRequestTimeSlot> TimeSlot { get; set; }
        public class CreateLocalFileUploadJobRequestTimeSlot : TeaModel {
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

        }

    }

}
