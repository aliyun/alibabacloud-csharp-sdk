// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceDetailResponseBody : TeaModel {
        /// <summary>
        /// The list of exposure details of the server.
        /// </summary>
        [NameInMap("ExposedChains")]
        [Validation(Required=false)]
        public List<DescribeExposedInstanceDetailResponseBodyExposedChains> ExposedChains { get; set; }
        public class DescribeExposedInstanceDetailResponseBodyExposedChains : TeaModel {
            /// <summary>
            /// The details of all vulnerabilities on the server.
            /// </summary>
            [NameInMap("AllVulList")]
            [Validation(Required=false)]
            public List<DescribeExposedInstanceDetailResponseBodyExposedChainsAllVulList> AllVulList { get; set; }
            public class DescribeExposedInstanceDetailResponseBodyExposedChainsAllVulList : TeaModel {
                /// <summary>
                /// The alias of the vulnerability.
                /// </summary>
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                /// <summary>
                /// The name of the vulnerability.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The priority to fix the vulnerability. Valid values:
                /// 
                /// *   **asap**: high
                /// *   **later**: medium
                /// *   **nntf**: low
                /// 
                /// > We recommend that you fix the vulnerabilities that have the **high** priority at the earliest opportunity.
                /// </summary>
                [NameInMap("Necessity")]
                [Validation(Required=false)]
                public string Necessity { get; set; }

                /// <summary>
                /// The type of the vulnerability. Valid values:
                /// 
                /// *   **cve**: Linux software vulnerability
                /// *   **sys**: Windows system vulnerability
                /// *   **cms**: Web-CMS vulnerability
                /// *   **app**: application vulnerability
                /// *   **emg**: urgent vulnerability
                /// *   **sca**: middleware vulnerability
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The UUID of the server.
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// The server component that is exposed on the Internet.
            /// </summary>
            [NameInMap("ExposureComponent")]
            [Validation(Required=false)]
            public string ExposureComponent { get; set; }

            /// <summary>
            /// The IP address that is exposed.
            /// </summary>
            [NameInMap("ExposureIp")]
            [Validation(Required=false)]
            public string ExposureIp { get; set; }

            /// <summary>
            /// The port that is exposed on the Internet.
            /// </summary>
            [NameInMap("ExposurePort")]
            [Validation(Required=false)]
            public string ExposurePort { get; set; }

            /// <summary>
            /// The resource from which the server is exposed. Valid values:
            /// 
            /// *   **INTERNET_IP**: the public IP address of an Elastic Compute Service (ECS) instance
            /// *   **SLB**: the public IP address of a Server Load Balancer (SLB) instance
            /// *   **EIP**: an elastic IP address (EIP)
            /// *   **DNAT**: the NAT gateway that connects to the Internet by using the DNAT feature
            /// </summary>
            [NameInMap("ExposureType")]
            [Validation(Required=false)]
            public string ExposureType { get; set; }

            /// <summary>
            /// The ID of the instance to which the resource belongs. The valid values of this parameter vary based on the ExposureType parameter.
            /// 
            /// *   If the value of the ExposureType parameter is **INTERNET_IP**, this parameter is empty.
            /// *   If the value of the ExposureType parameter is **SLB**, the value of this parameter is the ID of the SLB instance.
            /// *   If the value of the ExposureType parameter is **EIP**, the value of this parameter is the ID of the EIP.
            /// *   If the value of the ExposureType parameter is **DNAT**, the value of this parameter is the ID of the NAT gateway.
            /// </summary>
            [NameInMap("ExposureTypeId")]
            [Validation(Required=false)]
            public string ExposureTypeId { get; set; }

            /// <summary>
            /// The server group to which the server belongs.
            /// </summary>
            [NameInMap("GroupNo")]
            [Validation(Required=false)]
            public string GroupNo { get; set; }

            /// <summary>
            /// The instance ID of the server.
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
            /// The public IP address of the server.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the server.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The information about the vulnerabilities that are exposed on the Internet and can be exploited by attackers.
            /// </summary>
            [NameInMap("RealVulList")]
            [Validation(Required=false)]
            public List<DescribeExposedInstanceDetailResponseBodyExposedChainsRealVulList> RealVulList { get; set; }
            public class DescribeExposedInstanceDetailResponseBodyExposedChainsRealVulList : TeaModel {
                /// <summary>
                /// The alias of the vulnerability.
                /// </summary>
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                /// <summary>
                /// The name of the vulnerability.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The priority to fix the vulnerability. Valid values:
                /// 
                /// *   **asap**: high
                /// *   **later**: medium
                /// *   **nntf**: low
                /// 
                /// > We recommend that you fix the vulnerabilities that have the **high** priority at the earliest opportunity.
                /// </summary>
                [NameInMap("Necessity")]
                [Validation(Required=false)]
                public string Necessity { get; set; }

                /// <summary>
                /// The type of the vulnerability. Valid values:
                /// 
                /// *   **cve**: Linux software vulnerability
                /// *   **sys**: Windows system vulnerability
                /// *   **cms**: Web-CMS vulnerability
                /// *   **app**: application vulnerability
                /// *   **emg**: urgent vulnerability
                /// *   **sca**: middleware vulnerability
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The UUID of the server.
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// The region in which the server resides.
            /// 
            /// > For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
