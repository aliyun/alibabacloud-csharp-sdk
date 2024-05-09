// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ReindexRequest : TeaModel {
        [NameInMap("dataTimeSec")]
        [Validation(Required=false)]
        public int? DataTimeSec { get; set; }

        [NameInMap("ossDataPath")]
        [Validation(Required=false)]
        public string OssDataPath { get; set; }

        [NameInMap("partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

    }

}
