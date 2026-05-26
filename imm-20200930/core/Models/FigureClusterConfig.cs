// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FigureClusterConfig : TeaModel {
        [NameInMap("AutoClustering")]
        [Validation(Required=false)]
        public bool? AutoClustering { get; set; }

        [NameInMap("AutoGenerate")]
        [Validation(Required=false)]
        public bool? AutoGenerate { get; set; }

        [NameInMap("EnabledFeatures")]
        [Validation(Required=false)]
        public List<string> EnabledFeatures { get; set; }

        [NameInMap("MinEntityCount")]
        [Validation(Required=false)]
        public long? MinEntityCount { get; set; }

    }

}
