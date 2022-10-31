// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCastersResponseBody : TeaModel {
        [NameInMap("CasterList")]
        [Validation(Required=false)]
        public DescribeCastersResponseBodyCasterList CasterList { get; set; }
        public class DescribeCastersResponseBodyCasterList : TeaModel {
            [NameInMap("Caster")]
            [Validation(Required=false)]
            public List<DescribeCastersResponseBodyCasterListCaster> Caster { get; set; }
            public class DescribeCastersResponseBodyCasterListCaster : TeaModel {
                [NameInMap("CasterId")]
                [Validation(Required=false)]
                public string CasterId { get; set; }

                [NameInMap("CasterName")]
                [Validation(Required=false)]
                public string CasterName { get; set; }

                [NameInMap("CasterTemplate")]
                [Validation(Required=false)]
                public string CasterTemplate { get; set; }

                [NameInMap("ChannelEnable")]
                [Validation(Required=false)]
                public int? ChannelEnable { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("LastModified")]
                [Validation(Required=false)]
                public string LastModified { get; set; }

                [NameInMap("NormType")]
                [Validation(Required=false)]
                public int? NormType { get; set; }

                [NameInMap("PurchaseTime")]
                [Validation(Required=false)]
                public string PurchaseTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
