// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryCardSmsStatisticsSendListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public List<QueryCardSmsStatisticsSendListResponseBodyModel> Model { get; set; }
        public class QueryCardSmsStatisticsSendListResponseBodyModel : TeaModel {
            [NameInMap("RenderSuccessRate")]
            [Validation(Required=false)]
            public double? RenderSuccessRate { get; set; }

            [NameInMap("RenderSuccessTotal")]
            [Validation(Required=false)]
            public long? RenderSuccessTotal { get; set; }

            [NameInMap("SendDate")]
            [Validation(Required=false)]
            public string SendDate { get; set; }

            [NameInMap("SendFailTotal")]
            [Validation(Required=false)]
            public long? SendFailTotal { get; set; }

            [NameInMap("SendProcessTotal")]
            [Validation(Required=false)]
            public long? SendProcessTotal { get; set; }

            [NameInMap("SendSuccessRate")]
            [Validation(Required=false)]
            public double? SendSuccessRate { get; set; }

            [NameInMap("SendSuccessTotal")]
            [Validation(Required=false)]
            public long? SendSuccessTotal { get; set; }

            [NameInMap("SendTotal")]
            [Validation(Required=false)]
            public long? SendTotal { get; set; }

            [NameInMap("SupportRate")]
            [Validation(Required=false)]
            public double? SupportRate { get; set; }

            [NameInMap("SupportTotal")]
            [Validation(Required=false)]
            public long? SupportTotal { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
