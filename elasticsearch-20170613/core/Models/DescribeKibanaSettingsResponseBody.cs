// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeKibanaSettingsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Some configurable Kibana settings information. For more information, see [Kibana settings](https://www.elastic.co/guide/cn/kibana/current/settings.html).
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public Dictionary<string, object> Result { get; set; }

    }

}
