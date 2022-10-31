// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListPlaylistItemsResponseBody : TeaModel {
        [NameInMap("ProgramItems")]
        [Validation(Required=false)]
        public List<ListPlaylistItemsResponseBodyProgramItems> ProgramItems { get; set; }
        public class ListPlaylistItemsResponseBodyProgramItems : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("ProgramId")]
            [Validation(Required=false)]
            public string ProgramId { get; set; }

            [NameInMap("ProgramItemId")]
            [Validation(Required=false)]
            public string ProgramItemId { get; set; }

            [NameInMap("ProgramItemName")]
            [Validation(Required=false)]
            public string ProgramItemName { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("ResourceValue")]
            [Validation(Required=false)]
            public string ResourceValue { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
