// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryCardSmsStatisticsListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public List<QueryCardSmsStatisticsListResponseBodyModel> Model { get; set; }
        public class QueryCardSmsStatisticsListResponseBodyModel : TeaModel {
            [NameInMap("RenderSuccessTotal")]
            [Validation(Required=false)]
            public long? RenderSuccessTotal { get; set; }

            [NameInMap("SendDate")]
            [Validation(Required=false)]
            public string SendDate { get; set; }

            [NameInMap("UrlGenerateTotal")]
            [Validation(Required=false)]
            public long? UrlGenerateTotal { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
