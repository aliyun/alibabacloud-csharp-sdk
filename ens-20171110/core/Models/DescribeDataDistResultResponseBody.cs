// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataDistResultResponseBody : TeaModel {
        [NameInMap("DistResults")]
        [Validation(Required=false)]
        public DescribeDataDistResultResponseBodyDistResults DistResults { get; set; }
        public class DescribeDataDistResultResponseBodyDistResults : TeaModel {
            [NameInMap("DistResult")]
            [Validation(Required=false)]
            public List<DescribeDataDistResultResponseBodyDistResultsDistResult> DistResult { get; set; }
            public class DescribeDataDistResultResponseBodyDistResultsDistResult : TeaModel {
                public string Name { get; set; }
                public DescribeDataDistResultResponseBodyDistResultsDistResultStatusStats StatusStats { get; set; }
                public class DescribeDataDistResultResponseBodyDistResultsDistResultStatusStats : TeaModel {
                    [NameInMap("StatusStat")]
                    [Validation(Required=false)]
                    public List<DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStat> StatusStat { get; set; }
                    public class DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStat : TeaModel {
                        [NameInMap("InstanceCount")]
                        [Validation(Required=false)]
                        public string InstanceCount { get; set; }

                        [NameInMap("Instances")]
                        [Validation(Required=false)]
                        public DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStatInstances Instances { get; set; }
                        public class DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStatInstances : TeaModel {
                            [NameInMap("Instance")]
                            [Validation(Required=false)]
                            public List<DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStatInstancesInstance> Instance { get; set; }
                            public class DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStatInstancesInstance : TeaModel {
                                public string InstanceId { get; set; }
                                public string StartTime { get; set; }
                                public string StatusDescrip { get; set; }
                                public string UpdateTime { get; set; }
                            }
                        };

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }
                public string Version { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
