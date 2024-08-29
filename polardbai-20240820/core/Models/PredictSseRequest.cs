// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PolardbAI20240820.Models
{
    public class PredictSseRequest : TeaModel {
        [NameInMap("dbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("modelClass")]
        [Validation(Required=false)]
        public string ModelClass { get; set; }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

    }

}
