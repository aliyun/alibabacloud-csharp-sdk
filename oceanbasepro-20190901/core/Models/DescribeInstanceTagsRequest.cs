// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceTagsRequest : TeaModel {
        /// <summary>
        /// <para>The list of cluster IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ob3za5w73as8rk&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Key&quot;: &quot;xxx&quot;, &quot;Value&quot;, &quot;xxx&quot;},{}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
