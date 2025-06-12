// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class TagResourcesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The names of the resources. You can specify up to 50 resource names.</para>
        /// </summary>
        [NameInMap("ResourceNames")]
        [Validation(Required=false)]
        public string ResourceNamesShrink { get; set; }

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
        public string TagShrink { get; set; }

    }

}
