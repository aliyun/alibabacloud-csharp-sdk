// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeCcTotalFwResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

        [NameInMap("FwTotalInfoList")]
        [Validation(Required=false)]
        public List<DescribeCcTotalFwResponseBodyFwTotalInfoList> FwTotalInfoList { get; set; }
        public class DescribeCcTotalFwResponseBodyFwTotalInfoList : TeaModel {
            [NameInMap("InWhiteList")]
            [Validation(Required=false)]
            public bool? InWhiteList { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public string AttackType { get; set; }

            [NameInMap("InBlackList")]
            [Validation(Required=false)]
            public bool? InBlackList { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("SourceLocation")]
            [Validation(Required=false)]
            public string SourceLocation { get; set; }

        }

    }

}
