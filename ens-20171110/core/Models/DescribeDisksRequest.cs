// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDisksRequest : TeaModel {
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("DiskChargeType")]
        [Validation(Required=false)]
        public string DiskChargeType { get; set; }

        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public string DiskIds { get; set; }

        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public string EnsRegionIds { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OrderByParams")]
        [Validation(Required=false)]
        public string OrderByParams { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
