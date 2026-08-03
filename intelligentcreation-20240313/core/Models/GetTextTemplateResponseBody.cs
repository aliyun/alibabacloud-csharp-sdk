// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class GetTextTemplateResponseBody : TeaModel {
        [NameInMap("availableIndustry")]
        [Validation(Required=false)]
        public GetTextTemplateResponseBodyAvailableIndustry AvailableIndustry { get; set; }
        public class GetTextTemplateResponseBodyAvailableIndustry : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("textModeTypes")]
            [Validation(Required=false)]
            public List<GetTextTemplateResponseBodyAvailableIndustryTextModeTypes> TextModeTypes { get; set; }
            public class GetTextTemplateResponseBodyAvailableIndustryTextModeTypes : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("textStyles")]
                [Validation(Required=false)]
                public List<GetTextTemplateResponseBodyAvailableIndustryTextModeTypesTextStyles> TextStyles { get; set; }
                public class GetTextTemplateResponseBodyAvailableIndustryTextModeTypesTextStyles : TeaModel {
                    [NameInMap("desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    [NameInMap("disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("templateKey")]
                    [Validation(Required=false)]
                    public string TemplateKey { get; set; }

                }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
