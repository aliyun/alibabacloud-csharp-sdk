// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListIndexRecoverRecordsResponseBody : TeaModel {
        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// The time when the index version was published.
        /// </summary>
        [NameInMap("finishedTime")]
        [Validation(Required=false)]
        public string FinishedTime { get; set; }

        /// <summary>
        /// The ID of the full index version.
        /// </summary>
        [NameInMap("generationId")]
        [Validation(Required=false)]
        public string GenerationId { get; set; }

    }

}
