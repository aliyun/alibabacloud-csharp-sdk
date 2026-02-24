// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEscalationPolicyForView : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workspace api monitor update test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("escalationStageList")]
        [Validation(Required=false)]
        public List<IncidentEscalationStageForView> EscalationStageList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Critical-Alert-Escalation&quot;</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;USER&quot;</para>
        /// </summary>
        [NameInMap("ownerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;cn-hangzhou&quot;</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;MANUAL&quot;</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;ARMS&quot;</para>
        /// </summary>
        [NameInMap("syncFromType")]
        [Validation(Required=false)]
        public string SyncFromType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-04-15T02:02:50Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;user-abc123&quot;</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;a1b2c3d4-e5f6-7890-1234-567890abcdef&quot;</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;ws-xyz789&quot;</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
