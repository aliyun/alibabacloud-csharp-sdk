// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetFileTypeStatisticResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ProgramTypeAndCounts")]
        [Validation(Required=false)]
        public List<GetFileTypeStatisticResponseBodyProgramTypeAndCounts> ProgramTypeAndCounts { get; set; }
        public class GetFileTypeStatisticResponseBodyProgramTypeAndCounts : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("ProgramType")]
            [Validation(Required=false)]
            public string ProgramType { get; set; }

        }

    }

}
