// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListFlowControlTaskInvalidItemsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8F81A922-6C81-46D6-B78C-CC35E16B1691</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListFlowControlTaskInvalidItemsResponseBodyResult> Result { get; set; }
        public class ListFlowControlTaskInvalidItemsResponseBodyResult : TeaModel {
            [NameInMap("invalidItems")]
            [Validation(Required=false)]
            public List<ListFlowControlTaskInvalidItemsResponseBodyResultInvalidItems> InvalidItems { get; set; }
            public class ListFlowControlTaskInvalidItemsResponseBodyResultInvalidItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>287723</para>
                /// </summary>
                [NameInMap("itemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("itemType")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

            }

        }

    }

}
