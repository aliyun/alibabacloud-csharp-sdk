// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to unbind all tags. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: unbinds only the tags that match the value of tags.</description></item>
        /// <item><description>true: unbinds all tags that are bound to the resource.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The resource IDs. Each time you call this operation, you can unbind tags only from a single resource. Therefore, you can enter only one resource ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali-test-project</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>logstore</description></item>
        /// <item><description>dashboard</description></item>
        /// <item><description>machinegroup</description></item>
        /// <item><description>logtailconfig</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>project</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag keys. If you set all to false, only the tags that match the value of this parameter are unbound.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}
