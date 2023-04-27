// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResourcePortResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array of HTTP and HTTPS listener ports that are added to the WAF instance.
        /// </summary>
        [NameInMap("ResourcePorts")]
        [Validation(Required=false)]
        public List<string> ResourcePorts { get; set; }

    }

}
