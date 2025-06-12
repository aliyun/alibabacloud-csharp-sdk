// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The names of the resources. You can specify up to 50 resource names.</para>
        /// </summary>
        [NameInMap("ResourceNames")]
        [Validation(Required=false)]
        public List<string> ResourceNames { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>Enumerated values:</para>
        /// <list type="bullet">
        /// <item><description>role</description></item>
        /// <item><description>policy</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>role</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. The tag key can be up to 128 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. The tag value can be up to 256 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
