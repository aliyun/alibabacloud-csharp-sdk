// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListProjectResponseBody : TeaModel {
        /// <summary>
        /// The number of returned projects on the current page.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// The projects that meet the query conditions.
        /// </summary>
        [NameInMap("projects")]
        [Validation(Required=false)]
        public List<Project> Projects { get; set; }

        /// <summary>
        /// The total number of projects that meet the query conditions.
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
