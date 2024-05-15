// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TemplateDTO : TeaModel {
        [NameInMap("Classify")]
        [Validation(Required=false)]
        public string Classify { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, object> Exif { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("QuestionConfigs")]
        [Validation(Required=false)]
        public List<QuestionPlugin> QuestionConfigs { get; set; }

        [NameInMap("RobotConfigs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> RobotConfigs { get; set; }

        [NameInMap("SharedMode")]
        [Validation(Required=false)]
        public string SharedMode { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ViewConfigs")]
        [Validation(Required=false)]
        public TemplateDTOViewConfigs ViewConfigs { get; set; }
        public class TemplateDTOViewConfigs : TeaModel {
            [NameInMap("ViewPlugins")]
            [Validation(Required=false)]
            public List<ViewPlugin> ViewPlugins { get; set; }

        }

    }

}
