// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class StatisticsResources : TeaModel {
        [NameInMap("CPU")]
        [Validation(Required=false)]
        public string CPU { get; set; }

        [NameInMap("GPU")]
        [Validation(Required=false)]
        public string GPU { get; set; }

        [NameInMap("HyperNodeNum")]
        [Validation(Required=false)]
        public long? HyperNodeNum { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

        [NameInMap("NodeNum")]
        [Validation(Required=false)]
        public long? NodeNum { get; set; }

    }

}
