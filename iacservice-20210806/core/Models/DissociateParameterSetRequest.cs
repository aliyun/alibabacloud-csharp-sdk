// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class DissociateParameterSetRequest : TeaModel {
        /// <summary>
        /// <para>The list of parameter set IDs to be associated with the resource. Maximum length: 5.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("parameterSetIds")]
        [Validation(Required=false)]
        public List<string> ParameterSetIds { get; set; }

        /// <summary>
        /// <para>The resource ID. If the resource type is ModuleVersion, the value is a combination of <moduleId>-<moduleversion>, such as mod-34535345df123fr-v3.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mod-39cd1e5e58c50e79dd8cd901cd</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Module: template</description></item>
        /// <item><description>ModuleVersion: template version</description></item>
        /// <item><description>Task: node</description></item>
        /// <item><description>Stack: resource stack.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Module</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
