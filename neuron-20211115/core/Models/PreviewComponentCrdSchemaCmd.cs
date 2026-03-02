// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PreviewComponentCrdSchemaCmd : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("configuration")]
        [Validation(Required=false)]
        public List<ConfigModel> Configuration { get; set; }

        [NameInMap("credentials")]
        [Validation(Required=false)]
        public string Credentials { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("isCustom")]
        [Validation(Required=false)]
        public bool? IsCustom { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("reesourceVersion")]
        [Validation(Required=false)]
        public string ReesourceVersion { get; set; }

        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public long? ResourceId { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
