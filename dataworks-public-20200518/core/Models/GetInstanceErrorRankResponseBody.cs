// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceErrorRankResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceErrorRank")]
        [Validation(Required=false)]
        public GetInstanceErrorRankResponseBodyInstanceErrorRank InstanceErrorRank { get; set; }
        public class GetInstanceErrorRankResponseBodyInstanceErrorRank : TeaModel {
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("ErrorRank")]
            [Validation(Required=false)]
            public List<GetInstanceErrorRankResponseBodyInstanceErrorRankErrorRank> ErrorRank { get; set; }
            public class GetInstanceErrorRankResponseBodyInstanceErrorRankErrorRank : TeaModel {
                public string Owner { get; set; }
                public string NodeName { get; set; }
                public long? ProjectId { get; set; }
                public long? NodeId { get; set; }
                public int? Count { get; set; }
                public int? PrgType { get; set; }
            }
        };

    }

}
