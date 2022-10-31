// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class EditPlaylistResponseBody : TeaModel {
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public EditPlaylistResponseBodyItems Items { get; set; }
        public class EditPlaylistResponseBodyItems : TeaModel {
            [NameInMap("FailedItems")]
            [Validation(Required=false)]
            public List<EditPlaylistResponseBodyItemsFailedItems> FailedItems { get; set; }
            public class EditPlaylistResponseBodyItemsFailedItems : TeaModel {
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

            }

            [NameInMap("SuccessItems")]
            [Validation(Required=false)]
            public List<EditPlaylistResponseBodyItemsSuccessItems> SuccessItems { get; set; }
            public class EditPlaylistResponseBodyItemsSuccessItems : TeaModel {
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

            }

        }

        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
