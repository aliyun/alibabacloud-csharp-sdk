// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceConsumeTimeRankResponseBody : TeaModel {
        [NameInMap("InstanceConsumeTimeRank")]
        [Validation(Required=false)]
        public GetInstanceConsumeTimeRankResponseBodyInstanceConsumeTimeRank InstanceConsumeTimeRank { get; set; }
        public class GetInstanceConsumeTimeRankResponseBodyInstanceConsumeTimeRank : TeaModel {
            [NameInMap("ConsumeTimeRank")]
            [Validation(Required=false)]
            public List<GetInstanceConsumeTimeRankResponseBodyInstanceConsumeTimeRankConsumeTimeRank> ConsumeTimeRank { get; set; }
            public class GetInstanceConsumeTimeRankResponseBodyInstanceConsumeTimeRankConsumeTimeRank : TeaModel {
                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

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

                [NameInMap("PrgType")]
                [Validation(Required=false)]
                public int? PrgType { get; set; }

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
