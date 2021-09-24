// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TopTenElapsedTimeInstanceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("InstanceConsumeTimeRank")]
        [Validation(Required=true)]
        public TopTenElapsedTimeInstanceResponseInstanceConsumeTimeRank InstanceConsumeTimeRank { get; set; }
        public class TopTenElapsedTimeInstanceResponseInstanceConsumeTimeRank : TeaModel {
            [NameInMap("UpdateTime")]
            [Validation(Required=true)]
            public long? UpdateTime { get; set; }
            [NameInMap("ConsumeTimeRank")]
            [Validation(Required=true)]
            public List<TopTenElapsedTimeInstanceResponseInstanceConsumeTimeRankConsumeTimeRank> ConsumeTimeRank { get; set; }
            public class TopTenElapsedTimeInstanceResponseInstanceConsumeTimeRankConsumeTimeRank : TeaModel {
                public string NodeName { get; set; }
                public long? NodeId { get; set; }
                public long? BusinessDate { get; set; }
                public string Owner { get; set; }
                public long? Consumed { get; set; }
                public long? InstanceId { get; set; }
                public int? ProgramType { get; set; }
            }
        };

    }

}
