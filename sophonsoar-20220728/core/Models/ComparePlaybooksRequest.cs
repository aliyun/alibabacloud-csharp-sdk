// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class ComparePlaybooksRequest : TeaModel {
        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The UUID of the second version.
        /// 
        /// >  You can call the [DescribePopApiVersionList](~~DescribePopApiVersionList~~) operation to query the UUIDs of versions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NewPlaybookReleaseId")]
        [Validation(Required=false)]
        public int? NewPlaybookReleaseId { get; set; }

        /// <summary>
        /// The UUID of the first version.
        /// 
        /// >  You can call the [DescribePopApiVersionList](~~DescribePopApiVersionList~~) operation to query the UUIDs of versions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OldPlaybookReleaseId")]
        [Validation(Required=false)]
        public int? OldPlaybookReleaseId { get; set; }

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
