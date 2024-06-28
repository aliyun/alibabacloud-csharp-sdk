// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class RenamePlaybookNodeRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and the response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The new name of the node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NewNodeName")]
        [Validation(Required=false)]
        public string NewNodeName { get; set; }

        /// <summary>
        /// The original name of the node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OldNodeName")]
        [Validation(Required=false)]
        public string OldNodeName { get; set; }

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
