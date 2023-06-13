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
            /// The status of the simple application server. Valid values:
            /// 
            /// *   Normal
            /// *   Expired
            /// *   Overdue
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

            [NameInMap("Combination")]
            [Validation(Required=false)]
            public bool? Combination { get; set; }

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
            /// The DDoS protection status. Valid values:
            /// 
            /// *   Normal: Normal
            /// *   BlackHole: Blackholing
            /// *   Defense: Cleaning
            /// </summary>
            [NameInMap("DdosStatus")]
            [Validation(Required=false)]
            public string DdosStatus { get; set; }

            [NameInMap("DisableReason")]
            [Validation(Required=false)]
            public string DisableReason { get; set; }

            /// <summary>
            /// The time when the simple application server expires. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesImage Image { get; set; }
            public class ListInstancesResponseBodyInstancesImage : TeaModel {
                [NameInMap("ImageContact")]
                [Validation(Required=false)]
                public string ImageContact { get; set; }

                [NameInMap("ImageIconUrl")]
                [Validation(Required=false)]
                public string ImageIconUrl { get; set; }

                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                [NameInMap("ImageType")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                [NameInMap("ImageVersion")]
                [Validation(Required=false)]
                public string ImageVersion { get; set; }

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
            /// The name of the simple application server.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The ID of the plan.
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
            /// The region ID of the simple application servers.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceSpec")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesResourceSpec ResourceSpec { get; set; }
            public class ListInstancesResponseBodyInstancesResourceSpec : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("DiskCategory")]
                [Validation(Required=false)]
                public string DiskCategory { get; set; }

                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                [NameInMap("Flow")]
                [Validation(Required=false)]
                public double? Flow { get; set; }

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

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of simple application servers returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
