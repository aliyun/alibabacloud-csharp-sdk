// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeFieldRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The key of the global configuration. Valid values:
        /// 
        /// *   **soar_filed_tags**: queries the input template of the playbook.
        /// </summary>
        [NameInMap("QueryKey")]
        [Validation(Required=false)]
        public string QueryKey { get; set; }

    }

}
