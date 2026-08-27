// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetScheduledTaskPushOptionsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the collaboration group (such as cg_101). If specified, a group workspace task is created (the caller must be a valid group member). If left empty, a personal task is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_401</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The name of the currently active digital employee. This value is empty if not configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleDigitalEmployeeName</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public string DigitalEmployeeName { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. In winnexo-cli, pass it explicitly with --tenant-id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
