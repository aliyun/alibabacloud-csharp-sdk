// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceMaintenanceAttributesResponseBody : TeaModel {
        [NameInMap("MaintenanceAttributes")]
        [Validation(Required=false)]
        public DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributes MaintenanceAttributes { get; set; }
        public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributes : TeaModel {
            [NameInMap("MaintenanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttribute> MaintenanceAttribute { get; set; }
            public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttribute : TeaModel {
                [NameInMap("ActionOnMaintenance")]
                [Validation(Required=false)]
                public DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeActionOnMaintenance ActionOnMaintenance { get; set; }
                public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeActionOnMaintenance : TeaModel {
                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    [NameInMap("SupportedValues")]
                    [Validation(Required=false)]
                    public DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeActionOnMaintenanceSupportedValues SupportedValues { get; set; }
                    public class DescribeInstanceMaintenanceAttributesResponseBodyMaintenanceAttributesMaintenanceAttributeActionOnMaintenanceSupportedValues : TeaModel {
                        [NameInMap("SupportedValue")]
                        [Validation(Required=false)]
                        public List<string> SupportedValue { get; set; }

                    }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("MaintenanceWindows")]
                [Validation(Required=false)]
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
