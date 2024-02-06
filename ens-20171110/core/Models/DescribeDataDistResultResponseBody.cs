// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataDistResultResponseBody : TeaModel {
        /// <summary>
        /// The distribution status of data files on edge instances.
        /// </summary>
        [NameInMap("DistResults")]
        [Validation(Required=false)]
        public DescribeDataDistResultResponseBodyDistResults DistResults { get; set; }
        public class DescribeDataDistResultResponseBodyDistResults : TeaModel {
            [NameInMap("DistResult")]
            [Validation(Required=false)]
            public List<DescribeDataDistResultResponseBodyDistResultsDistResult> DistResult { get; set; }
            public class DescribeDataDistResultResponseBodyDistResultsDistResult : TeaModel {
                /// <summary>
                /// The name of the data file.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The distribution status statistics.
                /// </summary>
                [NameInMap("StatusStats")]
                [Validation(Required=false)]
                public DescribeDataDistResultResponseBodyDistResultsDistResultStatusStats StatusStats { get; set; }
                public class DescribeDataDistResultResponseBodyDistResultsDistResultStatusStats : TeaModel {
                    [NameInMap("StatusStat")]
                    [Validation(Required=false)]
                    public List<DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStat> StatusStat { get; set; }
                    public class DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStat : TeaModel {
                        /// <summary>
                        /// The number of associated edge instances.
                        /// </summary>
                        [NameInMap("InstanceCount")]
                        [Validation(Required=false)]
                        public string InstanceCount { get; set; }

                        /// <summary>
                        /// The distribution status of the edge instance.
                        /// </summary>
                        [NameInMap("Instances")]
                        [Validation(Required=false)]
                        public DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStatInstances Instances { get; set; }
                        public class DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStatInstances : TeaModel {
                            [NameInMap("Instance")]
                            [Validation(Required=false)]
                            public List<DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStatInstancesInstance> Instance { get; set; }
                            public class DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStatInstancesInstance : TeaModel {
                                /// <summary>
                                /// The ID of the instance
                                /// </summary>
                                [NameInMap("InstanceId")]
                                [Validation(Required=false)]
                                public string InstanceId { get; set; }

                                /// <summary>
                                /// The start time of the distribution. The time is displayed in UTC.
                                /// </summary>
                                [NameInMap("StartTime")]
                                [Validation(Required=false)]
                                public string StartTime { get; set; }

                                /// <summary>
                                /// The description of the distribution status.
                                /// </summary>
                                [NameInMap("StatusDescrip")]
                                [Validation(Required=false)]
                                public string StatusDescrip { get; set; }

                                /// <summary>
                                /// The time when the distribution status was last updated. The time is displayed in UTC.
                                /// </summary>
                                [NameInMap("UpdateTime")]
                                [Validation(Required=false)]
                                public string UpdateTime { get; set; }

                            }

                        }

                        /// <summary>
                        /// The distribution status. The value is of the enumeration type. Valid values:
                        /// 
                        /// *   SUCCESS: The distribution is successful.
                        /// *   FAILED: The distribution failed.
                        /// *   DISTING: The data is being distributed.
                        /// *   POD_RESTARTING: The idle pod is being restarted.
                        /// *   DELETED: The data is cleared or removed.
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// The version number of the data file.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
