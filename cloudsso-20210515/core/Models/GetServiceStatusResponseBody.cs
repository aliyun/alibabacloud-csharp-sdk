// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetServiceStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public GetServiceStatusResponseBodyServiceStatus ServiceStatus { get; set; }
        public class GetServiceStatusResponseBodyServiceStatus : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("PrerequisiteCheckResult")]
            [Validation(Required=false)]
            public string PrerequisiteCheckResult { get; set; }

            [NameInMap("RegionsInUse")]
            [Validation(Required=false)]
            public List<string> RegionsInUse { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
