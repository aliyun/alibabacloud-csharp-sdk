// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeCcMaxFwResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FwMaxInfoList")]
        [Validation(Required=false)]
        public List<DescribeCcMaxFwResponseBodyFwMaxInfoList> FwMaxInfoList { get; set; }
        public class DescribeCcMaxFwResponseBodyFwMaxInfoList : TeaModel {
            [NameInMap("InWhiteList")]
            [Validation(Required=false)]
            public bool? InWhiteList { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            [NameInMap("DestPort")]
            [Validation(Required=false)]
            public int? DestPort { get; set; }

            [NameInMap("Action")]
            [Validation(Required=false)]
            public int? Action { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public int? Protocol { get; set; }

            [NameInMap("InBlackList")]
            [Validation(Required=false)]
            public bool? InBlackList { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
