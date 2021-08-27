// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceMaintenanceAttributesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("MaintenanceAttributes")]
        [Validation(Required=false)]
        public DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributes MaintenanceAttributes { get; set; }
        public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributes : TeaModel {
            [NameInMap("MaintenanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttribute> MaintenanceAttribute { get; set; }
            public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttribute : TeaModel {
                public bool? NotifyOnMaintenance { get; set; }
                public string InstanceId { get; set; }
                public DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeMaintenanceWindows MaintenanceWindows { get; set; }
                public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeMaintenanceWindows : TeaModel {
                    [NameInMap("MaintenanceWindow")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeMaintenanceWindowsMaintenanceWindow> MaintenanceWindow { get; set; }
                    public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeMaintenanceWindowsMaintenanceWindow : TeaModel {
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                }
                public DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeActionOnMaintenance ActionOnMaintenance { get; set; }
                public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeActionOnMaintenance : TeaModel {
                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("SupportedValues")]
                    [Validation(Required=false)]
                    public DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeActionOnMaintenanceSupportedValues SupportedValues { get; set; }
                    public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeActionOnMaintenanceSupportedValues : TeaModel {
                        [NameInMap("SupportedValue")]
                        [Validation(Required=false)]
                        public List<string> SupportedValue { get; set; }
                    };

                }
            }
        };

    }

}
