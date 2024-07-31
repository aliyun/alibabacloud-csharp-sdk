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
            /// Indicates whether the simple application server uses a bundle plan.
            /// </summary>
            [NameInMap("Combination")]
            [Validation(Required=false)]
            public bool? Combination { get; set; }

            /// <summary>
            /// The ID of the simple application server that uses a bundle plan.
            /// </summary>
            [NameInMap("CombinationInstanceId")]
            [Validation(Required=false)]
            public string CombinationInstanceId { get; set; }

            /// <summary>
            /// The time when the simple application server was created. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
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
            /// *   SECURITY: The server is locked for security reasons.
            /// *   EXPIRED: The server is expired.
            /// </summary>
            [NameInMap("DisableReason")]
            [Validation(Required=false)]
            public string DisableReason { get; set; }

            /// <summary>
            /// The disks that are attached to the simple application server.
            /// </summary>
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstancesDisks> Disks { get; set; }
            public class ListInstancesResponseBodyInstancesDisks : TeaModel {
                /// <summary>
                /// The category of the disk. Valid values:
                /// 
                /// *   ESSD: ESSD of PL0
                /// *   SSD: standard SSD
                /// *   CLOUD_EFFICIENCY: an ultra disk.
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The time when the simple application server was created. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The device name of the disk after the disk is attached to the simple application server.
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// The billing method of the disk.
                /// </summary>
                [NameInMap("DiskChargeType")]
                [Validation(Required=false)]
                public string DiskChargeType { get; set; }

                /// <summary>
                /// The disk ID.
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// The disk name.
                /// </summary>
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                /// <summary>
                /// The tags that are added to the disk.
                /// </summary>
                [NameInMap("DiskTags")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyInstancesDisksDiskTags> DiskTags { get; set; }
                public class ListInstancesResponseBodyInstancesDisksDiskTags : TeaModel {
                    /// <summary>
                    /// The tag key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The tag value.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The disk type. Valid values:
                /// 
                /// *   system: system disk
                /// *   data: data disk
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The remarks of the disk.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The ID of the resource group to which the disk belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The disk size. Unit: GB.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// The status of the disk. Valid values:
                /// 
                /// *   ReIniting: The disk is being initialized.
                /// *   Creating: The disk is being created.
                /// *   In_use: The disk is in use.
                /// *   Available: The disk can be attached.
                /// *   Attaching: The disk is being attached.
                /// *   Detaching: The disk is being detached.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The time when the simple application server expires. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
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
                /// The name of the image.
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// The type of the image. Valid values:
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
            /// The ID of the image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The private IP address of the simple application server.
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
            /// The name of the simple application server.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The ID of the instance plan.
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// The public IP address.
            /// </summary>
            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the server belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

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
                /// The number of vCPUs of the simple application server.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// The category of the disk. Valid values:
                /// 
                /// *   ESSD: enhanced SSD (ESSD) of PL0
                /// *   SSD: standard SSD
                /// *   CLOUD_EFFICIENCY: ultra disk
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
                /// *   A value of 0 indicates the traffic amount of a bandwidth-based simple application server.
                /// *   A non-zero value indicates the traffic amount of a data transfer plan-based simple application server.
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public double? Flow { get; set; }

                /// <summary>
                /// The memory size of the server.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public double? Memory { get; set; }

            }

            /// <summary>
            /// The status of the simple application server. Valid values:
            /// 
            /// *   Pending: The server is being prepared.
            /// *   Starting: The server is being started.
            /// *   Running: The server is running.
            /// *   Stopping: The server is being stopped.
            /// *   Stopped: The server is stopped.
            /// *   Resetting: The server is being reset.
            /// *   Upgrading: The server is being upgraded.
            /// *   Disabled: The server is not available.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags that are added to the simple application server.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstancesTags> Tags { get; set; }
            public class ListInstancesResponseBodyInstancesTags : TeaModel {
                /// <summary>
                /// The tag key of the simple application server.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value of the simple application server.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The universally unique identifier (UUID) of the simple application server.
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
