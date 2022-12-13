// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GenerateProblemPictureLinkResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GenerateProblemPictureLinkResponseBodyData Data { get; set; }
        public class GenerateProblemPictureLinkResponseBodyData : TeaModel {
            [NameInMap("links")]
            [Validation(Required=false)]
            public List<GenerateProblemPictureLinkResponseBodyDataLinks> Links { get; set; }
            public class GenerateProblemPictureLinkResponseBodyDataLinks : TeaModel {
                /// <summary>
                /// oss key
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }

            }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
