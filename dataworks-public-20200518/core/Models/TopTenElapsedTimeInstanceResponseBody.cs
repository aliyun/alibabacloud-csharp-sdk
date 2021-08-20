// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TopTenElapsedTimeInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceConsumeTimeRank")]
        [Validation(Required=false)]
        public TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRank InstanceConsumeTimeRank { get; set; }
        public class TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRank : TeaModel {
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("ConsumeTimeRank")]
            [Validation(Required=false)]
            public List<TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRankConsumeTimeRank> ConsumeTimeRank { get; set; }
            public class TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRankConsumeTimeRank : TeaModel {
                public string Owner { get; set; }
                public string NodeName { get; set; }
                public long? BusinessDate { get; set; }
                public int? ProgramType { get; set; }
                public long? InstanceId { get; set; }
                public long? NodeId { get; set; }
                public long? Consumed { get; set; }
            }
        };

    }

}
