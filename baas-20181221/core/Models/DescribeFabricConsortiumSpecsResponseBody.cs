// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeFabricConsortiumSpecsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeFabricConsortiumSpecsResponseBodyResult> Result { get; set; }
        public class DescribeFabricConsortiumSpecsResponseBodyResult : TeaModel {
            [NameInMap("SpecName")]
            [Validation(Required=false)]
            public string SpecName { get; set; }

            [NameInMap("SpecTitle")]
            [Validation(Required=false)]
            public string SpecTitle { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

    }

}
