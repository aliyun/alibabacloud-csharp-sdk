// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The resource ID. You can specify up to 20 resource IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Set the value to <b>ANYCASTEIPADDRESS</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ANYCASTEIPADDRESS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The key of the tag that you want to remove. You can specify at most 20 tag keys. The tag key cannot be an empty string.</para>
        /// <para>A tag key can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain <c>http://</c> or <c>https://</c>.</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
