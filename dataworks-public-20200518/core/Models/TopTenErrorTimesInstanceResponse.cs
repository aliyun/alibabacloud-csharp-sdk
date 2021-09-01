// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TopTenErrorTimesInstanceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("InstanceErrorRank")]
        [Validation(Required=true)]
        public TopTenErrorTimesInstanceResponseInstanceErrorRank InstanceErrorRank { get; set; }
        public class TopTenErrorTimesInstanceResponseInstanceErrorRank : TeaModel {
            [NameInMap("UpdateTime")]
            [Validation(Required=true)]
            public long? UpdateTime { get; set; }
            [NameInMap("ErrorRank")]
            [Validation(Required=true)]
            public List<TopTenErrorTimesInstanceResponseInstanceErrorRankErrorRank> ErrorRank { get; set; }
            public class TopTenErrorTimesInstanceResponseInstanceErrorRankErrorRank : TeaModel {
                public long? NodeId { get; set; }
                public string NodeName { get; set; }
                public string Owner { get; set; }
                public int? Count { get; set; }
                public long? ProjectId { get; set; }
                public int? ProgramType { get; set; }
            }
        };

    }

}
