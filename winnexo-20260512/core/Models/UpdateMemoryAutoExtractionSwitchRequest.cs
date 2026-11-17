// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateMemoryAutoExtractionSwitchRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to synchronously clear the automatically collected memory. This parameter can be used when enabling or disabling the feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("clearExisting")]
        [Validation(Required=false)]
        public bool? ClearExisting { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic memory collection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The ID of the collaboration workspace. This parameter is required when ownerType is set to group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_12345</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The owner type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>user: the personal memory of the authenticated user</description></item>
        /// <item><description>group: the memory of the specified collaboration workspace</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>group</para>
        /// </summary>
        [NameInMap("ownerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
