// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ManageAlertRulesResult : TeaModel {
        /// <summary>
        /// <para>The alert rule V2.</para>
        /// </summary>
        [NameInMap("alertRule")]
        [Validation(Required=false)]
        public AlertRuleV2 AlertRule { get; set; }

        /// <summary>
        /// <para>The number of rules that were successfully deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deletedCount")]
        [Validation(Required=false)]
        public int? DeletedCount { get; set; }

        /// <summary>
        /// <para>The list of UUIDs of rules that were successfully deleted.</para>
        /// </summary>
        [NameInMap("deletedUuidList")]
        [Validation(Required=false)]
        public List<string> DeletedUuidList { get; set; }

        /// <summary>
        /// <para>The number of rules that were successfully enabled or disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("updatedCount")]
        [Validation(Required=false)]
        public int? UpdatedCount { get; set; }

        /// <summary>
        /// <para>The list of UUIDs of rules that were successfully enabled or disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;a1b2c3d4-e5f6-7890-abcd-ef1234567890&quot;,&quot;b2c3d4e5-f6a7-8901-bcde-f12345678901&quot;]</para>
        /// </summary>
        [NameInMap("updatedUuidList")]
        [Validation(Required=false)]
        public List<string> UpdatedUuidList { get; set; }

    }

}
