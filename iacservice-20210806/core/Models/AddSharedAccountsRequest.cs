// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class AddSharedAccountsRequest : TeaModel {
        /// <summary>
        /// <para>The list of Alibaba Cloud account IDs.</para>
        /// </summary>
        [NameInMap("accountIds")]
        [Validation(Required=false)]
        public List<long?> AccountIds { get; set; }

        /// <summary>
        /// <para>The ID of the shared resource.</para>
        /// <list type="bullet">
        /// <item><description><para>If the type is Namespace, set this parameter to the workspace name. </para>
        /// </description></item>
        /// <item><description><para>If the type is RegistryModule, set this parameter to \<namespaceName>/\<ModuleName>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>terraform-alicloud-modules/mongodb</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RegistryModule: Registry template.</description></item>
        /// <item><description>Namespace: workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RegistryModule</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
