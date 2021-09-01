// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetFileTypeStatisticResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ProgramTypeAndCounts")]
        [Validation(Required=true)]
        public List<GetFileTypeStatisticResponseProgramTypeAndCounts> ProgramTypeAndCounts { get; set; }
        public class GetFileTypeStatisticResponseProgramTypeAndCounts : TeaModel {
            [NameInMap("ProgramType")]
            [Validation(Required=true)]
            public string ProgramType { get; set; }

            [NameInMap("Count")]
            [Validation(Required=true)]
            public int? Count { get; set; }

        }

    }

}
