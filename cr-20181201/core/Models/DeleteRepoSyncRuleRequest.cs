// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class DeleteRepoSyncRuleRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the synchronization rule.
        /// </summary>
        [NameInMap("SyncRuleId")]
        [Validation(Required=false)]
        public string SyncRuleId { get; set; }

    }

}
