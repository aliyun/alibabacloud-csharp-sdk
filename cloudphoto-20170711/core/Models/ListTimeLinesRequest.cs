// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class ListTimeLinesRequest : TeaModel {
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("PhotoSize")]
        [Validation(Required=false)]
        public int? PhotoSize { get; set; }

        [NameInMap("Cursor")]
        [Validation(Required=false)]
        public long? Cursor { get; set; }

        [NameInMap("TimeLineCount")]
        [Validation(Required=false)]
        public int? TimeLineCount { get; set; }

        [NameInMap("TimeLineUnit")]
        [Validation(Required=false)]
        public string TimeLineUnit { get; set; }

        [NameInMap("FilterBy")]
        [Validation(Required=false)]
        public string FilterBy { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("StoreName")]
        [Validation(Required=false)]
        public string StoreName { get; set; }

        [NameInMap("LibraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

    }

}
