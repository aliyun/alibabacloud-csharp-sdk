// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeAccountsRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("LoginName")]
        [Validation(Required=false)]
        public string LoginName { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        [NameInMap("DepartId")]
        [Validation(Required=false)]
        public long? DepartId { get; set; }

        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public int? QueryType { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public int? OperationId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        [NameInMap("PackageId")]
        [Validation(Required=false)]
        public string PackageId { get; set; }

        [NameInMap("ColumnId")]
        [Validation(Required=false)]
        public string ColumnId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

    }

}
