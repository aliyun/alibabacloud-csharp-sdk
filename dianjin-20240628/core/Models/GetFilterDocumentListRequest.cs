// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetFilterDocumentListRequest : TeaModel {
        [NameInMap("and")]
        [Validation(Required=false)]
        public List<GetFilterDocumentListRequestAnd> And { get; set; }
        public class GetFilterDocumentListRequestAnd : TeaModel {
            [NameInMap("boost")]
            [Validation(Required=false)]
            public float? Boost { get; set; }

            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("docIdList")]
        [Validation(Required=false)]
        public List<string> DocIdList { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        [NameInMap("or")]
        [Validation(Required=false)]
        public List<GetFilterDocumentListRequestOr> Or { get; set; }
        public class GetFilterDocumentListRequestOr : TeaModel {
            [NameInMap("boost")]
            [Validation(Required=false)]
            public float? Boost { get; set; }

            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

    }

}
