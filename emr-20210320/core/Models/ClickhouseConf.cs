// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ClickhouseConf : TeaModel {
        [NameInMap("InitialReplica")]
        [Validation(Required=false)]
        public int? InitialReplica { get; set; }

        [NameInMap("InitialShard")]
        [Validation(Required=false)]
        public int? InitialShard { get; set; }

        [NameInMap("NewNodeCount")]
        [Validation(Required=false)]
        public int? NewNodeCount { get; set; }

        [NameInMap("ResizeType")]
        [Validation(Required=false)]
        public string ResizeType { get; set; }

    }

}
