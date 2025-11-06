// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaCluster : TeaModel {
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<DataSource> DataSources { get; set; }

        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public Dictionary<string, string> Endpoints { get; set; }

        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
