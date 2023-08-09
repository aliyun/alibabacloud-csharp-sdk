// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceMaintenanceAttributesResponseBody : TeaModel {
        /// <summary>
        /// The maintenance attributes.
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
                /// The attributes of the maintenance action of the instance.
                /// </summary>
                [NameInMap("ActionOnMaintenance")]
                [Validation(Required=false)]
                public DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeActionOnMaintenance ActionOnMaintenance { get; set; }
                public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeActionOnMaintenance : TeaModel {
                    /// <summary>
                    /// The default maintenance action.
                    /// </summary>
                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    /// <summary>
                    /// The supported maintenance actions.
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
                    /// The current maintenance action. Valid values:
                    /// 
                    /// *   Stop: stops the instance.
                    /// *   AutoRecover: automatically recovers the instance.
                    /// *   AutoRedeploy: redeploys the instance, which may damage the data disks attached to the instance.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The maintenance windows.
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
                        /// The end time of the maintenance window.
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// The start time of the maintenance window.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether an event notification was sent before maintenance.
                /// </summary>
                [NameInMap("NotifyOnMaintenance")]
                [Validation(Required=false)]
                public bool? NotifyOnMaintenance { get; set; }

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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of queried maintenance attributes.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
