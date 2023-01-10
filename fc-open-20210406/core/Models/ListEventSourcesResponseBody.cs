// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListEventSourcesResponseBody : TeaModel {
        /// <summary>
        /// The information about event sources.
        /// </summary>
        [NameInMap("eventSources")]
        [Validation(Required=false)]
        public List<ListEventSourcesResponseBodyEventSources> EventSources { get; set; }
        public class ListEventSourcesResponseBodyEventSources : TeaModel {
            /// <summary>
            /// The time when the event source was created.
            /// </summary>
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// The ARN of the event source.
            /// </summary>
            [NameInMap("sourceArn")]
            [Validation(Required=false)]
            public string SourceArn { get; set; }

        }

    }

}
