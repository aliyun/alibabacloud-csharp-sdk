// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class GetQueueSubmissionStatisticInfoRequest : TeaModel {
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("FromDatetime")]
        [Validation(Required=false)]
        public string FromDatetime { get; set; }

        [NameInMap("ToDatetime")]
        [Validation(Required=false)]
        public string ToDatetime { get; set; }

        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        [NameInMap("FinalStatus")]
        [Validation(Required=false)]
        public string FinalStatus { get; set; }

    }

}
