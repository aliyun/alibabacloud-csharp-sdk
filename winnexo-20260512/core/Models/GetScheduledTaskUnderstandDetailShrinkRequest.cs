// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetScheduledTaskUnderstandDetailShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the collaboration group (such as cg_101). If this parameter is specified, a group space task is created (the caller must be a valid group member). If this parameter is left empty, a personal task is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleCollaborationGroupId</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The name of the current effective digital employee. This value is empty if not configured.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public string DigitalEmployeeNameShrink { get; set; }

        /// <summary>
        /// <para>The segments.</para>
        /// </summary>
        [NameInMap("segments")]
        [Validation(Required=false)]
        public string SegmentsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the effective tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The natural language task description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("userInput")]
        [Validation(Required=false)]
        public string UserInput { get; set; }

    }

}
