// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstancesShrinkRequest : TeaModel {
        [NameInMap("DBInstanceCategories")]
        [Validation(Required=false)]
        public string DBInstanceCategoriesShrink { get; set; }

        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        [NameInMap("DBInstanceIds")]
        [Validation(Required=false)]
        public string DBInstanceIds { get; set; }

        [NameInMap("DBInstanceModes")]
        [Validation(Required=false)]
        public string DBInstanceModesShrink { get; set; }

        [NameInMap("DBInstanceStatuses")]
        [Validation(Required=false)]
        public string DBInstanceStatusesShrink { get; set; }

        [NameInMap("InstanceDeployTypes")]
        [Validation(Required=false)]
        public string InstanceDeployTypesShrink { get; set; }

        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDBInstancesShrinkRequestTag> Tag { get; set; }
        public class DescribeDBInstancesShrinkRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
