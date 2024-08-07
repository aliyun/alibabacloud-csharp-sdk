// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecSlsLogStoresResponseBody : TeaModel {
        /// <summary>
        /// The names of the Logstores in Simple Log Service.
        /// </summary>
        [NameInMap("LogStores")]
        [Validation(Required=false)]
        public List<string> LogStores { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
