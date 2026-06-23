// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete all custom tags. This parameter takes effect only when <c>tag_keys</c> is empty. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Delete all tags.</description></item>
        /// <item><description><c>false</c>: Do not delete all tags.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The region ID of the resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of resource IDs. You can specify up to 50 resource IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("resource_ids")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>CLUSTER: cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLUSTER</para>
        /// </summary>
        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tag keys for the resource. You can specify up to 20 tag keys.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("tag_keys")]
        [Validation(Required=false)]
        public List<string> TagKeys { get; set; }

    }

}
