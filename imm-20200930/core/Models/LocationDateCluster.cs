// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class LocationDateCluster : TeaModel {
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<Address> Addresses { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        [NameInMap("LocationDateClusterEndTime")]
        [Validation(Required=false)]
        public string LocationDateClusterEndTime { get; set; }

        [NameInMap("LocationDateClusterLevel")]
        [Validation(Required=false)]
        public string LocationDateClusterLevel { get; set; }

        [NameInMap("LocationDateClusterStartTime")]
        [Validation(Required=false)]
        public string LocationDateClusterStartTime { get; set; }

        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
