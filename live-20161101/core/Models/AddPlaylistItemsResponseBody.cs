// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddPlaylistItemsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public AddPlaylistItemsResponseBodyItems Items { get; set; }
        public class AddPlaylistItemsResponseBodyItems : TeaModel {
            [NameInMap("SuccessItems")]
            [Validation(Required=false)]
            public List<AddPlaylistItemsResponseBodyItemsSuccessItems> SuccessItems { get; set; }
            public class AddPlaylistItemsResponseBodyItemsSuccessItems : TeaModel {
                public string ItemName { get; set; }
                public string ItemId { get; set; }
            }
            [NameInMap("FailedItems")]
            [Validation(Required=false)]
            public List<AddPlaylistItemsResponseBodyItemsFailedItems> FailedItems { get; set; }
            public class AddPlaylistItemsResponseBodyItemsFailedItems : TeaModel {
                public string ItemName { get; set; }
                public string ItemId { get; set; }
            }
        };

        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

    }

}
