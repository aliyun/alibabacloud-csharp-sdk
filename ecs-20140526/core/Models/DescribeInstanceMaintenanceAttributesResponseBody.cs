// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceMaintenanceAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maintenance attributes.</para>
        /// </summary>
        [NameInMap("MaintenanceAttributes")]
        [Validation(Required=false)]
        public DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributes MaintenanceAttributes { get; set; }
        public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributes : TeaModel {
            [NameInMap("MaintenanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttribute> MaintenanceAttribute { get; set; }
            public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttribute : TeaModel {
                /// <summary>
                /// <para>The attributes of the maintenance action of the instance.</para>
                /// </summary>
                [NameInMap("ActionOnMaintenance")]
                [Validation(Required=false)]
                public DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeActionOnMaintenance ActionOnMaintenance { get; set; }
                public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeActionOnMaintenance : TeaModel {
                    /// <summary>
                    /// <para>The default maintenance action.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AutoRecover</para>
                    /// </summary>
                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// <para>The supported maintenance actions.</para>
                    /// </summary>
                    [NameInMap("SupportedValues")]
                    [Validation(Required=false)]
                    public DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeActionOnMaintenanceSupportedValues SupportedValues { get; set; }
                    public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeActionOnMaintenanceSupportedValues : TeaModel {
                        [NameInMap("SupportedValue")]
                        [Validation(Required=false)]
                        public List<string> SupportedValue { get; set; }

                    }

                    /// <summary>
                    /// <para>The current maintenance action. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Stop: stops the instance.</description></item>
                    /// <item><description>AutoRecover: automatically recovers the instance.</description></item>
                    /// <item><description>AutoRedeploy: redeploys the instance, which may damage the data disks attached to the instance.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Stop</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The maintenance windows.</para>
                /// </summary>
                [NameInMap("MaintenanceWindows")]
                [Validation(Required=false)]
                public DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeMaintenanceWindows MaintenanceWindows { get; set; }
                public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeMaintenanceWindows : TeaModel {
                    [NameInMap("MaintenanceWindow")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeMaintenanceWindowsMaintenanceWindow> MaintenanceWindow { get; set; }
                    public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeMaintenanceWindowsMaintenanceWindow : TeaModel {
                        /// <summary>
                        /// <para>The end time of the maintenance window.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>18:00:00</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The start time of the maintenance window.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>02:00:00</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether an event notification was sent before maintenance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("NotifyOnMaintenance")]
                [Validation(Required=false)]
                public bool? NotifyOnMaintenance { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of queried maintenance attributes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
