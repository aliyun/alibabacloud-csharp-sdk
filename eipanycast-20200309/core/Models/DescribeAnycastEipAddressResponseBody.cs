// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class DescribeAnycastEipAddressResponseBody : TeaModel {
        /// <summary>
        /// The ID of the account to which the Anycast EIP belongs.
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// The information about the endpoint with which the Anycast EIP is associated.
        /// </summary>
        [NameInMap("AnycastEipBindInfoList")]
        [Validation(Required=false)]
        public List<DescribeAnycastEipAddressResponseBodyAnycastEipBindInfoList> AnycastEipBindInfoList { get; set; }
        public class DescribeAnycastEipAddressResponseBodyAnycastEipBindInfoList : TeaModel {
            /// <summary>
            /// The association mode. Valid values:
            /// 
            /// *   **Default**: the default mode. In this mode, the associated endpoint serves as the default origin server.
            /// *   **Normal**: the standard mode. In this mode, the associated endpoint serves as a standard origin server.
            /// </summary>
            [NameInMap("AssociationMode")]
            [Validation(Required=false)]
            public string AssociationMode { get; set; }

            /// <summary>
            /// The ID of the endpoint with which the Anycast EIP is associated.
            /// </summary>
            [NameInMap("BindInstanceId")]
            [Validation(Required=false)]
            public string BindInstanceId { get; set; }

            /// <summary>
            /// The ID of the region in which the endpoint is deployed.
            /// </summary>
            [NameInMap("BindInstanceRegionId")]
            [Validation(Required=false)]
            public string BindInstanceRegionId { get; set; }

            /// <summary>
            /// The type of endpoint with which the Anycast EIP is associated. Valid values:
            /// 
            /// *   **SlbInstance**: a CLB instance in a VPC.
            /// *   **NetworkInterface**: an elastic network interface (ENI).
            /// </summary>
            [NameInMap("BindInstanceType")]
            [Validation(Required=false)]
            public string BindInstanceType { get; set; }

            /// <summary>
            /// The time when the Anycast EIP was associated.
            /// 
            /// The time follows the ISO 8601 standard in the `YYYY-MM-DDThh:mm:ssZ` format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("BindTime")]
            [Validation(Required=false)]
            public string BindTime { get; set; }

            /// <summary>
            /// The information about the access points in associated access areas when you associate an Anycast EIP with a cloud resource.
            /// 
            /// If this is your first time associating an Anycast EIP with an endpoint, the system returns information about access points in all access areas.
            /// </summary>
            [NameInMap("PopLocations")]
            [Validation(Required=false)]
            public List<DescribeAnycastEipAddressResponseBodyAnycastEipBindInfoListPopLocations> PopLocations { get; set; }
            public class DescribeAnycastEipAddressResponseBodyAnycastEipBindInfoListPopLocations : TeaModel {
                /// <summary>
                /// The information about the access points in associated access areas when you associate an Anycast EIP with a cloud resource.
                /// 
                /// If this is your first time associating an Anycast EIP with an endpoint, the system returns information about access points in all access areas.
                /// </summary>
                [NameInMap("PopLocation")]
                [Validation(Required=false)]
                public string PopLocation { get; set; }

            }

            /// <summary>
            /// The secondary private IP address of the associated ENI.
            /// 
            /// This parameter is valid only when **BindInstanceType** is set to **NetworkInterface**.
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public string PrivateIpAddress { get; set; }

            /// <summary>
            /// The status of the endpoint. Valid values:
            /// 
            /// *   **BINDING**
            /// *   **BINDED**
            /// *   **UNBINDING**
            /// *   **DELETED**
            /// *   **MODIFYING**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// The BID of the account to which the Anycast EIP belongs.
        /// </summary>
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

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
        /// The point in time at which the Anycast EIP was created.
        /// 
        /// The time follows the ISO8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time is displayed in UTC.
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
        /// Only **PostPaid** may be returned, which indicates the pay-as-you-go billing method.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The metering method of the Anycast EIP.
        /// 
        /// Only **PayByTraffic** may be returned, which indicates the pay-by-data-transfer metering method.
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

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The access area of the Anycast EIP.
        /// 
        /// Only **international** may be returned, which indicates the areas outside the Chinese mainland.
        /// </summary>
        [NameInMap("ServiceLocation")]
        [Validation(Required=false)]
        public string ServiceLocation { get; set; }

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
        public List<DescribeAnycastEipAddressResponseBodyTags> Tags { get; set; }
        public class DescribeAnycastEipAddressResponseBodyTags : TeaModel {
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

}
