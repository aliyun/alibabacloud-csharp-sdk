// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListWarningStrategyConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWarningStrategyConfigResponseBodyData Data { get; set; }
        public class ListWarningStrategyConfigResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<ListWarningStrategyConfigResponseBodyDataData> Data { get; set; }
            public class ListWarningStrategyConfigResponseBodyDataData : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IntervalTime")]
                [Validation(Required=false)]
                public long? IntervalTime { get; set; }

                [NameInMap("Lambda")]
                [Validation(Required=false)]
                public string Lambda { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public long? Level { get; set; }

                [NameInMap("MaxNumber")]
                [Validation(Required=false)]
                public long? MaxNumber { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

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
