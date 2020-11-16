// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCastersResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("CasterList")]
        [Validation(Required=true)]
        public DescribeCastersResponseCasterList CasterList { get; set; }
        public class DescribeCastersResponseCasterList : TeaModel {
            [NameInMap("Caster")]
            [Validation(Required=true)]
            public List<DescribeCastersResponseCasterListCaster> Caster { get; set; }
            public class DescribeCastersResponseCasterListCaster : TeaModel {
                public int? Status { get; set; }
                public int? NormType { get; set; }
                public string CasterId { get; set; }
                public string CasterName { get; set; }
                public string CreateTime { get; set; }
                public string StartTime { get; set; }
                public string PurchaseTime { get; set; }
                public string ExpireTime { get; set; }
                public string ChargeType { get; set; }
                public string CasterTemplate { get; set; }
                public int? ChannelEnable { get; set; }
            }
        };

    }

}
