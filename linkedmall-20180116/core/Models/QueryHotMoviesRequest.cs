// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryHotMoviesRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("CityCode")]
        [Validation(Required=false)]
        public long? CityCode { get; set; }

        [NameInMap("ExtJson")]
        [Validation(Required=false)]
        public string ExtJson { get; set; }

    }

}
