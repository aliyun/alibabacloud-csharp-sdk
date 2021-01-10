// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCastersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("CasterList")]
        [Validation(Required=false)]
        public DescribeCastersResponseBodyCasterList CasterList { get; set; }
        public class DescribeCastersResponseBodyCasterList : TeaModel {
            [NameInMap("Caster")]
            [Validation(Required=false)]
            public List<DescribeCastersResponseBodyCasterListCaster> Caster { get; set; }
            public class DescribeCastersResponseBodyCasterListCaster : TeaModel {
                public int? Status { get; set; }
                public string StartTime { get; set; }
                public string PurchaseTime { get; set; }
                public string ExpireTime { get; set; }
                public string CreateTime { get; set; }
                public string CasterTemplate { get; set; }
                public string ChargeType { get; set; }
                public string CasterName { get; set; }
                public int? NormType { get; set; }
                public string CasterId { get; set; }
                public int? ChannelEnable { get; set; }
            }
        };

    }

}
