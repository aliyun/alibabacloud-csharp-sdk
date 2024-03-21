// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class SearchItemsResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public SearchItemsResponseBodyModule Module { get; set; }
        public class SearchItemsResponseBodyModule : TeaModel {
            [NameInMap("CurrentPageNum")]
            [Validation(Required=false)]
            public int? CurrentPageNum { get; set; }

            [NameInMap("Date")]
            [Validation(Required=false)]
            public SearchItemsResponseBodyModuleDate Date { get; set; }
            public class SearchItemsResponseBodyModuleDate : TeaModel {
                [NameInMap("item")]
                [Validation(Required=false)]
                public List<SearchItemsResponseBodyModuleDateItem> Item { get; set; }
                public class SearchItemsResponseBodyModuleDateItem : TeaModel {
                    [NameInMap("DetailViewObjectSourceDatum")]
                    [Validation(Required=false)]
                    public string DetailViewObjectSourceDatum { get; set; }

                    [NameInMap("DetailViewObjectSourceType")]
                    [Validation(Required=false)]
                    public string DetailViewObjectSourceType { get; set; }

                }

            }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalItemNum")]
            [Validation(Required=false)]
            public int? TotalItemNum { get; set; }

            [NameInMap("TotalPageNum")]
            [Validation(Required=false)]
            public int? TotalPageNum { get; set; }

        }

    }

}
