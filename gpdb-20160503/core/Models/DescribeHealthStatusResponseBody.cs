// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D97B4191-104D-10CE-8BC5-53**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried performance metrics. Each performance metric consists of the parameter name, status, and metric value. The metric information is returned only for the performance parameters specified by <b>Key</b>. For example, if you set <b>Key</b> to <b>adbpg_status</b>, only the metric information of <b>adbpg_status</b> is returned.</para>
        /// <para>For more information about performance parameters, see <a href="https://help.aliyun.com/document_detail/86943.html">Performance parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;node_master_connection_status&quot;:{&quot;Status&quot;:&quot;healthy&quot;,&quot;Value&quot;:1.6}}</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public DescribeHealthStatusResponseBodyStatus Status { get; set; }
        public class DescribeHealthStatusResponseBodyStatus : TeaModel {
            /// <summary>
            /// <para>The information of maximum compute node storage usage.</para>
            /// <remarks>
            /// <para> This parameter value is returned only for instances in elastic storage mode.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("adbgp_segment_disk_usage_percent_max")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbgpSegmentDiskUsagePercentMax AdbgpSegmentDiskUsagePercentMax { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbgpSegmentDiskUsagePercentMax : TeaModel {
                /// <summary>
                /// <para>The status corresponding to the maximum storage usage among all compute nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: The compute node storage usage is greater than or equal to 90%. In this case, the instance is locked.</description></item>
                /// <item><description><b>warning</b>: The compute node storage usage is greater than or equal to 80% and less than 90%.</description></item>
                /// <item><description><b>healthy</b>: The compute node storage usage is less than 80%.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of maximum compute node storage usage.</para>
                /// <para>Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.52</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The information of instance connection health status.</para>
            /// </summary>
            [NameInMap("adbpg_connection_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgConnectionStatus AdbpgConnectionStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgConnectionStatus : TeaModel {
                /// <summary>
                /// <para>The connection health status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: The instance connection usage is greater than 95%. In this case, this metric is marked in red in the console.</description></item>
                /// <item><description><b>warning</b>: The instance connection usage is greater than 90% and less than or equal to 95%. In this case, this metric is marked in yellow in the console.</description></item>
                /// <item><description><b>healthy</b>: The instance connection usage is less than or equal to 90%. In this case, this metric is marked in green in the console.</description></item>
                /// </list>
                /// <remarks>
                /// <para> The instance connection usage is the maximum connection usage among all the coordinator and compute nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of instance connection usage.</para>
                /// <para>Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.71</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The information of instance storage status.</para>
            /// <remarks>
            /// <para> This parameter value is returned only for instances in elastic storage mode.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("adbpg_disk_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgDiskStatus AdbpgDiskStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgDiskStatus : TeaModel {
                /// <summary>
                /// <para>The storage status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: The instance storage usage is greater than or equal to 90%. In this case, this metric is marked in red in the console and the instance is locked.</description></item>
                /// <item><description><b>warning</b>: The instance storage usage is greater than or equal to 70% and less than 90%. In this case, this metric is marked in yellow in the console.</description></item>
                /// <item><description><b>healthy</b>: The instance storage usage is less than 70%. In this case, this metric is marked in green in the console.</description></item>
                /// </list>
                /// <remarks>
                /// <para> The instance storage usage is the average storage usage of all compute nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of instance storage usage.</para>
                /// <para>Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.52</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The information of instance storage usage.</para>
            /// <remarks>
            /// <para> This parameter value is returned only for instances in elastic storage mode.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("adbpg_disk_usage_percent")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgDiskUsagePercent AdbpgDiskUsagePercent { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgDiskUsagePercent : TeaModel {
                /// <summary>
                /// <para>The status corresponding to the storage usage of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: The instance storage usage is greater than or equal to 90%. In this case, the instance is locked.</description></item>
                /// <item><description><b>warning</b>: The instance storage usage is greater than or equal to 70% and less than 90%.</description></item>
                /// <item><description><b>healthy</b>: The instance storage usage is less than 70%.</description></item>
                /// </list>
                /// <remarks>
                /// <para> The instance storage usage is the average storage usage of all compute nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of instance storage usage.</para>
                /// <para>Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.52</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The total amount of cold data storage.</para>
            /// </summary>
            [NameInMap("adbpg_instance_cold_data_gb")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgInstanceColdDataGb AdbpgInstanceColdDataGb { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgInstanceColdDataGb : TeaModel {
                /// <summary>
                /// <para>The total amount of cold data storage. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The total amount of hot data storage.</para>
            /// </summary>
            [NameInMap("adbpg_instance_hot_data_gb")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgInstanceHotDataGb AdbpgInstanceHotDataGb { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgInstanceHotDataGb : TeaModel {
                /// <summary>
                /// <para>The total amount of hot data storage. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The total amount of data storage of the instance.</para>
            /// </summary>
            [NameInMap("adbpg_instance_total_data_gb")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgInstanceTotalDataGb AdbpgInstanceTotalDataGb { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgInstanceTotalDataGb : TeaModel {
                /// <summary>
                /// <para>The total amount of data storage of the instance. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The information of maximum coordinator node storage usage.</para>
            /// <remarks>
            /// <para> This parameter value is returned only for instances in elastic storage mode.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("adbpg_master_disk_usage_percent_max")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgMasterDiskUsagePercentMax AdbpgMasterDiskUsagePercentMax { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgMasterDiskUsagePercentMax : TeaModel {
                /// <summary>
                /// <para>The status corresponding to the maximum storage usage of the coordinator node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: The coordinator node storage usage is greater than or equal to 90%. In this case, the instance is locked.</description></item>
                /// <item><description><b>warning</b>: The coordinator node storage usage is greater than or equal to 70% and less than 90%.</description></item>
                /// <item><description><b>healthy</b>: The coordinator node storage usage is less than 70%.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of maximum coordinator node storage usage.</para>
                /// <para>Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.34</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The information of coordinator node availability status.</para>
            /// </summary>
            [NameInMap("adbpg_master_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgMasterStatus AdbpgMasterStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgMasterStatus : TeaModel {
                /// <summary>
                /// <para>The availability status of the coordinator node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: Both the primary and standby coordinator nodes are unavailable. In this case, this metric is marked in red in the console.</description></item>
                /// <item><description><b>warning</b>: The primary or standby coordinator node is unavailable. In this case, this metric is marked in yellow in the console.</description></item>
                /// <item><description><b>healthy</b>: Both the primary and standby coordinator nodes are available. In this case, this metric is marked in green in the console.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of coordinator node availability status. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The information of compute node availability status.</para>
            /// </summary>
            [NameInMap("adbpg_segment_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgSegmentStatus AdbpgSegmentStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgSegmentStatus : TeaModel {
                /// <summary>
                /// <para>The availability status of compute nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: All the primary and secondary compute nodes are unavailable. In this case, this metric is marked in red in the console.</description></item>
                /// <item><description><b>warning</b>: Fifty percent or more than fifty percent of compute nodes are unavailable. In this case, this metric is marked in yellow in the console.</description></item>
                /// <item><description><b>healthy</b>: All compute nodes are available. In this case, this metric is marked in green in the console.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of compute node availability status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The information of instance health status.</para>
            /// </summary>
            [NameInMap("adbpg_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgStatus AdbpgStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgStatus : TeaModel {
                /// <summary>
                /// <para>The health status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: The coordinator node or a compute node is unavailable. In this case, this metric is marked in red in the console.</description></item>
                /// <item><description><b>healthy</b>: All nodes are available. In this case, this metric is marked in green in the console.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of instance health status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: healthy</description></item>
                /// <item><description><b>0</b>: critical</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The information of coordinator node connection health status.</para>
            /// </summary>
            [NameInMap("node_master_connection_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeMasterConnectionStatus NodeMasterConnectionStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeMasterConnectionStatus : TeaModel {
                /// <summary>
                /// <para>The connection health status of the coordinator node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: The coordinator node connection usage is greater than 95%. In this case, this metric is marked in red in the console.</description></item>
                /// <item><description><b>warning</b>: The coordinator node connection usage is greater than or equal to 90% and less than 95%. In this case, this metric is marked in yellow in the console.</description></item>
                /// <item><description><b>healthy</b>: The coordinator node connection usage is less than 90%. In this case, this metric is marked in green in the console.</description></item>
                /// </list>
                /// <remarks>
                /// <para> The coordinator node connection usage is the maximum connection usage of the coordinator node.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of coordinator node connection usage.</para>
                /// <para>Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.71</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The information of coordinator node health status.</para>
            /// </summary>
            [NameInMap("node_master_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeMasterStatus NodeMasterStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeMasterStatus : TeaModel {
                /// <summary>
                /// <para>The health status of the coordinator node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: The primary or standby coordinator node is unavailable. In this case, this metric is marked in red in the console.</description></item>
                /// <item><description><b>healthy</b>: Both the primary and standby coordinator nodes are available. In this case, this metric is marked in green in the console.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of coordinator node health status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: healthy</description></item>
                /// <item><description><b>0</b>: critical</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The information of compute node connection health status.</para>
            /// </summary>
            [NameInMap("node_segment_connection_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeSegmentConnectionStatus NodeSegmentConnectionStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeSegmentConnectionStatus : TeaModel {
                /// <summary>
                /// <para>The connection health status of compute nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: The compute node connection usage is greater than or equal to 95%. In this case, this metric is marked in red in the console.</description></item>
                /// <item><description><b>warning</b>: The compute node connection usage is greater than or equal to 90% and less than 95%. In this case, this metric is marked in yellow in the console.</description></item>
                /// <item><description><b>healthy</b>: The compute node connection usage is less than 90%. In this case, this metric is marked in green in the console.</description></item>
                /// </list>
                /// <remarks>
                /// <para> The compute node connection usage is the maximum connection usage among all compute nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of maximum compute node connection usage.</para>
                /// <para>Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.48</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The information of compute node storage status.</para>
            /// <remarks>
            /// <para> This parameter value is returned only for instances in elastic storage mode.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("node_segment_disk_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeSegmentDiskStatus NodeSegmentDiskStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeSegmentDiskStatus : TeaModel {
                /// <summary>
                /// <para>The storage status of compute nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: The compute node storage usage is greater than or equal to 90%. In this case, this metric is marked in red in the console and the instance is locked.</description></item>
                /// <item><description><b>warning</b>: The compute node storage usage is greater than or equal to 80% and less than 90%. In this case, this metric is marked in yellow in the console.</description></item>
                /// <item><description><b>healthy</b>: The compute node storage usage is less than 80%. In this case, this metric is marked in green in the console.</description></item>
                /// </list>
                /// <remarks>
                /// <para> The compute node storage usage is the maximum storage usage among all compute nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of maximum compute node storage usage.</para>
                /// <para>Unit: %.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.52</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

        }

    }

}
