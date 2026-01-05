// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class CreateSlotResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>end-5zk866779me51jgu3w,end-5zk866779me51jgu3w</para>
        /// </summary>
        [NameInMap("EndpointIds")]
        [Validation(Required=false)]
        public string EndpointIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A731A84D-55C9-44F7-99BB-E1CF0CF19197</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>slot-5zk866779me51jgu3w</para>
        /// </summary>
        [NameInMap("SlotId")]
        [Validation(Required=false)]
        public string SlotId { get; set; }

    }

}
