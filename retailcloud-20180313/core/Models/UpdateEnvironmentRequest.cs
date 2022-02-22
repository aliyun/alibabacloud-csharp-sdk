// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class UpdateEnvironmentRequest : TeaModel {
        [NameInMap("AppEnvId")]
        [Validation(Required=false)]
        public long? AppEnvId { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("AppSchemaId")]
        [Validation(Required=false)]
        public long? AppSchemaId { get; set; }

        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

    }

}
