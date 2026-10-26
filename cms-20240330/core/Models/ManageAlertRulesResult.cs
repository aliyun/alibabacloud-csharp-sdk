// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ManageAlertRulesResult : TeaModel {
        /// <summary>
        /// <para>The V2 alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;uuid&quot;:&quot;cms_v2_81d01768-fee9-459f-af49-ab2704f1db2b&quot;,&quot;displayName&quot;:&quot;drill-e2e-验证规则&quot;,&quot;enabled&quot;:true}</para>
        /// </summary>
        [NameInMap("alertRule")]
        [Validation(Required=false)]
        public AlertRuleV2 AlertRule { get; set; }

        /// <summary>
        /// <para>The number of successfully deleted rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deletedCount")]
        [Validation(Required=false)]
        public int? DeletedCount { get; set; }

        /// <summary>
        /// <para>The list of UUIDs of successfully deleted rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cms_v2_81d01768-fee9-459f-af49-ab2704f1db2b&quot;]</para>
        /// </summary>
        [NameInMap("deletedUuidList")]
        [Validation(Required=false)]
        public List<string> DeletedUuidList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7c27ee14-5f94-469f-912d-476f79c8a861</para>
        /// </summary>
        [NameInMap("drillUuid")]
        [Validation(Required=false)]
        public string DrillUuid { get; set; }

        /// <summary>
        /// <para>The number of successfully enabled or disabled rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("updatedCount")]
        [Validation(Required=false)]
        public int? UpdatedCount { get; set; }

        /// <summary>
        /// <para>The list of UUIDs of successfully enabled or disabled rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;a1b2c3d4-e5f6-7890-abcd-ef1234567890&quot;,&quot;b2c3d4e5-f6a7-8901-bcde-f12345678901&quot;]</para>
        /// </summary>
        [NameInMap("updatedUuidList")]
        [Validation(Required=false)]
        public List<string> UpdatedUuidList { get; set; }

    }

}
