// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappTemplateMetricResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetChatappTemplateMetricResponseBodyData> Data { get; set; }
        public class GetChatappTemplateMetricResponseBodyData : TeaModel {
            [NameInMap("Cliented")]
            [Validation(Required=false)]
            public List<GetChatappTemplateMetricResponseBodyDataCliented> Cliented { get; set; }
            public class GetChatappTemplateMetricResponseBodyDataCliented : TeaModel {
                [NameInMap("ButtonContent")]
                [Validation(Required=false)]
                public string ButtonContent { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("DeliveredCount")]
            [Validation(Required=false)]
            public int? DeliveredCount { get; set; }

            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }

            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("ReadCount")]
            [Validation(Required=false)]
            public int? ReadCount { get; set; }

            [NameInMap("SentCount")]
            [Validation(Required=false)]
            public int? SentCount { get; set; }

            [NameInMap("Start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
