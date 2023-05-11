// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserTagMetaListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryUserTagMetaListResponseBodyResult> Result { get; set; }
        public class QueryUserTagMetaListResponseBodyResult : TeaModel {
            [NameInMap("TagDescription")]
            [Validation(Required=false)]
            public string TagDescription { get; set; }

            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        /// <summary>
        /// Queries the metadata list of member tags in an organization.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
