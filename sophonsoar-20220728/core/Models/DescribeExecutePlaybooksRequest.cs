// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeExecutePlaybooksRequest : TeaModel {
        /// <summary>
        /// The entity type of the script input parameter. When you want to query multiple entity types, separate them with commas.
        /// - **ip**: IP entity.
        /// - **file**: file entity.
        /// - **process**: process entity.
        /// - **incident**: incident entity.
        /// </summary>
        [NameInMap("InputMode")]
        [Validation(Required=false)]
        public string InputMode { get; set; }

        /// <summary>
        /// The language of the content within the request and the response. Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The input parameter type of the playbook.
        /// 
        /// *   **template-ip**
        /// *   **template-file**
        /// *   **template-process**
        /// *   **custom**
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// The playbook name. Fuzzy search is supported.
        /// </summary>
        [NameInMap("PlaybookName")]
        [Validation(Required=false)]
        public string PlaybookName { get; set; }

        /// <summary>
        /// The playbook UUID.
        /// 
        /// >  You can call the [DescribePlaybooks](~~DescribePlaybooks~~) operation to query the playbook UUID.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
