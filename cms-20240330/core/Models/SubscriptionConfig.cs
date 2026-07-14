// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SubscriptionConfig : TeaModel {
        /// <summary>
        /// <para>The event content filtering conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>Specifies whether to subscribe to legacy product events (events with an empty workspace from CMS 1.0, ARMS, or SLS). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Subscribe.</description></item>
        /// <item><description>false/null: Do not subscribe.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("subscribeLegacyEvent")]
        [Validation(Required=false)]
        public bool? SubscribeLegacyEvent { get; set; }

        /// <summary>
        /// <para>The cross-workspace event routing (global subscription) settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("workspaceFilterSetting")]
        [Validation(Required=false)]
        public WorkspaceFilterSetting WorkspaceFilterSetting { get; set; }

    }

}
