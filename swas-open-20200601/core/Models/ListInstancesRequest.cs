// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// The billing method of the simple application server. Set the value to PrePaid, which indicates the subscription billing method. Only the subscription billing method is supported.
        /// 
        /// Default value: PrePaid.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The IDs of the simple application servers. The value can be a JSON array that consists of up to 100 simple application server IDs. Separate the server IDs with commas (,).
        /// 
        /// >  If you specify both `InstanceIds` and `PublicIpAddresses`, make sure that each specified ID and its corresponding public IP address belong to the same simple application server. Otherwise, an empty result is returned.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The public IP addresses of the simple application servers. The value can be a JSON array that consists of up to 100 IP addresses. Separate the IP addresses with commas (,).
        /// 
        /// >  If you specify both `InstanceIds` and `PublicIpAddresses`, make sure that each specified ID and its corresponding public IP address belong to the same simple application server. Otherwise, an empty result is returned.
        /// </summary>
        [NameInMap("PublicIpAddresses")]
        [Validation(Required=false)]
        public string PublicIpAddresses { get; set; }

        /// <summary>
        /// The region ID of the simple application servers.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
