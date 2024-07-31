// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class ListAnycastEipAddressesRequest : TeaModel {
        /// <summary>
        /// The IP address that is allocated to the Anycast EIP.
        /// </summary>
        [NameInMap("AnycastEipAddress")]
        [Validation(Required=false)]
        public string AnycastEipAddress { get; set; }

        /// <summary>
        /// The ID of the Anycast EIP.
        /// 
        /// >  To ensure the accuracy of the query result, we do not recommend that you specify **AnycastIds** and **AnycastId** at the same time.
        /// </summary>
        [NameInMap("AnycastId")]
        [Validation(Required=false)]
        public string AnycastId { get; set; }

        /// <summary>
        /// The IDs of Anycast EIPs.
        /// 
        /// You can enter at most 50 Anycast EIP IDs.
        /// 
        /// >  To ensure the accuracy of the query result, we do not recommend that you specify **AnycastIds** and **AnycastId** at the same time.
        /// </summary>
        [NameInMap("AnycastIds")]
        [Validation(Required=false)]
        public List<string> AnycastIds { get; set; }

        /// <summary>
        /// The IDs of the cloud resources with which the Anycast EIPs are associated.
        /// 
        /// You can enter at most 100 cloud resource IDs.
        /// </summary>
        [NameInMap("BindInstanceIds")]
        [Validation(Required=false)]
        public List<string> BindInstanceIds { get; set; }

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
        /// The billing method of the Anycast EIP.
        /// 
        /// Set the value to **PostPaid**, which specifies the pay-as-you-go billing method.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The metering method of the Anycast EIP.
        /// 
        /// Set the value to **PayByTraffic**, which specifies the pay-by-data-transfer metering method.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **20 to 100**. Default value: **50**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The name of the Anycast EIP.
        /// 
        /// The name must be 0 to 128 characters in length, and can contain digits, hyphens (-), and underscores (_). The name must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   You do not need to specify this parameter for the first request.
        /// *   You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The access area of the Anycast EIP.
        /// 
        /// Set the value to **international**, which specifies the regions outside the Chinese mainland.
        /// </summary>
        [NameInMap("ServiceLocation")]
        [Validation(Required=false)]
        public string ServiceLocation { get; set; }

        /// <summary>
        /// The status of the Anycast EIP. Valid values:
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
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListAnycastEipAddressesRequestTags> Tags { get; set; }
        public class ListAnycastEipAddressesRequestTags : TeaModel {
            /// <summary>
            /// The tag key of the resource. You can specify up to 20 tag keys. You cannot specify empty strings as tag keys.
            /// 
            /// The key can be up to 64 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The key must start with a letter but cannot start with `aliyun` or `acs:`. The key cannot contain `http://` or `https://`.
            /// 
            /// >  You must specify at least one of **Tag.N** (**Tag.N.Key** and **Tag.N.Value**).
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the resource. You can specify up to 20 tag values. It can be an empty string.
            /// 
            /// The value cannot exceed 128 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). The value must start with a letter but cannot start with `aliyun` or `acs:`. The value cannot contain `http://` or `https://`.
            /// 
            /// >  You must specify at least one of **Tag.N** (**Tag.N.Key** and **Tag.N.Value**).
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
