// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ManageAlertRulesResult : TeaModel {
        /// <summary>
        /// <para>The details of the created or updated alert rule.</para>
        /// </summary>
        [NameInMap("alertRule")]
        [Validation(Required=false)]
        public AlertRuleV2 AlertRule { get; set; }

        /// <summary>
        /// <para>The number of deleted alert rules.</para>
        /// </summary>
        [NameInMap("deletedCount")]
        [Validation(Required=false)]
        public int? DeletedCount { get; set; }

        /// <summary>
        /// <para>A list of UUIDs of deleted alert rules.</para>
        /// </summary>
        [NameInMap("deletedUuidList")]
        [Validation(Required=false)]
        public List<string> DeletedUuidList { get; set; }

    }

}
