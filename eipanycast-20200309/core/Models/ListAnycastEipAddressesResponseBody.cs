// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class ListAnycastEipAddressesResponseBody : TeaModel {
        /// <summary>
        /// The list of Anycast EIPs.
        /// </summary>
        [NameInMap("AnycastList")]
        [Validation(Required=false)]
        public List<ListAnycastEipAddressesResponseBodyAnycastList> AnycastList { get; set; }
        public class ListAnycastEipAddressesResponseBodyAnycastList : TeaModel {
            /// <summary>
            /// The ID of the account to which the Anycast EIP belongs.
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// The list of cloud resources with which the Anycast EIPs are associated.
            /// </summary>
            [NameInMap("AnycastEipBindInfoList")]
            [Validation(Required=false)]
            public List<ListAnycastEipAddressesResponseBodyAnycastListAnycastEipBindInfoList> AnycastEipBindInfoList { get; set; }
            public class ListAnycastEipAddressesResponseBodyAnycastListAnycastEipBindInfoList : TeaModel {
                /// <summary>
                /// The ID of the cloud resource with which the Anycast EIP is associated.
                /// </summary>
                [NameInMap("BindInstanceId")]
                [Validation(Required=false)]
                public string BindInstanceId { get; set; }

                /// <summary>
                /// The ID of the region where the cloud resource is deployed.
                /// </summary>
                [NameInMap("BindInstanceRegionId")]
                [Validation(Required=false)]
                public string BindInstanceRegionId { get; set; }

                /// <summary>
                /// The type of cloud resource with which the Anycast EIP is associated.
                /// 
                /// *   **SlbInstance**: an internal-facing Classic Load Balancer (CLB) instance deployed in a virtual private cloud (VPC). CLB is formerly known as Server Load Balancer (SLB).
                /// *   **NetworkInterface**: an elastic network interface (ENI).
                /// </summary>
                [NameInMap("BindInstanceType")]
                [Validation(Required=false)]
                public string BindInstanceType { get; set; }

                /// <summary>
                /// The time when the Anycast EIP was associated.
                /// </summary>
                [NameInMap("BindTime")]
                [Validation(Required=false)]
                public string BindTime { get; set; }

            }

            /// <summary>
            /// The ID of the Anycast EIP.
            /// </summary>
            [NameInMap("AnycastId")]
            [Validation(Required=false)]
            public string AnycastId { get; set; }

            /// <summary>
            /// The maximum bandwidth of the Anycast EIP. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The service status of the Anycast EIP. Valid values:
            /// 
            /// *   **Normal**
            /// *   **FinancialLocked**
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// The time when the Anycast EIP was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the Anycast EIP.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The billing method of the Anycast EIP.
            /// 
            /// **PostPaid**: pay-as-you-go
            /// </summary>
            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// The metering method of the Anycast EIP.
            /// 
            /// **PayByTraffic**: pay-by-data-transfer
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// The IP address of the Anycast EIP.
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// The name of the Anycast EIP.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The access area of the Anycast EIP.
            /// 
            /// **international**: regions outside the Chinese mainland
            /// </summary>
            [NameInMap("ServiceLocation")]
            [Validation(Required=false)]
            public string ServiceLocation { get; set; }

            /// <summary>
            /// Indicates whether the resource is created by the service account.
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public int? ServiceManaged { get; set; }

            /// <summary>
            /// The status of the Anycast EIP.
            /// 
            /// *   **Associating**
            /// *   **Unassociating**
            /// *   **Allocated**
            /// *   **Associated**
            /// *   **Modifying**
            /// *   **Releasing**
            /// *   **Released**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The information about the tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListAnycastEipAddressesResponseBodyAnycastListTags> Tags { get; set; }
            public class ListAnycastEipAddressesResponseBodyAnycastListTags : TeaModel {
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

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If **NextToken** is not empty, the value of NextToken can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
