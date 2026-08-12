// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SubscriptionForSNSModify : TeaModel {
        /// <summary>
        /// <para>The filter configuration.</para>
        /// </summary>
        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>Specifies whether to subscribe to legacy product events (CMS 1.0, ARMS, or SLS events where workspace is null). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Subscribe.</description></item>
        /// <item><description>false or null: Do not subscribe.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("subscribeLegacyEvent")]
        [Validation(Required=false)]
        public bool? SubscribeLegacyEvent { get; set; }

        /// <summary>
        /// <para>The workspace filter configuration.</para>
        /// </summary>
        [NameInMap("workspaceFilterSetting")]
        [Validation(Required=false)]
        public WorkspaceFilterSetting WorkspaceFilterSetting { get; set; }

    }

}
