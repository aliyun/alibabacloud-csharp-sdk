// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class TaggingAdImageResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public TaggingAdImageResponseBodyData Data { get; set; }
        public class TaggingAdImageResponseBodyData : TeaModel {
            [NameInMap("TagInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> TagInfo { get; set; }
        };

    }

}
