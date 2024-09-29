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
            /// <summary>
            /// <b>Example:</b>
            /// <para>Car</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("textModeTypes")]
            [Validation(Required=false)]
            public List<GetTextTemplateResponseBodyAvailableIndustryTextModeTypes> TextModeTypes { get; set; }
            public class GetTextTemplateResponseBodyAvailableIndustryTextModeTypes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Rewrite</para>
                /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>RED_BOOK</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>111</para>
                    /// </summary>
                    [NameInMap("templateKey")]
                    [Validation(Required=false)]
                    public string TemplateKey { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3239281273464326823</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
