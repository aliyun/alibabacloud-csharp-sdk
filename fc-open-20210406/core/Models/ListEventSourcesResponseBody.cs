// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListEventSourcesResponseBody : TeaModel {
        /// <summary>
        /// Queries all the event sources of a function.
        /// </summary>
        [NameInMap("eventSources")]
        [Validation(Required=false)]
        public List<ListEventSourcesResponseBodyEventSources> EventSources { get; set; }
        public class ListEventSourcesResponseBodyEventSources : TeaModel {
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// Jianyi
            /// </summary>
            [NameInMap("sourceArn")]
            [Validation(Required=false)]
            public string SourceArn { get; set; }

        }

    }

}
