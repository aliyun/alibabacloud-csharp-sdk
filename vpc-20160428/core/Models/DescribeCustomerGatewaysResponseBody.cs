// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeCustomerGatewaysResponseBody : TeaModel {
        /// <summary>
        /// The information about customer gateways.
        /// </summary>
        [NameInMap("CustomerGateways")]
        [Validation(Required=false)]
        public DescribeCustomerGatewaysResponseBodyCustomerGateways CustomerGateways { get; set; }
        public class DescribeCustomerGatewaysResponseBodyCustomerGateways : TeaModel {
            [NameInMap("CustomerGateway")]
            [Validation(Required=false)]
            public List<DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGateway> CustomerGateway { get; set; }
            public class DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGateway : TeaModel {
                /// <summary>
                /// The autonomous system number (ASN) of the gateway device in the data center.
                /// </summary>
                [NameInMap("Asn")]
                [Validation(Required=false)]
                public long? Asn { get; set; }

                /// <summary>
                /// The authentication key of the Border Gateway Protocol (BGP) routing protocol for the gateway device in the data center.
                /// </summary>
                [NameInMap("AuthKey")]
                [Validation(Required=false)]
                public string AuthKey { get; set; }

                /// <summary>
                /// The timestamp generated when the customer gateway was created. Unit: millisecond.
                /// 
                /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The ID of the customer gateway.
                /// </summary>
                [NameInMap("CustomerGatewayId")]
                [Validation(Required=false)]
                public string CustomerGatewayId { get; set; }

                /// <summary>
                /// The description of the customer gateway.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The public IP address of the gateway device in the data center.
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// The name of the customer gateway.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the resource group to which the customer gateway belongs.
                /// 
                /// You can call the [ListResourceGroups](~~158855~~) operation to query the resource group information.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The list of tags added to the customer gateway.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGatewayTags Tags { get; set; }
                public class DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGatewayTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGatewayTagsTag> Tag { get; set; }
                    public class DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGatewayTagsTag : TeaModel {
                        /// <summary>
                        /// The key of tag N.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of tag N.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The page number.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
