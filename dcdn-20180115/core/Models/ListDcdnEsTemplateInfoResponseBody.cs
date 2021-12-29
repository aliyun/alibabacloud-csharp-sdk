// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ListDcdnEsTemplateInfoResponseBody : TeaModel {
        [NameInMap("DataItems")]
        [Validation(Required=false)]
        public ListDcdnEsTemplateInfoResponseBodyDataItems DataItems { get; set; }
        public class ListDcdnEsTemplateInfoResponseBodyDataItems : TeaModel {
            [NameInMap("DataItem")]
            [Validation(Required=false)]
            public List<ListDcdnEsTemplateInfoResponseBodyDataItemsDataItem> DataItem { get; set; }
            public class ListDcdnEsTemplateInfoResponseBodyDataItemsDataItem : TeaModel {
                public int? Id { get; set; }
                public string TmplDef { get; set; }
                public string TmplDesc { get; set; }
                public string TmplName { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
