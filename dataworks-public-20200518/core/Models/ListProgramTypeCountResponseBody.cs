// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProgramTypeCountResponseBody : TeaModel {
        [NameInMap("ProgramTypeAndCounts")]
        [Validation(Required=false)]
        public List<ListProgramTypeCountResponseBodyProgramTypeAndCounts> ProgramTypeAndCounts { get; set; }
        public class ListProgramTypeCountResponseBodyProgramTypeAndCounts : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("ProgramType")]
            [Validation(Required=false)]
            public string ProgramType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
