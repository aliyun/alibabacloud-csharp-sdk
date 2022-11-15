// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class QueryLocationDateClustersShrinkRequest : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string AddressShrink { get; set; }

        [NameInMap("CreateTimeRange")]
        [Validation(Required=false)]
        public string CreateTimeRangeShrink { get; set; }

        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public string CustomLabels { get; set; }

        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("LocationDateClusterEndTimeRange")]
        [Validation(Required=false)]
        public string LocationDateClusterEndTimeRangeShrink { get; set; }

        [NameInMap("LocationDateClusterLevels")]
        [Validation(Required=false)]
        public string LocationDateClusterLevelsShrink { get; set; }

        [NameInMap("LocationDateClusterStartTimeRange")]
        [Validation(Required=false)]
        public string LocationDateClusterStartTimeRangeShrink { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UpdateTimeRange")]
        [Validation(Required=false)]
        public string UpdateTimeRangeShrink { get; set; }

    }

}
