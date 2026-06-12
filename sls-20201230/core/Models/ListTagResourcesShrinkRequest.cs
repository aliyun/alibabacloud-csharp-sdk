// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListTagResourcesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the resources whose tags you want to query. You must specify at least one of resourceId and tags.</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceIdShrink { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>project</para>
        /// </description></item>
        /// <item><description><para>logstore</para>
        /// </description></item>
        /// <item><description><para>dashboard</para>
        /// </description></item>
        /// <item><description><para>machinegroup</para>
        /// </description></item>
        /// <item><description><para>logtailconfig</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags that you want to use to filter resources based on exact match. Each tag is a key-value pair. You must specify at least one of resourceId and tags.</para>
        /// <para>You can enter up to 20 tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
