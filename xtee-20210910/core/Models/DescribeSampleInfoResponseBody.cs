// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSampleInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeSampleInfoResponseBodyResultObject ResultObject { get; set; }
        public class DescribeSampleInfoResponseBodyResultObject : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("sampleTags")]
            [Validation(Required=false)]
            public string SampleTags { get; set; }

            [NameInMap("sampleType")]
            [Validation(Required=false)]
            public string SampleType { get; set; }

            [NameInMap("sampleValue")]
            [Validation(Required=false)]
            public string SampleValue { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
