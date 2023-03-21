// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInstanceCatalogRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequirementIds")]
        [Validation(Required=false)]
        public List<long?> RequirementIds { get; set; }

        [NameInMap("StandardIds")]
        [Validation(Required=false)]
        public List<long?> StandardIds { get; set; }

        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

    }

}
