// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TopTenErrorTimesInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceErrorRank")]
        [Validation(Required=false)]
        public TopTenErrorTimesInstanceResponseBodyInstanceErrorRank InstanceErrorRank { get; set; }
        public class TopTenErrorTimesInstanceResponseBodyInstanceErrorRank : TeaModel {
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("ErrorRank")]
            [Validation(Required=false)]
            public List<TopTenErrorTimesInstanceResponseBodyInstanceErrorRankErrorRank> ErrorRank { get; set; }
            public class TopTenErrorTimesInstanceResponseBodyInstanceErrorRankErrorRank : TeaModel {
                public string Owner { get; set; }
                public string NodeName { get; set; }
                public long? ProjectId { get; set; }
                public int? ProgramType { get; set; }
                public long? NodeId { get; set; }
                public int? Count { get; set; }
            }
        };

    }

}
