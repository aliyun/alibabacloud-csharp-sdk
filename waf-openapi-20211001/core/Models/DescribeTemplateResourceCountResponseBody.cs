// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeTemplateResourceCountResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of protected objects or protected object groups for which the protection template takes effect.
        /// </summary>
        [NameInMap("ResourceCount")]
        [Validation(Required=false)]
        public List<DescribeTemplateResourceCountResponseBodyResourceCount> ResourceCount { get; set; }
        public class DescribeTemplateResourceCountResponseBodyResourceCount : TeaModel {
            /// <summary>
            /// The number of protected object groups.
            /// </summary>
            [NameInMap("GroupCount")]
            [Validation(Required=false)]
            public int? GroupCount { get; set; }

            /// <summary>
            /// The number of protected objects.
            /// </summary>
            [NameInMap("SingleCount")]
            [Validation(Required=false)]
            public int? SingleCount { get; set; }

            /// <summary>
            /// The ID of the protection template.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

    }

}
