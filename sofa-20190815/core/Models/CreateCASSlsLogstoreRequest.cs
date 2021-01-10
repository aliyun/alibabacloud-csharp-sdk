// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateCASSlsLogstoreRequest : TeaModel {
        [NameInMap("LogstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public long? ShardCount { get; set; }

        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public long? Ttl { get; set; }

    }

}
