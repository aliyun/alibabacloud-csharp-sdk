// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceConsumeTimeRankResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("InstanceConsumeTimeRank")]
        [Validation(Required=true)]
        public GetInstanceConsumeTimeRankResponseInstanceConsumeTimeRank InstanceConsumeTimeRank { get; set; }
        public class GetInstanceConsumeTimeRankResponseInstanceConsumeTimeRank : TeaModel {
            [NameInMap("UpdateTime")]
            [Validation(Required=true)]
            public long? UpdateTime { get; set; }
            [NameInMap("ConsumeTimeRank")]
            [Validation(Required=true)]
            public List<GetInstanceConsumeTimeRankResponseInstanceConsumeTimeRankConsumeTimeRank> ConsumeTimeRank { get; set; }
            public class GetInstanceConsumeTimeRankResponseInstanceConsumeTimeRankConsumeTimeRank : TeaModel {
                public string NodeName { get; set; }
                public long? NodeId { get; set; }
                public long? Bizdate { get; set; }
                public string Owner { get; set; }
                public long? Consumed { get; set; }
                public long? InstanceId { get; set; }
                public int? PrgType { get; set; }
            }
        };

    }

}
