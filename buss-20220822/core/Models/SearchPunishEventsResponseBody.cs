// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Buss20220822.Models
{
    public class SearchPunishEventsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<SearchPunishEventsResponseBodyDataList> DataList { get; set; }
        public class SearchPunishEventsResponseBodyDataList : TeaModel {
            [NameInMap("BussinessCode")]
            [Validation(Required=false)]
            public string BussinessCode { get; set; }

            [NameInMap("CaseCode")]
            [Validation(Required=false)]
            public string CaseCode { get; set; }

            [NameInMap("RecordsCount")]
            [Validation(Required=false)]
            public int? RecordsCount { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("TipsCode")]
            [Validation(Required=false)]
            public string TipsCode { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
