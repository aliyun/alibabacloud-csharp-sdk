// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserVipsByDomainResponseBody : TeaModel {
        /// <summary>
        /// The domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of VIPs.
        /// </summary>
        [NameInMap("Vips")]
        [Validation(Required=false)]
        public DescribeUserVipsByDomainResponseBodyVips Vips { get; set; }
        public class DescribeUserVipsByDomainResponseBodyVips : TeaModel {
            [NameInMap("Vip")]
            [Validation(Required=false)]
            public List<string> Vip { get; set; }

        }

    }

}
