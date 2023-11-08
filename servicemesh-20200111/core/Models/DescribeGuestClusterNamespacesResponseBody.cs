// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeGuestClusterNamespacesResponseBody : TeaModel {
        /// <summary>
        /// The labels of the namespaces. Labels are returned only when `ShowNsLabels` is set to `true`.
        /// </summary>
        [NameInMap("NsLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> NsLabels { get; set; }

        /// <summary>
        /// The names of the namespaces.
        /// </summary>
        [NameInMap("NsList")]
        [Validation(Required=false)]
        public List<string> NsList { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
