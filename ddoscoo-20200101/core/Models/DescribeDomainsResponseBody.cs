// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainsResponseBody : TeaModel {
        /// <summary>
        /// An array consisting of details of the domain name for which the forwarding rules are configured.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
