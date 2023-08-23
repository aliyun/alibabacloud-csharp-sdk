// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ScgSearchRequest : TeaModel {
        [NameInMap("ScgFilter")]
        [Validation(Required=false)]
        public ScgSearchRequestScgFilter ScgFilter { get; set; }
        public class ScgSearchRequestScgFilter : TeaModel {
            [NameInMap("OffSetParam")]
            [Validation(Required=false)]
            public ScgSearchRequestScgFilterOffSetParam OffSetParam { get; set; }
            public class ScgSearchRequestScgFilterOffSetParam : TeaModel {
                [NameInMap("Limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

            }

            [NameInMap("PageParam")]
            [Validation(Required=false)]
            public ScgSearchRequestScgFilterPageParam PageParam { get; set; }
            public class ScgSearchRequestScgFilterPageParam : TeaModel {
                [NameInMap("PageNum")]
                [Validation(Required=false)]
                public int? PageNum { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }

            [NameInMap("SortParam")]
            [Validation(Required=false)]
            public ScgSearchRequestScgFilterSortParam SortParam { get; set; }
            public class ScgSearchRequestScgFilterSortParam : TeaModel {
                [NameInMap("SortKey")]
                [Validation(Required=false)]
                public string SortKey { get; set; }

                [NameInMap("SortOrder")]
                [Validation(Required=false)]
                public string SortOrder { get; set; }

                [NameInMap("SortText")]
                [Validation(Required=false)]
                public string SortText { get; set; }

            }

            [NameInMap("UseOffSet")]
            [Validation(Required=false)]
            public bool? UseOffSet { get; set; }

        }

        [NameInMap("TopicId")]
        [Validation(Required=false)]
        public string TopicId { get; set; }

    }

}
