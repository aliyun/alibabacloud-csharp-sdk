// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ReinstallCollectorRequest : TeaModel {
        /// <summary>
        /// The request body parameters. For more information, see the Request body section in this topic.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Indicates whether the shipper is installed. Valid values:
        /// 
        /// *   true: The shipper is installed.
        /// *   false: The shipper fails to be installed.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
