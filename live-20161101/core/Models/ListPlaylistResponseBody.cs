// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListPlaylistResponseBody : TeaModel {
        [NameInMap("ProgramList")]
        [Validation(Required=false)]
        public List<ListPlaylistResponseBodyProgramList> ProgramList { get; set; }
        public class ListPlaylistResponseBodyProgramList : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("RepeatNumber")]
            [Validation(Required=false)]
            public int? RepeatNumber { get; set; }

            [NameInMap("ProgramName")]
            [Validation(Required=false)]
            public string ProgramName { get; set; }

            [NameInMap("ProgramId")]
            [Validation(Required=false)]
            public string ProgramId { get; set; }

            [NameInMap("CasterId")]
            [Validation(Required=false)]
            public string CasterId { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
