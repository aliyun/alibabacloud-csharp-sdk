// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedTagsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("GroupedFileds")]
        [Validation(Required=false)]
        public List<DescribeGroupedTagsResponseBodyGroupedFileds> GroupedFileds { get; set; }
        public class DescribeGroupedTagsResponseBodyGroupedFileds : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TagId")]
            [Validation(Required=false)]
            public int? TagId { get; set; }

        }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// Queries the statistics of asset tags.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// DescribeGroupedTags
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
