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
                public long? Bizdate { get; set; }
                public long? Consumed { get; set; }
                public long? InstanceId { get; set; }
                public long? NodeId { get; set; }
                public string NodeName { get; set; }
                public string Owner { get; set; }
                public int? PrgType { get; set; }
            }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
