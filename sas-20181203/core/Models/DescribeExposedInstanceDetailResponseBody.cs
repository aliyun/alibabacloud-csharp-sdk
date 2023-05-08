// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceDetailResponseBody : TeaModel {
        /// <summary>
        /// The UUID of the server that is exposed on the Internet.
        /// 
        /// >  You can call the [DescribeExposedInstanceList](~~DescribeExposedInstanceList~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("ExposedChains")]
        [Validation(Required=false)]
        public List<DescribeExposedInstanceDetailResponseBodyExposedChains> ExposedChains { get; set; }
        public class DescribeExposedInstanceDetailResponseBodyExposedChains : TeaModel {
            [NameInMap("AllVulList")]
            [Validation(Required=false)]
            public List<DescribeExposedInstanceDetailResponseBodyExposedChainsAllVulList> AllVulList { get; set; }
            public class DescribeExposedInstanceDetailResponseBodyExposedChainsAllVulList : TeaModel {
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Necessity")]
                [Validation(Required=false)]
                public string Necessity { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// The ID of the instance to which the resource belongs. The valid values of this parameter vary based on the value of the ExposureType parameter.
            /// 
            /// *   If the value of the ExposureType parameter is **INTERNET_IP**, the value of this parameter is an empty string.
            /// *   If the value of the ExposureType parameter is **SLB**, the value of this parameter is the ID of the Internet-facing SLB instance.
            /// *   If the value of the ExposureType parameter is **EIP**, the value of this parameter is the ID of the EIP.
            /// *   If the value of the ExposureType parameter is **DNAT**, the value of this parameter is the ID of the NAT gateway.
            /// </summary>
            [NameInMap("ExposureComponent")]
            [Validation(Required=false)]
            public string ExposureComponent { get; set; }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("ExposureIp")]
            [Validation(Required=false)]
            public string ExposureIp { get; set; }

            /// <summary>
            /// The information about the vulnerabilities that are exposed on the Internet and can be exploited by attackers.
            /// </summary>
            [NameInMap("ExposurePort")]
            [Validation(Required=false)]
            public string ExposurePort { get; set; }

            /// <summary>
            /// The priority to fix the vulnerability. Valid values:
            /// 
            /// *   **asap**: high
            /// *   **later**: medium
            /// *   **nntf**: low
            /// 
            /// >  We recommend that you fix the vulnerabilities that have the **high** priority at the earliest opportunity.
            /// </summary>
            [NameInMap("ExposureType")]
            [Validation(Required=false)]
            public string ExposureType { get; set; }

            /// <summary>
            /// The public IP address of the server.
            /// </summary>
            [NameInMap("ExposureTypeId")]
            [Validation(Required=false)]
            public string ExposureTypeId { get; set; }

            /// <summary>
            /// The port that is exposed on the Internet.
            /// </summary>
            [NameInMap("GroupNo")]
            [Validation(Required=false)]
            public string GroupNo { get; set; }

            /// <summary>
            /// The public IP address.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The type of the vulnerability. Valid values:
            /// 
            /// *   **cve**: Linux software vulnerabilities
            /// *   **sys**: Windows system vulnerabilities
            /// *   **cms**: Web-CMS vulnerabilities
            /// *   **app**: application vulnerabilities
            /// *   **emg**: urgent vulnerabilities
            /// *   **sca**: middleware vulnerabilities
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The alias of the vulnerability.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The name of the vulnerability.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The information about all vulnerabilities on the server.
            /// </summary>
            [NameInMap("RealVulList")]
            [Validation(Required=false)]
            public List<DescribeExposedInstanceDetailResponseBodyExposedChainsRealVulList> RealVulList { get; set; }
            public class DescribeExposedInstanceDetailResponseBodyExposedChainsRealVulList : TeaModel {
                /// <summary>
                /// Queries the details about a specified server that is exposed on the Internet.
                /// </summary>
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                /// <summary>
                /// DescribeExposedInstanceDetail
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the request, which is used to locate and troubleshoot issues.
                /// </summary>
                [NameInMap("Necessity")]
                [Validation(Required=false)]
                public string Necessity { get; set; }

                /// <summary>
                /// The resource from which the server is exposed. Valid values:
                /// 
                /// *   **INTERNET_IP**: the public IP address of an Elastic Compute Service (ECS) instance
                /// *   **SLB**: the public IP address of a Server Load Balancer (SLB) instance
                /// *   **EIP**: an elastic IP address (EIP)
                /// *   **DNAT**: the NAT gateway that connects to the Internet by using the DNAT feature
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The ID of the server.
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// The alias of the vulnerability.
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
        /// The exposure details about the server.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
