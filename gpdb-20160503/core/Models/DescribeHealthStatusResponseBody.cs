// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D97B4191-104D-10CE-8BC5-53**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The detailed performance monitoring information, which consists of the metric name, status, and metric value. Monitoring information is returned only for the metrics specified in the <b>Key</b> request parameter. For example, if the <b>Key</b> parameter contains only <b>adbpg_status</b>, only the monitoring information for <b>adbpg_status</b> is returned.</para>
        /// <para>For more information about performance metrics, see <a href="https://help.aliyun.com/document_detail/86943.html">Performance metrics</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;node_master_connection_status&quot;:{&quot;Status&quot;:&quot;healthy&quot;,&quot;Value&quot;:1.6}}</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public DescribeHealthStatusResponseBodyStatus Status { get; set; }
        public class DescribeHealthStatusResponseBodyStatus : TeaModel {
            /// <summary>
            /// <para>The maximum storage usage of compute nodes in the instance, which is the maximum storage usage among all segment nodes in the instance.</para>
            /// <remarks>
            /// <para>This value is returned only for instances in elastic storage mode.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("adbgp_segment_disk_usage_percent_max")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbgpSegmentDiskUsagePercentMax AdbgpSegmentDiskUsagePercentMax { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbgpSegmentDiskUsagePercentMax : TeaModel {
                /// <summary>
                /// <para>The maximum storage usage status of segment nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: Instance storage usage is greater than or equal to 90%, and the instance will be locked.</description></item>
                /// <item><description><b>warning</b>: Instance storage usage is greater than or equal to 80% and less than 90%.</description></item>
                /// <item><description><b>healthy</b>: Instance storage usage is less than 80%, indicating a healthy storage status.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of the maximum storage usage of segment nodes.</para>
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
            /// <para>The connection status of the instance.</para>
            /// </summary>
            [NameInMap("adbpg_connection_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgConnectionStatus AdbpgConnectionStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgConnectionStatus : TeaModel {
                /// <summary>
                /// <para>The connection status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: The connection usage of the instance is greater than 95%. The status is displayed in red in the console.</description></item>
                /// <item><description><b>warning</b>: The connection usage of the instance is greater than 90% and less than or equal to 95%. The status is displayed in yellow in the console.</description></item>
                /// <item><description><b>healthy</b>: The connection usage of the instance is less than or equal to 90%. The status is displayed in green in the console.</description></item>
                /// </list>
                /// <remarks>
                /// <para>The connection usage of the instance is the maximum connection usage among all master nodes and segment nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of the instance connection usage, which is the maximum connection usage among all master nodes and segment nodes.</para>
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
            /// <para>The instance storage status.</para>
            /// <remarks>
            /// <para>This value is returned only for instances in the elastic storage pattern.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("adbpg_disk_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgDiskStatus AdbpgDiskStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgDiskStatus : TeaModel {
                /// <summary>
                /// <para>Instance storage status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: Instance storage usage of the instance is greater than or equal to 90%. The status is displayed in red in the console, and the instance will be locked.</description></item>
                /// <item><description><b>warning</b>: Instance storage usage of the instance is greater than or equal to 70% and less than 90%. The status is displayed in yellow in the console.</description></item>
                /// <item><description><b>healthy</b>: Instance storage usage of the instance is less than 70%. The status is displayed in green in the console, indicating a healthy storage status.</description></item>
                /// </list>
                /// <remarks>
                /// <para>Instance storage usage of the instance is the average storage usage of all segment nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of the instance storage usage, which is the average storage usage of all segment nodes.</para>
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
            /// <para>The instance storage usage.</para>
            /// <remarks>
            /// <para>This value is returned only for instances in the elastic storage pattern.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("adbpg_disk_usage_percent")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgDiskUsagePercent AdbpgDiskUsagePercent { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgDiskUsagePercent : TeaModel {
                /// <summary>
                /// <para>Instance storage usage status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: Instance storage usage of the instance is greater than or equal to 90%, and the instance will be locked.</description></item>
                /// <item><description><b>warning</b>: Instance storage usage of the instance is greater than or equal to 70% and less than 90%.</description></item>
                /// <item><description><b>healthy</b>: Instance storage usage of the instance is less than 70%, indicating a healthy storage status.</description></item>
                /// </list>
                /// <remarks>
                /// <para>Instance storage usage of the instance is the average storage usage of all segment nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of the instance storage usage, which is the average storage usage of all segment nodes.</para>
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
            /// <para>The total amount of cold data stored.</para>
            /// </summary>
            [NameInMap("adbpg_instance_cold_data_gb")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgInstanceColdDataGb AdbpgInstanceColdDataGb { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgInstanceColdDataGb : TeaModel {
                /// <summary>
                /// <para>The total amount of cold data stored. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The total amount of hot data stored.</para>
            /// </summary>
            [NameInMap("adbpg_instance_hot_data_gb")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgInstanceHotDataGb AdbpgInstanceHotDataGb { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgInstanceHotDataGb : TeaModel {
                /// <summary>
                /// <para>The total amount of hot data stored. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The total amount of instance storage data.</para>
            /// </summary>
            [NameInMap("adbpg_instance_total_data_gb")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgInstanceTotalDataGb AdbpgInstanceTotalDataGb { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgInstanceTotalDataGb : TeaModel {
                /// <summary>
                /// <para>The total amount of instance storage data. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The maximum storage usage of coordinator nodes in the instance, which is the maximum storage usage among all master nodes in the instance.</para>
            /// <remarks>
            /// <para>This value is returned only for instances in elastic storage mode.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("adbpg_master_disk_usage_percent_max")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgMasterDiskUsagePercentMax AdbpgMasterDiskUsagePercentMax { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgMasterDiskUsagePercentMax : TeaModel {
                /// <summary>
                /// <para>The maximum storage usage status of master nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: Instance storage usage is greater than or equal to 90%, and the instance will be locked.</description></item>
                /// <item><description><b>warning</b>: Instance storage usage is greater than or equal to 70% and less than 90%.</description></item>
                /// <item><description><b>healthy</b>: Instance storage usage is less than 70%, indicating a healthy storage status.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of the maximum storage usage of master nodes.</para>
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
            /// <para>The status of coordinator nodes, namely the availability status of master nodes.</para>
            /// </summary>
            [NameInMap("adbpg_master_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgMasterStatus AdbpgMasterStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgMasterStatus : TeaModel {
                /// <summary>
                /// <para>The availability status of master nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: Both the primary and secondary nodes are unavailable. The status is displayed in red in the console.</description></item>
                /// <item><description><b>warning</b>: The primary or secondary node is unavailable. The status is displayed in yellow in the console.</description></item>
                /// <item><description><b>healthy</b>: All nodes are available. The status is displayed in green in the console.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of the availability status of master nodes. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The status of compute nodes, namely the availability status of segment nodes.</para>
            /// </summary>
            [NameInMap("adbpg_segment_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgSegmentStatus AdbpgSegmentStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgSegmentStatus : TeaModel {
                /// <summary>
                /// <para>The availability status of segment nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: Both the primary and secondary nodes are unavailable. The status is displayed in red in the console.</description></item>
                /// <item><description><b>warning</b>: 50% or more of the nodes are unavailable. The status is displayed in yellow in the console.</description></item>
                /// <item><description><b>healthy</b>: All nodes are available. The status is displayed in green in the console.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of the availability status of segment nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The health status of the instance.</para>
            /// </summary>
            [NameInMap("adbpg_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusAdbpgStatus AdbpgStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusAdbpgStatus : TeaModel {
                /// <summary>
                /// <para>The health status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: At least one master node or segment node is unavailable. The status is displayed in red in the console.</description></item>
                /// <item><description><b>healthy</b>: All nodes are available. The status is displayed in green in the console.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of the instance health status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: healthy.</description></item>
                /// <item><description><b>0</b>: critical.</description></item>
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
            /// <para>The connection health status of coordinator nodes, namely master nodes.</para>
            /// </summary>
            [NameInMap("node_master_connection_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeMasterConnectionStatus NodeMasterConnectionStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeMasterConnectionStatus : TeaModel {
                /// <summary>
                /// <para>The connection health status of master nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: The connection usage of master nodes is greater than or equal to 95%. The status is displayed in red in the console.</description></item>
                /// <item><description><b>warning</b>: The connection usage of master nodes is greater than or equal to 90% and less than 95%. The status is displayed in yellow in the console.</description></item>
                /// <item><description><b>healthy</b>: The connection usage of master nodes is less than 90%. The status is displayed in green in the console.</description></item>
                /// </list>
                /// <remarks>
                /// <para>The connection usage of master nodes is the maximum connection usage among all master nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of the connection usage of master nodes, which is the maximum connection usage among all master nodes.</para>
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
            /// <para>The health status of coordinator nodes, namely master nodes.</para>
            /// </summary>
            [NameInMap("node_master_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeMasterStatus NodeMasterStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeMasterStatus : TeaModel {
                /// <summary>
                /// <para>The health status of master nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: At least one primary or secondary master node is unavailable. The status is displayed in red in the console.</description></item>
                /// <item><description><b>healthy</b>: All master nodes are available. The status is displayed in green in the console.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of the master node health status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: healthy.</description></item>
                /// <item><description><b>0</b>: critical.</description></item>
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
            /// <para>The connection health status of compute nodes, namely segment nodes.</para>
            /// </summary>
            [NameInMap("node_segment_connection_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeSegmentConnectionStatus NodeSegmentConnectionStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeSegmentConnectionStatus : TeaModel {
                /// <summary>
                /// <para>The connection health status of segment nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: The connection usage of segment nodes is greater than or equal to 95%. The status is displayed in red in the console.</description></item>
                /// <item><description><b>warning</b>: The connection usage of segment nodes is greater than or equal to 90% and less than 95%. The status is displayed in yellow in the console.</description></item>
                /// <item><description><b>healthy</b>: The connection usage of segment nodes is less than 90%. The status is displayed in green in the console.</description></item>
                /// </list>
                /// <remarks>
                /// <para>The connection usage of segment nodes is the maximum connection usage among all segment nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of the connection usage of segment nodes, which is the maximum connection usage among all segment nodes.</para>
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
            /// <para>The storage status of compute nodes, namely segment nodes.</para>
            /// <remarks>
            /// <para>This value is returned only for instances in elastic storage mode.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("node_segment_disk_status")]
            [Validation(Required=false)]
            public DescribeHealthStatusResponseBodyStatusNodeSegmentDiskStatus NodeSegmentDiskStatus { get; set; }
            public class DescribeHealthStatusResponseBodyStatusNodeSegmentDiskStatus : TeaModel {
                /// <summary>
                /// <para>Instance storage status of segment nodes. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>critical</b>: Instance storage usage of segment nodes is greater than or equal to 90%. The status is displayed in red in the console, and the instance will be locked.</description></item>
                /// <item><description><b>warning</b>: Instance storage usage of segment nodes is greater than or equal to 80% and less than 90%. The status is displayed in yellow in the console.</description></item>
                /// <item><description><b>healthy</b>: Instance storage usage of segment nodes is less than 80%. The status is displayed in green in the console, indicating a healthy storage status.</description></item>
                /// </list>
                /// <remarks>
                /// <para>Instance storage usage of segment nodes is the maximum storage usage among all segment nodes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>healthy</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metric value of the maximum storage usage of segment nodes.</para>
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
