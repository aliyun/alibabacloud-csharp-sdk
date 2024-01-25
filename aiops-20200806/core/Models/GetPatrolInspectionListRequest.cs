// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class GetPatrolInspectionListRequest : TeaModel {
        [NameInMap("BusinessGroupId")]
        [Validation(Required=false)]
        public string BusinessGroupId { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PatrolId")]
        [Validation(Required=false)]
        public long? PatrolId { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

        [NameInMap("RiskName")]
        [Validation(Required=false)]
        public string RiskName { get; set; }

        [NameInMap("RiskPatrolItem")]
        [Validation(Required=false)]
        public string RiskPatrolItem { get; set; }

        [NameInMap("RiskType")]
        [Validation(Required=false)]
        public int? RiskType { get; set; }

        [NameInMap("SeverityLevel")]
        [Validation(Required=false)]
        public int? SeverityLevel { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
