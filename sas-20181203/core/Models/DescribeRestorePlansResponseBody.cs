// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRestorePlansResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeRestorePlansResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeRestorePlansResponseBodyPageInfo : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
        };

        [NameInMap("RestorePlans")]
        [Validation(Required=false)]
        public List<DescribeRestorePlansResponseBodyRestorePlans> RestorePlans { get; set; }
        public class DescribeRestorePlansResponseBodyRestorePlans : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("RestorePoint")]
            [Validation(Required=false)]
            public long? RestorePoint { get; set; }

            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("TargetInstanceName")]
            [Validation(Required=false)]
            public string TargetInstanceName { get; set; }

            [NameInMap("TargetDatabaseName")]
            [Validation(Required=false)]
            public string TargetDatabaseName { get; set; }

            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

        }

    }

}
