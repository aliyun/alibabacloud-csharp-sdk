// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GeneratePictureLinkResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GeneratePictureLinkResponseBodyData Data { get; set; }
        public class GeneratePictureLinkResponseBodyData : TeaModel {
            [NameInMap("links")]
            [Validation(Required=false)]
            public List<GeneratePictureLinkResponseBodyDataLinks> Links { get; set; }
            public class GeneratePictureLinkResponseBodyDataLinks : TeaModel {
                public string Key { get; set; }
                public string Link { get; set; }
            }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
