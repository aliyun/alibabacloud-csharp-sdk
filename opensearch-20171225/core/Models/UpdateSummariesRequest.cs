// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class UpdateSummariesRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpdateSummariesRequestBody> Body { get; set; }
        public class UpdateSummariesRequestBody : TeaModel {
            [NameInMap("element")]
            [Validation(Required=false)]
            public string Element { get; set; }

            [NameInMap("ellipsis")]
            [Validation(Required=false)]
            public string Ellipsis { get; set; }

            [NameInMap("field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            [NameInMap("len")]
            [Validation(Required=false)]
            public int? Len { get; set; }

            [NameInMap("snippet")]
            [Validation(Required=false)]
            public int? Snippet { get; set; }

        }

        /// <summary>
        /// true
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
