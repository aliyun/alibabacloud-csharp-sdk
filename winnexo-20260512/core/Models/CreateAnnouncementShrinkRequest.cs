// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateAnnouncementShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The content of the notice.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The system will undergo maintenance tonight</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The display page. Valid values: ALL, FRONTEND, and BACKEND.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("displayPage")]
        [Validation(Required=false)]
        public string DisplayPage { get; set; }

        /// <summary>
        /// <para>The display type and group label.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIST</para>
        /// </summary>
        [NameInMap("displayType")]
        [Validation(Required=false)]
        public string DisplayType { get; set; }

        /// <summary>
        /// <para>The effective end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-21T14:00:00+08:00</para>
        /// </summary>
        [NameInMap("effectiveEnd")]
        [Validation(Required=false)]
        public string EffectiveEnd { get; set; }

        /// <summary>
        /// <para>The effective start time in ISO 8601 format with time zone information. If this parameter is not specified, the notice takes effect immediately.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-20T14:00:00+08:00</para>
        /// </summary>
        [NameInMap("effectiveStart")]
        [Validation(Required=false)]
        public string EffectiveStart { get; set; }

        /// <summary>
        /// <para>The priority level. Valid values:</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GENERAL</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>Specifies whether to publish the notice immediately after creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("publishNow")]
        [Validation(Required=false)]
        public bool? PublishNow { get; set; }

        /// <summary>
        /// <para>The list of system role codes. This parameter is used when targetRoleMode is set to SPECIFIED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;SYSTEM_ADMIN&quot;]</para>
        /// </summary>
        [NameInMap("targetRoleCodes")]
        [Validation(Required=false)]
        public string TargetRoleCodesShrink { get; set; }

        /// <summary>
        /// <para>The target role scope. Valid values: ALL and SPECIFIED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("targetRoleMode")]
        [Validation(Required=false)]
        public string TargetRoleMode { get; set; }

        /// <summary>
        /// <para>The list of target tenant IDs. This parameter is used when targetTenantMode is set to SPECIFIED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[10000]</para>
        /// </summary>
        [NameInMap("targetTenantIds")]
        [Validation(Required=false)]
        public string TargetTenantIdsShrink { get; set; }

        /// <summary>
        /// <para>The target tenant scope. Valid values: ALL and SPECIFIED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("targetTenantMode")]
        [Validation(Required=false)]
        public string TargetTenantMode { get; set; }

        /// <summary>
        /// <para>The ID of the tenant for which the notice takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The title of the notice.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System Maintenance Notification</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
