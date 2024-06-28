// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class ModifyPlaybookInstanceStatusRequest : TeaModel {
        /// <summary>
        /// The playbook status. Valid values:
        /// 
        /// *   **1**: starts the playbook.
        /// *   **0**: stops the playbook.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public int? Active { get; set; }

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
        /// The playbook UUID.
        /// 
        /// >  You can call the [DescribePlaybooks](~~DescribePlaybooks~~) operation to query the playbook UUID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

    }

}
