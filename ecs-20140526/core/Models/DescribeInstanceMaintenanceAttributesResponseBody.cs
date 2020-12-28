// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceMaintenanceAttributesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("MaintenanceAttributes")]
        [Validation(Required=false)]
        public List<DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributes> MaintenanceAttributes { get; set; }
        public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributes : TeaModel {
            [NameInMap("MaintenanceWindows")]
            [Validation(Required=false)]
            public List<DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceWindows> MaintenanceWindows { get; set; }
            public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceWindows : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("ActionOnMaintenance")]
            [Validation(Required=false)]
            public DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesActionOnMaintenance ActionOnMaintenance { get; set; }
            public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesActionOnMaintenance : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }
                [NameInMap("SupportedValues")]
                [Validation(Required=false)]
                public List<string> SupportedValues { get; set; }
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }
            };

        }

    }

}
