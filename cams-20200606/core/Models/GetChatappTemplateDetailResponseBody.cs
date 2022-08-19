// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappTemplateDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetChatappTemplateDetailResponseBodyData Data { get; set; }
        public class GetChatappTemplateDetailResponseBodyData : TeaModel {
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<GetChatappTemplateDetailResponseBodyDataComponents> Components { get; set; }
            public class GetChatappTemplateDetailResponseBodyDataComponents : TeaModel {
                public List<GetChatappTemplateDetailResponseBodyDataComponentsButtons> Buttons { get; set; }
                public class GetChatappTemplateDetailResponseBodyDataComponentsButtons : TeaModel {
                    public string PhoneNumber { get; set; }
                    public string Text { get; set; }
                    public string Type { get; set; }
                    public string Url { get; set; }
                    public string UrlType { get; set; }
                }
                public string Caption { get; set; }
                public string FileName { get; set; }
                public string Format { get; set; }
                public string Text { get; set; }
                public string Type { get; set; }
                public string Url { get; set; }
            }
            [NameInMap("Example")]
            [Validation(Required=false)]
            public Dictionary<string, string> Example { get; set; }
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
