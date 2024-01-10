// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListTemplatesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used to retrieve the next page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The metadata of the template.
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<ListTemplatesResponseBodyTemplates> Templates { get; set; }
        public class ListTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// The type of the template.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The constraints of template
            /// </summary>
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public string Constraints { get; set; }

            /// <summary>
            /// The user who created the template.
            /// </summary>
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// The time when the template was created.
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// The description of the template.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether the template is configured with a trigger.
            /// </summary>
            [NameInMap("HasTrigger")]
            [Validation(Required=false)]
            public bool? HasTrigger { get; set; }

            /// <summary>
            /// The SHA-256 value of the template content.
            /// </summary>
            [NameInMap("Hash")]
            [Validation(Required=false)]
            public string Hash { get; set; }

            /// <summary>
            /// The template is favorite or not.
            /// </summary>
            [NameInMap("IsFavorite")]
            [Validation(Required=false)]
            public bool? IsFavorite { get; set; }

            /// <summary>
            /// The popularity of the public template. Valid values: **1-10**. A greater value indicates higher popularity. If the **ShareType** parameter is set to **Private**, the value of this parameter is `-1`.
            /// 
            /// **Notes** This parameter is valid only if the value of the **ShareType** parameter is set to **Public**.
            /// </summary>
            [NameInMap("Popularity")]
            [Validation(Required=false)]
            public int? Popularity { get; set; }

            /// <summary>
            /// The publisher of template.
            /// </summary>
            [NameInMap("Publisher")]
            [Validation(Required=false)]
            public string Publisher { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The share type of the template. The share type of the template that you create is **Private**. Valid values:
            /// 
            /// *   **Public**
            /// *   **Private**
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// The tag keys and values. The number of key-value pairs ranges from 1 to 20.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// The format of the template. The system automatically determines whether the format is JSON or YAML.
            /// </summary>
            [NameInMap("TemplateFormat")]
            [Validation(Required=false)]
            public string TemplateFormat { get; set; }

            /// <summary>
            /// The ID of the template.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// The name of the template.
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// The type of the template.
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// The version of the template. The name of the version consists of the letter v and a number. The number starts from 1.
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// The number of times for which the private template is executed. If the **ShareType** parameter is set to **Public**, the value of this parameter is `-1`.
            /// **Notes** This parameter is valid only if the **ShareType** parameter is set to **Private**.
            /// </summary>
            [NameInMap("TotalExecutionCount")]
            [Validation(Required=false)]
            public int? TotalExecutionCount { get; set; }

            /// <summary>
            /// The user who last updated the template.
            /// </summary>
            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

            /// <summary>
            /// The time when the template was last updated.
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

        }

    }

}
