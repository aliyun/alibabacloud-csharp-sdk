// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TopTenElapsedTimeInstanceResponseBody : TeaModel {
        [NameInMap("InstanceConsumeTimeRank")]
        [Validation(Required=false)]
        public TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRank InstanceConsumeTimeRank { get; set; }
        public class TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRank : TeaModel {
            [NameInMap("ConsumeTimeRank")]
            [Validation(Required=false)]
            public List<TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRankConsumeTimeRank> ConsumeTimeRank { get; set; }
            public class TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRankConsumeTimeRank : TeaModel {
                [NameInMap("BusinessDate")]
                [Validation(Required=false)]
                public long? BusinessDate { get; set; }

                [NameInMap("Consumed")]
                [Validation(Required=false)]
                public long? Consumed { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

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
