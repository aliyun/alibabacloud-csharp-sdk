// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateAlertRequest : TeaModel {
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public AlertConfiguration Configuration { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("schedule")]
        [Validation(Required=false)]
        public Schedule Schedule { get; set; }

    }

}
