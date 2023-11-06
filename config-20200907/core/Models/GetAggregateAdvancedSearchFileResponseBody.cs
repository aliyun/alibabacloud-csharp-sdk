// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateAdvancedSearchFileResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the resource file.
        /// </summary>
        [NameInMap("ResourceSearch")]
        [Validation(Required=false)]
        public GetAggregateAdvancedSearchFileResponseBodyResourceSearch ResourceSearch { get; set; }
        public class GetAggregateAdvancedSearchFileResponseBodyResourceSearch : TeaModel {
            /// <summary>
            /// The download URL of the resource file.
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// The time when the resource file was generated. The value is a timestamp.
            /// 
            /// Unit: milliseconds.
            /// </summary>
            [NameInMap("ResourceInventoryGenerateTime")]
            [Validation(Required=false)]
            public long? ResourceInventoryGenerateTime { get; set; }

            /// <summary>
            /// The generation status of the resource file. Valid values:
            /// 
            /// *   CREATING: The resource file is being generated.
            /// *   COMPLETE: The resource file is generated.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
