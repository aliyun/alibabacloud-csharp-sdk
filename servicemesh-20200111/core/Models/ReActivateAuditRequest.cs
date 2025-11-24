// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class ReActivateAuditRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to recreate a project that is used to store audit logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: recreates a project.</description></item>
        /// <item><description>false: does not recreate a project.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAudit")]
        [Validation(Required=false)]
        public bool? EnableAudit { get; set; }

        /// <summary>
        /// <para>The ID of the Service Mesh (ASM) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c5bf9eb05c4424b89985d6536a809****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
