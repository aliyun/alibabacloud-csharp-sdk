// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20180418.Models
{
    public class DescribeClustersQuery : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("clusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

    }

}
