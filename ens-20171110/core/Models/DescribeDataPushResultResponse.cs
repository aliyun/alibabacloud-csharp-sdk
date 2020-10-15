// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataPushResultResponse : TeaModel {
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

        [NameInMap("PushResults")]
        [Validation(Required=true)]
        public DescribeDataPushResultResponsePushResults PushResults { get; set; }
        public class DescribeDataPushResultResponsePushResults : TeaModel {
            [NameInMap("PushResult")]
            [Validation(Required=true)]
            public List<DescribeDataPushResultResponsePushResultsPushResult> PushResult { get; set; }
            public class DescribeDataPushResultResponsePushResultsPushResult : TeaModel {
                public string Name { get; set; }
                public string Version { get; set; }
                public DescribeDataPushResultResponsePushResultsPushResultStatusStatS StatusStatS { get; set; }
                public class DescribeDataPushResultResponsePushResultsPushResultStatusStatS : TeaModel {
                    [NameInMap("StatusStat")]
                    [Validation(Required=true)]
                    public List<DescribeDataPushResultResponsePushResultsPushResultStatusStatSStatusStat> StatusStat { get; set; }
                    public class DescribeDataPushResultResponsePushResultsPushResultStatusStatSStatusStat : TeaModel {
                        [NameInMap("Status")]
                        [Validation(Required=true)]
                        public string Status { get; set; }

                        [NameInMap("RegionIdCount")]
                        [Validation(Required=true)]
                        public int? RegionIdCount { get; set; }

                        [NameInMap("RegionIds")]
                        [Validation(Required=true)]
                        public DescribeDataPushResultResponsePushResultsPushResultStatusStatSStatusStatRegionIds RegionIds { get; set; }
                        public class DescribeDataPushResultResponsePushResultsPushResultStatusStatSStatusStatRegionIds : TeaModel {
                            [NameInMap("RegionId")]
                            [Validation(Required=true)]
                            public List<DescribeDataPushResultResponsePushResultsPushResultStatusStatSStatusStatRegionIdsRegionId> RegionId { get; set; }
                            public class DescribeDataPushResultResponsePushResultsPushResultStatusStatSStatusStatRegionIdsRegionId : TeaModel {
                                public string StartTime { get; set; }
                                public string UpdateTime { get; set; }
                                public string RegionId { get; set; }
                                public string StatusDescrip { get; set; }
                            }
                        };

                    }

                }
            }
        };

    }

}
