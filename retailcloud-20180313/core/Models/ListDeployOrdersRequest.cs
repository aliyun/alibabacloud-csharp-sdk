// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ListDeployOrdersRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("DeployCategory")]
        [Validation(Required=false)]
        public string DeployCategory { get; set; }

        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        [NameInMap("EndTimeGreaterThan")]
        [Validation(Required=false)]
        public string EndTimeGreaterThan { get; set; }

        [NameInMap("EndTimeGreaterThanOrEqualTo")]
        [Validation(Required=false)]
        public string EndTimeGreaterThanOrEqualTo { get; set; }

        [NameInMap("EndTimeLessThan")]
        [Validation(Required=false)]
        public string EndTimeLessThan { get; set; }

        [NameInMap("EndTimeLessThanOrEqualTo")]
        [Validation(Required=false)]
        public string EndTimeLessThanOrEqualTo { get; set; }

        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public long? EnvId { get; set; }

        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PartitionType")]
        [Validation(Required=false)]
        public string PartitionType { get; set; }

        [NameInMap("PauseType")]
        [Validation(Required=false)]
        public string PauseType { get; set; }

        [NameInMap("ResultList")]
        [Validation(Required=false)]
        public List<int?> ResultList { get; set; }

        [NameInMap("StartTimeGreaterThan")]
        [Validation(Required=false)]
        public string StartTimeGreaterThan { get; set; }

        [NameInMap("StartTimeGreaterThanOrEqualTo")]
        [Validation(Required=false)]
        public string StartTimeGreaterThanOrEqualTo { get; set; }

        [NameInMap("StartTimeLessThan")]
        [Validation(Required=false)]
        public string StartTimeLessThan { get; set; }

        [NameInMap("StartTimeLessThanOrEqualTo")]
        [Validation(Required=false)]
        public string StartTimeLessThanOrEqualTo { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<int?> StatusList { get; set; }

    }

}
