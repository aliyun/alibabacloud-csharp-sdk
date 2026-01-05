// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class QueryStatisticResponseBody : TeaModel {
        [NameInMap("InstanceCapacityEachType")]
        [Validation(Required=false)]
        public Dictionary<string, object> InstanceCapacityEachType { get; set; }

        [NameInMap("InstanceNumEachType")]
        [Validation(Required=false)]
        public Dictionary<string, object> InstanceNumEachType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A731A84D-55C9-44F7-99BB-E1CF0CF19197</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SlotNumEachType")]
        [Validation(Required=false)]
        public Dictionary<string, object> SlotNumEachType { get; set; }

    }

}
