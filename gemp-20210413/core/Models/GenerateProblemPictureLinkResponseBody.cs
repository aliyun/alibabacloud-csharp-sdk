// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GenerateProblemPictureLinkResponseBody : TeaModel {
        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GenerateProblemPictureLinkResponseBodyData Data { get; set; }
        public class GenerateProblemPictureLinkResponseBodyData : TeaModel {
            [NameInMap("links")]
            [Validation(Required=false)]
            public List<GenerateProblemPictureLinkResponseBodyDataLinks> Links { get; set; }
            public class GenerateProblemPictureLinkResponseBodyDataLinks : TeaModel {
                public string Key { get; set; }
                public string Link { get; set; }
            }
        };

    }

}
