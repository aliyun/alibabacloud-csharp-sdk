// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateConsumerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The consumer group description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Used for grouping online API callers.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The consumer group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-consumer-group</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
