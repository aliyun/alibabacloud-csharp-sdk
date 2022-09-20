// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TaskTemplateConfig : TeaModel {
        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, string> Exif { get; set; }

        [NameInMap("ResourceKey")]
        [Validation(Required=false)]
        public string ResourceKey { get; set; }

        [NameInMap("SelectQuestions")]
        [Validation(Required=false)]
        public List<string> SelectQuestions { get; set; }

        [NameInMap("TemplateOptionMap")]
        [Validation(Required=false)]
        public Dictionary<string, TaskTemplateOptionConfig> TemplateOptionMap { get; set; }

        [NameInMap("TemplateRelationId")]
        [Validation(Required=false)]
        public string TemplateRelationId { get; set; }

    }

}
