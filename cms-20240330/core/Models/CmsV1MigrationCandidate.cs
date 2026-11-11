// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CmsV1MigrationCandidate : TeaModel {
        /// <summary>
        /// <para>The name of the source application group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-service</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The current migration or takeover status of the source group. Valid values: NOT_MIGRATED: Not migrated. PROCESSING: In progress. MIGRATED: Migrated. If a historical task lacks proof of source read-only status, NEEDS_REVIEW is returned through rejectionReason.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROCESSING</para>
        /// </summary>
        [NameInMap("migrationStatus")]
        [Validation(Required=false)]
        public string MigrationStatus { get; set; }

        /// <summary>
        /// <para>The ID of the target observation group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>og-0123456789abcdef</para>
        /// </summary>
        [NameInMap("observeGroupId")]
        [Validation(Required=false)]
        public string ObserveGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the source CloudMonitor 1.0 application group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>247675311</para>
        /// </summary>
        [NameInMap("originGroupId")]
        [Validation(Required=false)]
        public string OriginGroupId { get; set; }

        /// <summary>
        /// <para>The reason why the group cannot be selected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NEEDS_REVIEW</para>
        /// </summary>
        [NameInMap("rejectionReason")]
        [Validation(Required=false)]
        public string RejectionReason { get; set; }

        /// <summary>
        /// <para>Specifies whether the group can be selected for migration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("selectable")]
        [Validation(Required=false)]
        public bool? Selectable { get; set; }

        /// <summary>
        /// <para>Specifies whether the source 1.0 group is persistently read-only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("sourceReadOnly")]
        [Validation(Required=false)]
        public bool? SourceReadOnly { get; set; }

        /// <summary>
        /// <para>The type of the source application group. Valid values: custom: Custom group. tag: Tag-based group. regMgr: Resource group-based group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The name of the target observation group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-service</para>
        /// </summary>
        [NameInMap("targetGroupName")]
        [Validation(Required=false)]
        public string TargetGroupName { get; set; }

    }

}
