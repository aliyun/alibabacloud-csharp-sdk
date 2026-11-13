// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateConsumerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The description of the consumer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Used to group production API consumers</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the consumer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-consumer-group</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
