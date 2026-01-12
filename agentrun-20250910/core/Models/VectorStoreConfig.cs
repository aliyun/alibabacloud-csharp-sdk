// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class VectorStoreConfig : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public VectorStoreConfigConfig Config { get; set; }
        public class VectorStoreConfigConfig : TeaModel {
            [NameInMap("collectionName")]
            [Validation(Required=false)]
            public string CollectionName { get; set; }

            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("instanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("vectorDimension")]
            [Validation(Required=false)]
            public int? VectorDimension { get; set; }

        }

        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

    }

}
