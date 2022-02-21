// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ApplyTagPoliciesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ApplyTagPoliciesResponseBodyData> Data { get; set; }
        public class ApplyTagPoliciesResponseBodyData : TeaModel {
            [NameInMap("CarryData")]
            [Validation(Required=false)]
            public bool? CarryData { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceNum")]
            [Validation(Required=false)]
            public int? InstanceNum { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Rate")]
            [Validation(Required=false)]
            public int? Rate { get; set; }

            [NameInMap("Remove")]
            [Validation(Required=false)]
            public bool? Remove { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public string Rules { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
