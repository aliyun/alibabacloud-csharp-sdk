// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// Details about the simple application servers.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstances> Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// The status of the server. Valid values:
            /// 
            /// *   Normal: The server is normal.
            /// *   Expired: The server expires.
            /// *   Overdue: The payment of the server is overdue.
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// The billing method of the simple application server.
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// Indicates whether the plan is a bundle plan.
            /// </summary>
            [NameInMap("Combination")]
            [Validation(Required=false)]
            public bool? Combination { get; set; }

            /// <summary>
            /// The ID of the bundle plan.
            /// </summary>
            [NameInMap("CombinationInstanceId")]
            [Validation(Required=false)]
            public string CombinationInstanceId { get; set; }

            /// <summary>
            /// The time when the simple application server was created. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The DDoS protection status of the server. Valid values:
            /// 
            /// *   Normal: The DDoS protection status of the server is normal.
            /// *   BlackHole: The server is in blackhole filtering.
            /// *   Defense: The server is being scrubbed.
            /// </summary>
            [NameInMap("DdosStatus")]
            [Validation(Required=false)]
            public string DdosStatus { get; set; }

            /// <summary>
            /// The reason why the server is disabled. Valid values:
            /// 
            /// *   FINANCIAL: The server is locked due to overdue payments.
            /// *   SECURITY: The server is locked due to security reasons.
            /// *   EXPIRED: The server has expired.
            /// </summary>
            [NameInMap("DisableReason")]
            [Validation(Required=false)]
            public string DisableReason { get; set; }

            /// <summary>
            /// The time when the server expires. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The description of the image.
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesImage Image { get; set; }
            public class ListInstancesResponseBodyInstancesImage : TeaModel {
                /// <summary>
                /// The image provider.
                /// </summary>
                [NameInMap("ImageContact")]
                [Validation(Required=false)]
                public string ImageContact { get; set; }

                /// <summary>
                /// The URL of the image icon.
                /// </summary>
                [NameInMap("ImageIconUrl")]
                [Validation(Required=false)]
                public string ImageIconUrl { get; set; }

                /// <summary>
                /// The image name.
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// The image type. Valid values:
                /// 
                /// *   system
                /// *   app
                /// *   custom
                /// </summary>
                [NameInMap("ImageType")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                /// <summary>
                /// The image tag.
                /// </summary>
                [NameInMap("ImageVersion")]
                [Validation(Required=false)]
                public string ImageVersion { get; set; }

                /// <summary>
                /// The OS.
                /// </summary>
                [NameInMap("OsType")]
                [Validation(Required=false)]
                public string OsType { get; set; }

            }

            /// <summary>
            /// The ID of an image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The internal IP address of the simple application server.
            /// </summary>
            [NameInMap("InnerIpAddress")]
            [Validation(Required=false)]
            public string InnerIpAddress { get; set; }

            /// <summary>
            /// The ID of the simple application server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The plan ID.
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// The public IP address of the server.
            /// </summary>
            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }

            /// <summary>
            /// The region ID of the servers.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The specifications of the resource.
            /// </summary>
            [NameInMap("ResourceSpec")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesResourceSpec ResourceSpec { get; set; }
            public class ListInstancesResponseBodyInstancesResourceSpec : TeaModel {
                /// <summary>
                /// The bandwidth of the server.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// The number of vCPUs.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// The category of the disk. Valid values:
                /// 
                /// *   ESSD: an enhanced SSD (ESSD) at performance level 0 (PL0).
                /// *   SSD: a standard SSD.
                /// *   CLOUD_EFFICIENCY: an ultra disk.
                /// </summary>
                [NameInMap("DiskCategory")]
                [Validation(Required=false)]
                public string DiskCategory { get; set; }

                /// <summary>
                /// The disk size.
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// The amount of the traffic.
                /// 
                /// *   A value of 0 indicates that the server is a bandwidth-based server.
                /// *   A value of none-zero indicates that the server is a data transfer plan-based server.
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public double? Flow { get; set; }

                /// <summary>
                /// The memory size.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public double? Memory { get; set; }

            }

            /// <summary>
            /// The status of the simple application server. Valid values:
            /// 
            /// *   Pending
            /// *   Starting
            /// *   Running
            /// *   Stopping
            /// *   Stopped
            /// *   Resetting
            /// *   Upgrading
            /// *   Disabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The universally unique identifier (UUID) of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
