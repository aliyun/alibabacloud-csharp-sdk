// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataPushResultResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PushResults")]
        [Validation(Required=false)]
        public DescribeDataPushResultResponseBodyPushResults PushResults { get; set; }
        public class DescribeDataPushResultResponseBodyPushResults : TeaModel {
            [NameInMap("PushResult")]
            [Validation(Required=false)]
            public List<DescribeDataPushResultResponseBodyPushResultsPushResult> PushResult { get; set; }
            public class DescribeDataPushResultResponseBodyPushResultsPushResult : TeaModel {
                public string Name { get; set; }
                public DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatS StatusStatS { get; set; }
                public class DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatS : TeaModel {
                    [NameInMap("StatusStat")]
                    [Validation(Required=false)]
                    public List<DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStat> StatusStat { get; set; }
                    public class DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStat : TeaModel {
                        [NameInMap("RegionIdCount")]
                        [Validation(Required=false)]
                        public int? RegionIdCount { get; set; }

                        [NameInMap("RegionIds")]
                        [Validation(Required=false)]
                        public DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStatRegionIds RegionIds { get; set; }
                        public class DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStatRegionIds : TeaModel {
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public List<DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStatRegionIdsRegionId> RegionId { get; set; }
                            public class DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStatRegionIdsRegionId : TeaModel {
                                public string RegionId { get; set; }
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
