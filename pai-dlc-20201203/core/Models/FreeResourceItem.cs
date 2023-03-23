// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class FreeResourceItem : TeaModel {
        [NameInMap("AvailableNumber")]
        [Validation(Required=false)]
        public long? AvailableNumber { get; set; }

        [NameInMap("ClusterID")]
        [Validation(Required=false)]
        public string ClusterID { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("FreeResourceId")]
        [Validation(Required=false)]
        public string FreeResourceId { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        [NameInMap("RegionID")]
        [Validation(Required=false)]
        public string RegionID { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
