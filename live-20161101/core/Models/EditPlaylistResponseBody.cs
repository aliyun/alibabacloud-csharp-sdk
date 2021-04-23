// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class EditPlaylistResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public EditPlaylistResponseBodyItems Items { get; set; }
        public class EditPlaylistResponseBodyItems : TeaModel {
            [NameInMap("SuccessItems")]
            [Validation(Required=false)]
            public List<EditPlaylistResponseBodyItemsSuccessItems> SuccessItems { get; set; }
            public class EditPlaylistResponseBodyItemsSuccessItems : TeaModel {
                public string ItemName { get; set; }
                public string ItemId { get; set; }
            }
            [NameInMap("FailedItems")]
            [Validation(Required=false)]
            public List<EditPlaylistResponseBodyItemsFailedItems> FailedItems { get; set; }
            public class EditPlaylistResponseBodyItemsFailedItems : TeaModel {
                public string ItemName { get; set; }
                public string ItemId { get; set; }
            }
        };

        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

    }

}
