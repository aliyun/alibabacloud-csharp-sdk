// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckResultRequest : TeaModel {
        [NameInMap("CheckKey")]
        [Validation(Required=false)]
        public string CheckKey { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequirementIds")]
        [Validation(Required=false)]
        public List<long?> RequirementIds { get; set; }

        [NameInMap("RiskLevels")]
        [Validation(Required=false)]
        public List<string> RiskLevels { get; set; }

        [NameInMap("SortTypes")]
        [Validation(Required=false)]
        public List<string> SortTypes { get; set; }

        [NameInMap("StandardIds")]
        [Validation(Required=false)]
        public List<long?> StandardIds { get; set; }

        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
