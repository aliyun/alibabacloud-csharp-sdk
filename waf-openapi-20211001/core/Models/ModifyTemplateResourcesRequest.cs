// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyTemplateResourcesRequest : TeaModel {
        [NameInMap("BindResourceGroups")]
        [Validation(Required=false)]
        public List<string> BindResourceGroups { get; set; }

        [NameInMap("BindResources")]
        [Validation(Required=false)]
        public List<string> BindResources { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        [NameInMap("UnbindResourceGroups")]
        [Validation(Required=false)]
        public List<string> UnbindResourceGroups { get; set; }

        [NameInMap("UnbindResources")]
        [Validation(Required=false)]
        public List<string> UnbindResources { get; set; }

    }

}
