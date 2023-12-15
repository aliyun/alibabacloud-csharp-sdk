// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class ExecuteNodeToolRequest : TeaModel {
        [NameInMap("Arguments")]
        [Validation(Required=false)]
        public string Arguments { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        [NameInMap("DataCenterId")]
        [Validation(Required=false)]
        public string DataCenterId { get; set; }

        [NameInMap("ExecuteNodes")]
        [Validation(Required=false)]
        public string ExecuteNodes { get; set; }

    }

}
