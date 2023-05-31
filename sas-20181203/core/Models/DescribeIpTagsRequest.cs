// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIpTagsRequest : TeaModel {
        /// <summary>
        /// The IP address in the alert event.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The ID of the alert event.
        /// </summary>
        [NameInMap("SecurityEventId")]
        [Validation(Required=false)]
        public string SecurityEventId { get; set; }

    }

}
