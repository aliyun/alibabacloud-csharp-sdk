// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataDistResultResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("DistResults")]
        [Validation(Required=true)]
        public DescribeDataDistResultResponseDistResults DistResults { get; set; }
        public class DescribeDataDistResultResponseDistResults : TeaModel {
            [NameInMap("DistResult")]
            [Validation(Required=true)]
            public List<DescribeDataDistResultResponseDistResultsDistResult> DistResult { get; set; }
            public class DescribeDataDistResultResponseDistResultsDistResult : TeaModel {
                public string Version { get; set; }
                public string Name { get; set; }
                public DescribeDataDistResultResponseDistResultsDistResultStatusStats StatusStats { get; set; }
                public class DescribeDataDistResultResponseDistResultsDistResultStatusStats : TeaModel {
                    [NameInMap("StatusStat")]
                    [Validation(Required=true)]
                    public List<DescribeDataDistResultResponseDistResultsDistResultStatusStatsStatusStat> StatusStat { get; set; }
                    public class DescribeDataDistResultResponseDistResultsDistResultStatusStatsStatusStat : TeaModel {
                        [NameInMap("Status")]
                        [Validation(Required=true)]
                        public string Status { get; set; }

                        [NameInMap("InstanceCount")]
                        [Validation(Required=true)]
                        public string InstanceCount { get; set; }

                        [NameInMap("Instances")]
                        [Validation(Required=true)]
                        public DescribeDataDistResultResponseDistResultsDistResultStatusStatsStatusStatInstances Instances { get; set; }
                        public class DescribeDataDistResultResponseDistResultsDistResultStatusStatsStatusStatInstances : TeaModel {
                            [NameInMap("Instance")]
                            [Validation(Required=true)]
                            public List<DescribeDataDistResultResponseDistResultsDistResultStatusStatsStatusStatInstancesInstance> Instance { get; set; }
                            public class DescribeDataDistResultResponseDistResultsDistResultStatusStatsStatusStatInstancesInstance : TeaModel {
                                public string InstanceId { get; set; }
                                public string StartTime { get; set; }
                                public string UpdateTime { get; set; }
                                public string StatusDescrip { get; set; }
                            }
                        };

                    }

                }
            }
        };

    }

}
