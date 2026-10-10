// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class TagResource : TeaModel {
        /// <summary>
        /// <para>The resource ID, which is the data catalog ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clg-paimon-0424965be0c240acb4159688c9e2c4b6</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type, which is fixed to CATALOGRESOURCE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CATALOGRESOURCE</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>team</para>
        /// </summary>
        [NameInMap("tagKey")]
        [Validation(Required=false)]
        public string TagKey { get; set; }

        /// <summary>
        /// <para>The tag value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>recommendation</para>
        /// </summary>
        [NameInMap("tagValue")]
        [Validation(Required=false)]
        public string TagValue { get; set; }

    }

}
