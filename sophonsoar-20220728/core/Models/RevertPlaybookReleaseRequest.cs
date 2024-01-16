// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class RevertPlaybookReleaseRequest : TeaModel {
        /// <summary>
        /// Specifies whether to directly publish the new playbook after the rollback.
        /// 
        /// *   **true** (default)
        /// *   **false**
        /// </summary>
        [NameInMap("IsPublish")]
        [Validation(Required=false)]
        public bool? IsPublish { get; set; }

        /// <summary>
        /// The version of the playbook that you want to publish.
        /// 
        /// >  You can call the [DescribePlaybookReleases](~~DescribePlaybookReleases~~) operation to query the playbook version.
        /// </summary>
        [NameInMap("PlayReleaseId")]
        [Validation(Required=false)]
        public int? PlayReleaseId { get; set; }

        /// <summary>
        /// The UUID of the playbook.
        /// 
        /// >  You can call the [DescribePlaybooks](~~DescribePlaybooks~~)operation to query the playbook UUID.
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

    }

}
