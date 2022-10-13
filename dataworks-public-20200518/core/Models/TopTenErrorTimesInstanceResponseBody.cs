// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TopTenErrorTimesInstanceResponseBody : TeaModel {
        [NameInMap("InstanceErrorRank")]
        [Validation(Required=false)]
        public TopTenErrorTimesInstanceResponseBodyInstanceErrorRank InstanceErrorRank { get; set; }
        public class TopTenErrorTimesInstanceResponseBodyInstanceErrorRank : TeaModel {
            [NameInMap("ErrorRank")]
            [Validation(Required=false)]
            public List<TopTenErrorTimesInstanceResponseBodyInstanceErrorRankErrorRank> ErrorRank { get; set; }
            public class TopTenErrorTimesInstanceResponseBodyInstanceErrorRankErrorRank : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("ProgramType")]
                [Validation(Required=false)]
                public int? ProgramType { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
