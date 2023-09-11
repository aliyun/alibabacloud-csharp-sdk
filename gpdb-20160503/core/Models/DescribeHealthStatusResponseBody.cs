// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of instance.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The queried performance metrics. Each performance metric consists of the parameter name, status, and metric value. The metric information is returned only for the performance parameters specified by **Key**. For example, if you set **Key** to **adbpg_status**, only the metric information of **adbpg_status** is returned.
        /// 
        /// For more information about performance parameters, see [Performance parameters](~~86943~~).
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public DescribeHealthStatusResponseBodyStatus Status { get; set; }
        public class DescribeHealthStatusResponseBodyStatus : TeaModel {
            /// <summary>
            /// The information of maximum compute node storage usage.
            /// 
            /// >  This parameter value is returned only for instances in elastic storage mode.
            /// </summary>
            [NameInMap("adbgp_segment_disk_usage_percent_max")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbgpSegmentDiskUsagePercentMax AdbgpSegmentDiskUsagePercentMax { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbgpSegmentDiskUsagePercentMax : TeaModel {
                /// <summary>
                /// The status corresponding to the maximum storage usage among all compute nodes. Valid values:
                /// 
                /// *   **critical**: The compute node storage usage is greater than or equal to 90%. In this case, the instance is locked.
                /// *   **warning**: The compute node storage usage is greater than or equal to 80% and less than 90%.
                /// *   **healthy**: The compute node storage usage is less than 80%.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The metric value of maximum compute node storage usage.
                /// 
                /// Unit: %.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// The information of instance connection health status.
            /// </summary>
            [NameInMap("adbpg_connection_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgConnectionStatus AdbpgConnectionStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgConnectionStatus : TeaModel {
                /// <summary>
                /// The connection health status of the instance. Valid values:
                /// 
                /// *   **critical**: The instance connection usage is greater than 95%. In this case, this metric is marked in red in the console.
                /// *   **warning**: The instance connection usage is greater than 90% and less than or equal to 95%. In this case, this metric is marked in yellow in the console.
                /// *   **healthy**: The instance connection usage is less than or equal to 90%. In this case, this metric is marked in green in the console.
                /// 
                /// >  The instance connection usage is the maximum connection usage among all the coordinator and compute nodes.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The metric value of instance connection usage.
                /// 
                /// Unit: %.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// The information of instance storage status.
            /// 
            /// >  This parameter value is returned only for instances in elastic storage mode.
            /// </summary>
            [NameInMap("adbpg_disk_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgDiskStatus AdbpgDiskStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgDiskStatus : TeaModel {
                /// <summary>
                /// The storage status of the instance. Valid values:
                /// 
                /// *   **critical**: The instance storage usage is greater than or equal to 90%. In this case, this metric is marked in red in the console and the instance is locked.
                /// *   **warning**: The instance storage usage is greater than or equal to 70% and less than 90%. In this case, this metric is marked in yellow in the console.
                /// *   **healthy**: The instance storage usage is less than 70%. In this case, this metric is marked in green in the console.
                /// 
                /// >  The instance storage usage is the average storage usage of all compute nodes.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The metric value of instance storage usage.
                /// 
                /// Unit: %.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// The information of instance storage usage.
            /// 
            /// >  This parameter value is returned only for instances in elastic storage mode.
            /// </summary>
            [NameInMap("adbpg_disk_usage_percent")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgDiskUsagePercent AdbpgDiskUsagePercent { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgDiskUsagePercent : TeaModel {
                /// <summary>
                /// The status corresponding to the storage usage of the instance. Valid values:
                /// 
                /// *   **critical**: The instance storage usage is greater than or equal to 90%. In this case, the instance is locked.
                /// *   **warning**: The instance storage usage is greater than or equal to 70% and less than 90%.
                /// *   **healthy**: The instance storage usage is less than 70%.
                /// 
                /// >  The instance storage usage is the average storage usage of all compute nodes.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The metric value of instance storage usage.
                /// 
                /// Unit: %.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            [NameInMap("adbpg_instance_cold_data_gb")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgInstanceColdDataGb AdbpgInstanceColdDataGb { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgInstanceColdDataGb : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            [NameInMap("adbpg_instance_hot_data_gb")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgInstanceHotDataGb AdbpgInstanceHotDataGb { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgInstanceHotDataGb : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            [NameInMap("adbpg_instance_total_data_gb")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgInstanceTotalDataGb AdbpgInstanceTotalDataGb { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgInstanceTotalDataGb : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// The information of maximum coordinator node storage usage.
            /// 
            /// >  This parameter value is returned only for instances in elastic storage mode.
            /// </summary>
            [NameInMap("adbpg_master_disk_usage_percent_max")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgMasterDiskUsagePercentMax AdbpgMasterDiskUsagePercentMax { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgMasterDiskUsagePercentMax : TeaModel {
                /// <summary>
                /// The status corresponding to the maximum storage usage of the coordinator node. Valid values:
                /// 
                /// *   **critical**: The coordinator node storage usage is greater than or equal to 90%. In this case, the instance is locked.
                /// *   **warning**: The coordinator node storage usage is greater than or equal to 70% and less than 90%.
                /// *   **healthy**: The coordinator node storage usage is less than 70%.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The metric value of maximum coordinator node storage usage.
                /// 
                /// Unit: %.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// The information of coordinator node availability status.
            /// </summary>
            [NameInMap("adbpg_master_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgMasterStatus AdbpgMasterStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgMasterStatus : TeaModel {
                /// <summary>
                /// The availability status of the coordinator node. Valid values:
                /// 
                /// *   **critical**: Both the primary and standby coordinator nodes are unavailable. In this case, this metric is marked in red in the console.
                /// *   **warning**: The primary or standby coordinator node is unavailable. In this case, this metric is marked in yellow in the console.
                /// *   **healthy**: Both the primary and standby coordinator nodes are available. In this case, this metric is marked in green in the console.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The metric value of coordinator node availability status. Valid values:
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// The information of compute node availability status.
            /// </summary>
            [NameInMap("adbpg_segment_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgSegmentStatus AdbpgSegmentStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgSegmentStatus : TeaModel {
                /// <summary>
                /// The availability status of compute nodes. Valid values:
                /// 
                /// *   **critical**: All the primary and secondary compute nodes are unavailable. In this case, this metric is marked in red in the console.
                /// *   **warning**: Fifty percent or more than fifty percent of compute nodes are unavailable. In this case, this metric is marked in yellow in the console.
                /// *   **healthy**: All compute nodes are available. In this case, this metric is marked in green in the console.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The metric value of compute node availability status.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// The information of instance health status.
            /// </summary>
            [NameInMap("adbpg_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgStatus AdbpgStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgStatus : TeaModel {
                /// <summary>
                /// The health status of the instance. Valid values:
                /// 
                /// *   **critical**: The coordinator node or a compute node is unavailable. In this case, this metric is marked in red in the console.
                /// *   **healthy**: All nodes are available. In this case, this metric is marked in green in the console.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The metric value of instance health status. Valid values:
                /// 
                /// *   **1**: healthy
                /// *   **0**: critical
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// The information of coordinator node connection health status.
            /// </summary>
            [NameInMap("node_master_connection_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeMasterConnectionStatus NodeMasterConnectionStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeMasterConnectionStatus : TeaModel {
                /// <summary>
                /// The connection health status of the coordinator node. Valid values:
                /// 
                /// *   **critical**: The coordinator node connection usage is greater than 95%. In this case, this metric is marked in red in the console.
                /// *   **warning**: The coordinator node connection usage is greater than or equal to 90% and less than 95%. In this case, this metric is marked in yellow in the console.
                /// *   **healthy**: The coordinator node connection usage is less than 90%. In this case, this metric is marked in green in the console.
                /// 
                /// >  The coordinator node connection usage is the maximum connection usage of the coordinator node.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The metric value of coordinator node connection usage.
                /// 
                /// Unit: %.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// The information of coordinator node health status.
            /// </summary>
            [NameInMap("node_master_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeMasterStatus NodeMasterStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeMasterStatus : TeaModel {
                /// <summary>
                /// The health status of the coordinator node. Valid values:
                /// 
                /// *   **critical**: The primary or standby coordinator node is unavailable. In this case, this metric is marked in red in the console.
                /// *   **healthy**: Both the primary and standby coordinator nodes are available. In this case, this metric is marked in green in the console.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The metric value of coordinator node health status. Valid values:
                /// 
                /// *   **1**: healthy
                /// *   **0**: critical
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// The information of compute node connection health status.
            /// </summary>
            [NameInMap("node_segment_connection_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeSegmentConnectionStatus NodeSegmentConnectionStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeSegmentConnectionStatus : TeaModel {
                /// <summary>
                /// The connection health status of compute nodes. Valid values:
                /// 
                /// *   **critical**: The compute node connection usage is greater than or equal to 95%. In this case, this metric is marked in red in the console.
                /// *   **warning**: The compute node connection usage is greater than or equal to 90% and less than 95%. In this case, this metric is marked in yellow in the console.
                /// *   **healthy**: The compute node connection usage is less than 90%. In this case, this metric is marked in green in the console.
                /// 
                /// >  The compute node connection usage is the maximum connection usage among all compute nodes.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The metric value of maximum compute node connection usage.
                /// 
                /// Unit: %.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// The information of compute node storage status.
            /// 
            /// >  This parameter value is returned only for instances in elastic storage mode.
            /// </summary>
            [NameInMap("node_segment_disk_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeSegmentDiskStatus NodeSegmentDiskStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeSegmentDiskStatus : TeaModel {
                /// <summary>
                /// The storage status of compute nodes. Valid values:
                /// 
                /// *   **critical**: The compute node storage usage is greater than or equal to 90%. In this case, this metric is marked in red in the console and the instance is locked.
                /// *   **warning**: The compute node storage usage is greater than or equal to 80% and less than 90%. In this case, this metric is marked in yellow in the console.
                /// *   **healthy**: The compute node storage usage is less than 80%. In this case, this metric is marked in green in the console.
                /// 
                /// >  The compute node storage usage is the maximum storage usage among all compute nodes.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The metric value of maximum compute node storage usage.
                /// 
                /// Unit: %.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

        }

    }

}
