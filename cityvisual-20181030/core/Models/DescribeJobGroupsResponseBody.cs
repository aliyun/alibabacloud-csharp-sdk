// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class DescribeJobGroupsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("JobGroups")]
        [Validation(Required=false)]
        public DescribeJobGroupsResponseBodyJobGroups JobGroups { get; set; }
        public class DescribeJobGroupsResponseBodyJobGroups : TeaModel {
            [NameInMap("JobGroup")]
            [Validation(Required=false)]
            public List<DescribeJobGroupsResponseBodyJobGroupsJobGroup> JobGroup { get; set; }
            public class DescribeJobGroupsResponseBodyJobGroupsJobGroup : TeaModel {
                public string Status { get; set; }
                public string JobGroupId { get; set; }
                public string AlgoLibId { get; set; }
                public int? JobCount { get; set; }
                public string JobGroupName { get; set; }
                public DescribeJobGroupsResponseBodyJobGroupsJobGroupJobGroupParams JobGroupParams { get; set; }
                public class DescribeJobGroupsResponseBodyJobGroupsJobGroupJobGroupParams : TeaModel {
                    [NameInMap("JobGroupParam")]
                    [Validation(Required=false)]
                    public List<DescribeJobGroupsResponseBodyJobGroupsJobGroupJobGroupParamsJobGroupParam> JobGroupParam { get; set; }
                    public class DescribeJobGroupsResponseBodyJobGroupsJobGroupJobGroupParamsJobGroupParam : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string ResourceProfileId { get; set; }
                public int? StreamPerJob { get; set; }
                public int? PlanedJobCount { get; set; }
                public DescribeJobGroupsResponseBodyJobGroupsJobGroupComputeJobs ComputeJobs { get; set; }
                public class DescribeJobGroupsResponseBodyJobGroupsJobGroupComputeJobs : TeaModel {
                    [NameInMap("ComputeJob")]
                    [Validation(Required=false)]
                    public List<DescribeJobGroupsResponseBodyJobGroupsJobGroupComputeJobsComputeJob> ComputeJob { get; set; }
                    public class DescribeJobGroupsResponseBodyJobGroupsJobGroupComputeJobsComputeJob : TeaModel {
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("ComputeJobName")]
                        [Validation(Required=false)]
                        public string ComputeJobName { get; set; }

                        [NameInMap("ComputeJobId")]
                        [Validation(Required=false)]
                        public string ComputeJobId { get; set; }

                        [NameInMap("ComputeJobStatus")]
                        [Validation(Required=false)]
                        public string ComputeJobStatus { get; set; }

                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public int? Duration { get; set; }

                    }

                }
            }
        };

    }

}
