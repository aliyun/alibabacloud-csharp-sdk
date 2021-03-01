// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertOrUpdateRegionRequest : TeaModel {
        [NameInMap("RegionTag")]
        [Validation(Required=false)]
        public string RegionTag { get; set; }

        [NameInMap("RegionName")]
        [Validation(Required=false)]
        public string RegionName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("DebugEnable")]
        [Validation(Required=false)]
        public bool? DebugEnable { get; set; }

    }

}
