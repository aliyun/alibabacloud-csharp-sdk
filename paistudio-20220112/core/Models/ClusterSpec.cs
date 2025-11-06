// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ClusterSpec : TeaModel {
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<DataSource> DataSources { get; set; }

        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

    }

}
