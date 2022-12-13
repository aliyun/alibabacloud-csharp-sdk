// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GeneratePictureLinkResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GeneratePictureLinkResponseBodyData Data { get; set; }
        public class GeneratePictureLinkResponseBodyData : TeaModel {
            /// <summary>
            /// array
            /// </summary>
            [NameInMap("links")]
            [Validation(Required=false)]
            public List<GeneratePictureLinkResponseBodyDataLinks> Links { get; set; }
            public class GeneratePictureLinkResponseBodyDataLinks : TeaModel {
                /// <summary>
                /// oss key
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// url
                /// </summary>
                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }

            }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
