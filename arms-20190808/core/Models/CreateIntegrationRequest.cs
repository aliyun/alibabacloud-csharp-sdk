// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateIntegrationRequest : TeaModel {
        [NameInMap("AutoRecover")]
        [Validation(Required=false)]
        public bool? AutoRecover { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("IntegrationName")]
        [Validation(Required=false)]
        public string IntegrationName { get; set; }

        [NameInMap("IntegrationProductType")]
        [Validation(Required=false)]
        public string IntegrationProductType { get; set; }

        [NameInMap("RecoverTime")]
        [Validation(Required=false)]
        public long? RecoverTime { get; set; }

    }

}
