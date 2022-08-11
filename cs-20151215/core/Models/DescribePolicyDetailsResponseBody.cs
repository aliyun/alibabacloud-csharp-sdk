// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyDetailsResponseBody : TeaModel {
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("is_deleted")]
        [Validation(Required=false)]
        public int? IsDeleted { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("no_config")]
        [Validation(Required=false)]
        public int? NoConfig { get; set; }

        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        [NameInMap("template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
