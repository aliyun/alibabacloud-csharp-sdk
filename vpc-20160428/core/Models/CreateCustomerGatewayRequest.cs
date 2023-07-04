// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateCustomerGatewayRequest : TeaModel {
        /// <summary>
        /// The autonomous system number (ASN) of the gateway device in the data center.
        /// 
        /// **Asn** is a 4-byte number. You can enter the number in two segments and separate the first 16 bits from the following 16 bits with a period (.). Enter the number in each segment in the decimal format.
        /// 
        /// For example, if you enter 123.456, the ASN is: 123 × 65536 + 456 = 8061384.
        /// </summary>
        [NameInMap("Asn")]
        [Validation(Required=false)]
        public string Asn { get; set; }

        /// <summary>
        /// The authentication key of the BGP routing protocol for the gateway device in the data center.
        /// 
        /// The key must be 1 to 64 characters in length. It can contain only ASCII characters and cannot contain spaces or question marks (?).
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the customer gateway.
        /// 
        /// The description must be 1 to 100 characters in length, and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The static public IP address of the gateway device in the data center.
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// The name of the customer gateway.
        /// 
        /// The name must be 1 to 100 characters in length, and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the customer gateway.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateCustomerGatewayRequestTags> Tags { get; set; }
        public class CreateCustomerGatewayRequestTags : TeaModel {
            /// <summary>
            /// The tag key. The tag key cannot be an empty string.
            /// 
            /// It can be at most 64 characters in length, and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// 
            /// You can specify at most 20 tag keys in each call.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// 
            /// The tag value can be an empty string and cannot exceed 128 characters in length. It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
            /// 
            /// Each tag key corresponds to one tag value. You can specify at most 20 tag values in each call.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
