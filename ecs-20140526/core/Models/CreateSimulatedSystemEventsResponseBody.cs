// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateSimulatedSystemEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the simulated events.</para>
        /// </summary>
        [NameInMap("EventIdSet")]
        [Validation(Required=false)]
        public CreateSimulatedSystemEventsResponseBodyEventIdSet EventIdSet { get; set; }
        public class CreateSimulatedSystemEventsResponseBodyEventIdSet : TeaModel {
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public List<string> EventId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
