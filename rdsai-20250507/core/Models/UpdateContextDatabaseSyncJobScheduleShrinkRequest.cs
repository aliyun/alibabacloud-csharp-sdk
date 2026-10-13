// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateContextDatabaseSyncJobScheduleShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sync-connection-20260923-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;09:00&quot;, &quot;18:00&quot;]</para>
        /// </summary>
        [NameInMap("DailyTimes")]
        [Validation(Required=false)]
        public string DailyTimesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("IntervalMinutes")]
        [Validation(Required=false)]
        public int? IntervalMinutes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>skip</para>
        /// </summary>
        [NameInMap("MissedPolicy")]
        [Validation(Required=false)]
        public string MissedPolicy { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>daily-times</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-as1llqmkol****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
