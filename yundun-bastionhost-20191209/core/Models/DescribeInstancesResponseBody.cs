// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the queried bastion hosts.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// The description of the bastion host.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The timestamp when the bastion host expires. Unit: milliseconds.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// The image version of the bastion host.
            /// </summary>
            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }

            /// <summary>
            /// The ID of the bastion host.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The state of the bastion host. Valid values:
            /// 
            /// *   **PENDING**: The bastion host is not initialized.
            /// *   **CREATING**: The bastion host is being created.
            /// *   **RUNNING**: The bastion host is running.
            /// *   **EXPIRED**: The bastion host expired.
            /// *   **CREATE_FAILED**: The bastion host fails to be created.
            /// *   **UPGRADING**: The configurations of the bastion host are being changed.
            /// *   **UPGRADE_FAILED**: The configurations of the bastion host fail to be changed.
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// The public O\&M address of the bastion host.
            /// </summary>
            [NameInMap("InternetEndpoint")]
            [Validation(Required=false)]
            public string InternetEndpoint { get; set; }

            /// <summary>
            /// The private O\&M address of the bastion host.
            /// </summary>
            [NameInMap("IntranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }

            /// <summary>
            /// Indicates whether the bastion host runs an earlier version. Valid values:
            /// 
            /// *   **true**: indicates that the bastion host runs V2 or V3.1.
            /// *   **false**:indicates that the bastion host runs V3.2.
            /// </summary>
            [NameInMap("Legacy")]
            [Validation(Required=false)]
            public bool? Legacy { get; set; }

            /// <summary>
            /// The license code of the bastion host.
            /// </summary>
            [NameInMap("LicenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }

            /// <summary>
            /// The edition of the bastion host. Valid values:
            /// 
            /// *   **cloudbastion**: Basic
            /// *   **cloudbastion_ha**: Enterprise
            /// </summary>
            [NameInMap("PlanCode")]
            [Validation(Required=false)]
            public string PlanCode { get; set; }

            /// <summary>
            /// Indicates whether the bastion host can be accessed from the Internet. Valid values:
            /// 
            /// *   **true**: The bastion host can be accessed from the Internet.
            /// *   **false**: The bastion host cannot be accessed from the Internet.
            /// </summary>
            [NameInMap("PublicNetworkAccess")]
            [Validation(Required=false)]
            public bool? PublicNetworkAccess { get; set; }

            /// <summary>
            /// The region ID of the bastion host.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the bastion host belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The timestamp when the bastion host is purchased or renewed. Unit: milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC) to which the bastion host belongs.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The ID of the vSwitch to which the bastion host belongs.
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of bastion hosts that are queried.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
