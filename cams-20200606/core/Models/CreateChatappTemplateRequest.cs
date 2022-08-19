// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatappTemplateRequest : TeaModel {
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<CreateChatappTemplateRequestComponents> Components { get; set; }
        public class CreateChatappTemplateRequestComponents : TeaModel {
            [NameInMap("Buttons")]
            [Validation(Required=false)]
            public List<CreateChatappTemplateRequestComponentsButtons> Buttons { get; set; }
            public class CreateChatappTemplateRequestComponentsButtons : TeaModel {
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("UrlType")]
                [Validation(Required=false)]
                public string UrlType { get; set; }

            }

            [NameInMap("Caption")]
            [Validation(Required=false)]
            public string Caption { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        public string CustWabaId { get; set; }

        [NameInMap("Example")]
        [Validation(Required=false)]
        public Dictionary<string, string> Example { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
