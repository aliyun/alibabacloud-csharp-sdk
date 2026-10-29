// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class TagResourcesRequest : TeaModel {
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
        /// <para>The list of resource IDs. You can add up to 50 resource IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("resource_ids")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CLUSTER: cluster.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLUSTER</para>
        /// </summary>
        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag key-value pairs of the resource. You can add up to 20 tag key-value pairs. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If a value is specified, it cannot be an empty string and can be up to 128 characters in length.</description></item>
        /// <item><description>The value cannot start with <c>aliyun</c> or <c>acs:</c>.</description></item>
        /// <item><description>The value cannot contain <c>http://</c> or <c>https://</c>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
