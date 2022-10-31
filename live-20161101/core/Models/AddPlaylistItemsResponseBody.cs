// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddPlaylistItemsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public AddPlaylistItemsResponseBodyItems Items { get; set; }
        public class AddPlaylistItemsResponseBodyItems : TeaModel {
            [NameInMap("FailedItems")]
            [Validation(Required=false)]
            public List<AddPlaylistItemsResponseBodyItemsFailedItems> FailedItems { get; set; }
            public class AddPlaylistItemsResponseBodyItemsFailedItems : TeaModel {
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

            }

            [NameInMap("SuccessItems")]
            [Validation(Required=false)]
            public List<AddPlaylistItemsResponseBodyItemsSuccessItems> SuccessItems { get; set; }
            public class AddPlaylistItemsResponseBodyItemsSuccessItems : TeaModel {
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
