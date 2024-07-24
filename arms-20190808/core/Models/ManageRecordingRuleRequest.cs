// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ManageRecordingRuleRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The ID of the user.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("QueryUserId")]
        [Validation(Required=false)]
        public string QueryUserId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The recording rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleYaml")]
        [Validation(Required=false)]
        public string RuleYaml { get; set; }

    }

}
