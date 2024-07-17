// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListTasksRequest : TeaModel {
        /// <summary>
        /// The timestamp that indicates the end of the time range to query.
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// The timestamp that indicates the beginning of the time range to query.
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

    }

}
