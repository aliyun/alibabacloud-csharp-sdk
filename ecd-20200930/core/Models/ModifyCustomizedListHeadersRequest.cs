// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyCustomizedListHeadersRequest : TeaModel {
        /// <summary>
        /// The header of the response.
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public List<ModifyCustomizedListHeadersRequestHeaders> Headers { get; set; }
        public class ModifyCustomizedListHeadersRequestHeaders : TeaModel {
            /// <summary>
            /// The display type of the header. You can call the `ModifyCustomizedListHeaders` operation to modify the display type of the header.
            /// </summary>
            [NameInMap("DisplayType")]
            [Validation(Required=false)]
            public string DisplayType { get; set; }

            /// <summary>
            /// The key of the header.
            /// </summary>
            [NameInMap("HeaderKey")]
            [Validation(Required=false)]
            public string HeaderKey { get; set; }

        }

        /// <summary>
        /// The type of the list.
        /// </summary>
        [NameInMap("ListType")]
        [Validation(Required=false)]
        public string ListType { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
