// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SubscriptionForSNSModify : TeaModel {
        /// <summary>
        /// <para>The event content filter that matches conditions based on event fields such as labels, source, and severity. If this parameter is not specified, no events are received.</para>
        /// </summary>
        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>Specifies whether to subscribe to legacy product events (CMS 1.0, ARMS, or SLS events where workspace is null). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Subscribe to legacy product events.</description></item>
        /// <item><description>false or null: Do not subscribe to legacy product events.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("subscribeLegacyEvent")]
        [Validation(Required=false)]
        public bool? SubscribeLegacyEvent { get; set; }

        /// <summary>
        /// <para>The global subscription configuration. If the subscription needs to receive events from other workspaces, specify the target workspace list by using workspaceUuids. If this parameter is not configured, only events from the current workspace are received.</para>
        /// </summary>
        [NameInMap("workspaceFilterSetting")]
        [Validation(Required=false)]
        public WorkspaceFilterSetting WorkspaceFilterSetting { get; set; }

    }

}
