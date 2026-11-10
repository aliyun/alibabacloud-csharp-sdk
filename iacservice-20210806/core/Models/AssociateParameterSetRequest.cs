// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class AssociateParameterSetRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the parameter sets to be associated with the resource. Maximum length: 5.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("parameterSetIds")]
        [Validation(Required=false)]
        public List<string> ParameterSetIds { get; set; }

        /// <summary>
        /// <para>The resource ID. If the resource type is ModuleVersion, the ID is concatenated in the <moduleId>-<moduleversion> format, such as mod-34535345df123fr-v3.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-433aead756057ffdf5326bf1e12ed</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Module: template</description></item>
        /// <item><description>ModuleVersion: template version</description></item>
        /// <item><description>Task: task</description></item>
        /// <item><description>Stack: resource stack</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
