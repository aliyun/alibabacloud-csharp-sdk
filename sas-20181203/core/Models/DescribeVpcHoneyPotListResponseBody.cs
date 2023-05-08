// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVpcHoneyPotListResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeVpcHoneyPotListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeVpcHoneyPotListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the honeypots.
        /// </summary>
        [NameInMap("VpcHoneyPotDTOList")]
        [Validation(Required=false)]
        public List<DescribeVpcHoneyPotListResponseBodyVpcHoneyPotDTOList> VpcHoneyPotDTOList { get; set; }
        public class DescribeVpcHoneyPotListResponseBodyVpcHoneyPotDTOList : TeaModel {
            /// <summary>
            /// The CIDR block of the VPC.
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// The time at which the VPC was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The status of the server on which the honeypot is deployed. Valid values:
            /// 
            /// *   **Pending**: The server is being created.
            /// *   **Running**: The server is running.
            /// *   **Starting**: The server is being started.
            /// *   **Stopping**: The server is being stopped.
            /// *   **Stopped**: The server is stopped.
            /// </summary>
            [NameInMap("HoneyPotEcsInstanceStatus")]
            [Validation(Required=false)]
            public string HoneyPotEcsInstanceStatus { get; set; }

            /// <summary>
            /// The ID of the elastic network interface (ENI) used by the honeypot in the VPC.
            /// </summary>
            [NameInMap("HoneyPotEniInstanceId")]
            [Validation(Required=false)]
            public string HoneyPotEniInstanceId { get; set; }

            /// <summary>
            /// Indicates whether the cloud honeypot feature is enabled for the VPC. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("HoneyPotExistence")]
            [Validation(Required=false)]
            public bool? HoneyPotExistence { get; set; }

            /// <summary>
            /// The status of the honeypot. Valid values:
            /// 
            /// *   **pending**: The honeypot is being created.
            /// *   **deleting**: The honeypot is being deleted.
            /// *   **off**: The honeypot is disabled.
            /// *   **suspending**: The honeypot is suspended.
            /// *   **on**: The honeypot is enabled.
            /// </summary>
            [NameInMap("HoneyPotInstanceStatus")]
            [Validation(Required=false)]
            public string HoneyPotInstanceStatus { get; set; }

            /// <summary>
            /// The ID of the vSwitch to which the ENI used by the honeypot is connected.
            /// </summary>
            [NameInMap("HoneyPotVpcSwitchId")]
            [Validation(Required=false)]
            public string HoneyPotVpcSwitchId { get; set; }

            /// <summary>
            /// The ID of the VPC.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The name of the VPC.
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

            /// <summary>
            /// The region ID of the VPC.
            /// 
            /// > For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
            /// </summary>
            [NameInMap("VpcRegionId")]
            [Validation(Required=false)]
            public string VpcRegionId { get; set; }

            /// <summary>
            /// The status of the VPC. Valid values:
            /// 
            /// *   **Available**: The VPC is normal and available.
            /// *   **Pending**: The VPC is being configured.
            /// </summary>
            [NameInMap("VpcStatus")]
            [Validation(Required=false)]
            public string VpcStatus { get; set; }

            /// <summary>
            /// An array that consists of the vSwitches in the VPC.
            /// </summary>
            [NameInMap("VpcSwitchIdList")]
            [Validation(Required=false)]
            public List<DescribeVpcHoneyPotListResponseBodyVpcHoneyPotDTOListVpcSwitchIdList> VpcSwitchIdList { get; set; }
            public class DescribeVpcHoneyPotListResponseBodyVpcHoneyPotDTOListVpcSwitchIdList : TeaModel {
                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("VpcSwitchId")]
                [Validation(Required=false)]
                public string VpcSwitchId { get; set; }

                /// <summary>
                /// The name of the vSwitch.
                /// </summary>
                [NameInMap("VpcSwitchName")]
                [Validation(Required=false)]
                public string VpcSwitchName { get; set; }

                /// <summary>
                /// The zone ID of the vSwitch.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
