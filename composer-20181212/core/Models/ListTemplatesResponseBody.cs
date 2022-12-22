// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class ListTemplatesResponseBody : TeaModel {
        /// <summary>
        /// The unique identifier of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// A list of templates.
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<ListTemplatesResponseBodyTemplates> Templates { get; set; }
        public class ListTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// The time when the template was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// A list of connectors that are used in the template. The connectors are separated by commas.
            /// </summary>
            [NameInMap("TemplateConnector")]
            [Validation(Required=false)]
            public string TemplateConnector { get; set; }

            /// <summary>
            /// The publisher of the template.
            /// </summary>
            [NameInMap("TemplateCreator")]
            [Validation(Required=false)]
            public string TemplateCreator { get; set; }

            /// <summary>
            /// A brief introduction to the template.
            /// </summary>
            [NameInMap("TemplateDescription")]
            [Validation(Required=false)]
            public string TemplateDescription { get; set; }

            /// <summary>
            /// The ID of the template.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// The language that is used in the template. Chinese and English are supported.
            /// </summary>
            [NameInMap("TemplateLocale")]
            [Validation(Required=false)]
            public string TemplateLocale { get; set; }

            /// <summary>
            /// The name of the template.
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// An overview of the template, which is a JSON string.
            /// </summary>
            [NameInMap("TemplateOverview")]
            [Validation(Required=false)]
            public string TemplateOverview { get; set; }

            /// <summary>
            /// A description of the template.
            /// </summary>
            [NameInMap("TemplateSummary")]
            [Validation(Required=false)]
            public string TemplateSummary { get; set; }

            /// <summary>
            /// A brief introduction to the template.
            /// </summary>
            [NameInMap("TemplateSummaryEn")]
            [Validation(Required=false)]
            public string TemplateSummaryEn { get; set; }

            /// <summary>
            /// The tag of the template.
            /// </summary>
            [NameInMap("TemplateTag")]
            [Validation(Required=false)]
            public string TemplateTag { get; set; }

            /// <summary>
            /// The version of the template, which is a number that increments from 0.
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public int? TemplateVersion { get; set; }

            /// <summary>
            /// The time when the template was last updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The total number of templates.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
