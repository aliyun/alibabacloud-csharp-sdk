// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class RemoveSharedAccountsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of Alibaba Cloud account IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("accountIds")]
        [Validation(Required=false)]
        public string AccountIdsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the resource to be unshared.</para>
        /// <list type="bullet">
        /// <item><description><para>If the type is Namespace, the value is the workspace name. </para>
        /// </description></item>
        /// <item><description><para>If the type is RegistryModule, the value is \<namespaceName>/\<ModuleName>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <item><description>Namespace: Workspace.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RegistryModule</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
