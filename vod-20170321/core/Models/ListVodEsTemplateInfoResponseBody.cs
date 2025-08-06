// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListVodEsTemplateInfoResponseBody : TeaModel {
        [NameInMap("DataItems")]
        [Validation(Required=false)]
        public List<ListVodEsTemplateInfoResponseBodyDataItems> DataItems { get; set; }
        public class ListVodEsTemplateInfoResponseBodyDataItems : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("TmplDef")]
            [Validation(Required=false)]
            public string TmplDef { get; set; }

            [NameInMap("TmplDesc")]
            [Validation(Required=false)]
            public string TmplDesc { get; set; }

            [NameInMap("TmplName")]
            [Validation(Required=false)]
            public string TmplName { get; set; }

        }

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
