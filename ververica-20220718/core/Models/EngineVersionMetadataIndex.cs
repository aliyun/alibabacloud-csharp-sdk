// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class EngineVersionMetadataIndex : TeaModel {
        [NameInMap("defaultEngineVersion")]
        [Validation(Required=false)]
        public string DefaultEngineVersion { get; set; }

        [NameInMap("engineVersionMetadata")]
        [Validation(Required=false)]
        public List<EngineVersionMetadata> EngineVersionMetadata { get; set; }

    }

}
