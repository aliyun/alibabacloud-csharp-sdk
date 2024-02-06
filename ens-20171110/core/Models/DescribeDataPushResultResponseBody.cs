// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataPushResultResponseBody : TeaModel {
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
        /// The push results of data files.
        /// </summary>
        [NameInMap("PushResults")]
        [Validation(Required=false)]
        public DescribeDataPushResultResponseBodyPushResults PushResults { get; set; }
        public class DescribeDataPushResultResponseBodyPushResults : TeaModel {
            [NameInMap("PushResult")]
            [Validation(Required=false)]
            public List<DescribeDataPushResultResponseBodyPushResultsPushResult> PushResult { get; set; }
            public class DescribeDataPushResultResponseBodyPushResultsPushResult : TeaModel {
                /// <summary>
                /// The name of the data file.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The push status of data files.
                /// </summary>
                [NameInMap("StatusStatS")]
                [Validation(Required=false)]
                public DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatS StatusStatS { get; set; }
                public class DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatS : TeaModel {
                    [NameInMap("StatusStat")]
                    [Validation(Required=false)]
                    public List<DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStat> StatusStat { get; set; }
                    public class DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStat : TeaModel {
                        /// <summary>
                        /// The total number of ENS nodes.
                        /// </summary>
                        [NameInMap("RegionIdCount")]
                        [Validation(Required=false)]
                        public int? RegionIdCount { get; set; }

                        /// <summary>
                        /// The push status of data files on the ENS node.
                        /// </summary>
                        [NameInMap("RegionIds")]
                        [Validation(Required=false)]
                        public DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStatRegionIds RegionIds { get; set; }
                        public class DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStatRegionIds : TeaModel {
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public List<DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStatRegionIdsRegionId> RegionId { get; set; }
                            public class DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStatRegionIdsRegionId : TeaModel {
                                /// <summary>
                                /// The ID of the ENS node.
                                /// </summary>
                                [NameInMap("RegionId")]
                                [Validation(Required=false)]
                                public string RegionId { get; set; }

                                /// <summary>
                                /// The start time of the push operation. The time is displayed in UTC.
                                /// </summary>
                                [NameInMap("StartTime")]
                                [Validation(Required=false)]
                                public string StartTime { get; set; }

                                /// <summary>
                                /// The description of the status.
                                /// </summary>
                                [NameInMap("StatusDescrip")]
                                [Validation(Required=false)]
                                public string StatusDescrip { get; set; }

                                /// <summary>
                                /// The time when the status was last updated. The time is displayed in UTC.
                                /// </summary>
                                [NameInMap("UpdateTime")]
                                [Validation(Required=false)]
                                public string UpdateTime { get; set; }

                            }

                        }

                        /// <summary>
                        /// The push status. The value is of the enumeration type. Valid values: SUCCESS FAILED PUSHING
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
