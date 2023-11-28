// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class RestartLogstashRequest : TeaModel {
        [NameInMap("batchCount")]
        [Validation(Required=false)]
        public double? BatchCount { get; set; }

        [NameInMap("blueGreenDep")]
        [Validation(Required=false)]
        public bool? BlueGreenDep { get; set; }

        [NameInMap("nodeTypes")]
        [Validation(Required=false)]
        public List<string> NodeTypes { get; set; }

        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        [NameInMap("restartType")]
        [Validation(Required=false)]
        public string RestartType { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
