// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DebugPlaybookRequest : TeaModel {
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
        /// The playbook UUID.
        /// 
        /// >  You can call the [DescribePlaybooks](~~DescribePlaybooks~~)operation to query the playbook UUID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// The input parameters that you use to debug the playbook. You can define the parameters based on your business requirements.
        /// </summary>
        [NameInMap("Record")]
        [Validation(Required=false)]
        public string Record { get; set; }

        /// <summary>
        /// The XML configuration of the playbook.
        /// 
        /// >  You can call the [DescribePlaybook](~~DescribePlaybook~~) operation to query the XML configuration of the playbook.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Taskflow")]
        [Validation(Required=false)]
        public string Taskflow { get; set; }

    }

}
