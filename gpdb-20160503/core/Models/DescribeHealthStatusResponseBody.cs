// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeHealthStatusResponseBody : TeaModel {
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public DescribeHealthStatusResponseBodyStatus Status { get; set; }
        public class DescribeHealthStatusResponseBodyStatus : TeaModel {
            [NameInMap("adbgp_segment_disk_usage_percent_max")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbgpSegmentDiskUsagePercentMax AdbgpSegmentDiskUsagePercentMax { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbgpSegmentDiskUsagePercentMax : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }
            [NameInMap("adbpg_connection_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgConnectionStatus AdbpgConnectionStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgConnectionStatus : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }
            [NameInMap("adbpg_disk_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgDiskStatus AdbpgDiskStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgDiskStatus : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }
            [NameInMap("adbpg_disk_usage_percent")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgDiskUsagePercent AdbpgDiskUsagePercent { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgDiskUsagePercent : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }
            [NameInMap("adbpg_master_disk_usage_percent_max")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgMasterDiskUsagePercentMax AdbpgMasterDiskUsagePercentMax { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgMasterDiskUsagePercentMax : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }
            [NameInMap("adbpg_master_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgMasterStatus AdbpgMasterStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgMasterStatus : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }
            [NameInMap("adbpg_segment_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgSegmentStatus AdbpgSegmentStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgSegmentStatus : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }
            [NameInMap("adbpg_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgStatus AdbpgStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgStatus : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }
            [NameInMap("node_master_connection_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeMasterConnectionStatus NodeMasterConnectionStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeMasterConnectionStatus : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }
            [NameInMap("node_master_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeMasterStatus NodeMasterStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeMasterStatus : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }
            [NameInMap("node_segment_connection_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeSegmentConnectionStatus NodeSegmentConnectionStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeSegmentConnectionStatus : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }
            [NameInMap("node_segment_disk_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeSegmentDiskStatus NodeSegmentDiskStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeSegmentDiskStatus : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }
        };

    }

}
