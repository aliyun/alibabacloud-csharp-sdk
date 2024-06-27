// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListDocumentsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListDocumentsResponseBodyItems Items { get; set; }
        public class ListDocumentsResponseBodyItems : TeaModel {
            [NameInMap("DocumentList")]
            [Validation(Required=false)]
            public List<ListDocumentsResponseBodyItemsDocumentList> DocumentList { get; set; }
            public class ListDocumentsResponseBodyItemsDocumentList : TeaModel {
                /// <summary>
                /// The name of the document.
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// The source of the document.
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **success**
        /// *   **fail**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
