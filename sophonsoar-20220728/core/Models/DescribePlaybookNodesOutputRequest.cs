// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookNodesOutputRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The name of the component node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// The UUID of the playbook.
        /// 
        /// >  You can call the [DescribePlaybooks](~~DescribePlaybooks~~)operation to query the UUIDs of playbooks.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

    }

}
