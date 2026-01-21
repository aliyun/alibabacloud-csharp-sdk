// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bsn20150512.Models
{
    public class GetBsnByResourceResponseBody : TeaModel {
        [NameInMap("datas")]
        [Validation(Required=false)]
        public GetBsnByResourceResponseBodyDatas Datas { get; set; }
        public class GetBsnByResourceResponseBodyDatas : TeaModel {
            [NameInMap("bsnDO")]
            [Validation(Required=false)]
            public List<string> BsnDO { get; set; }

        }

    }

}
