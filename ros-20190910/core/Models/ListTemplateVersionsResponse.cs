// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListTemplateVersionsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("Versions")]
        [Validation(Required=true)]
        public List<ListTemplateVersionsResponseVersions> Versions { get; set; }
        public class ListTemplateVersionsResponseVersions : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=true)]
            public string UpdateTime { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=true)]
            public string TemplateId { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=true)]
            public string TemplateName { get; set; }

            [NameInMap("TemplateVersion")]
            [Validation(Required=true)]
            public string TemplateVersion { get; set; }

            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }

        }

    }

}
