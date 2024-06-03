// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaByHybridResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("MediaList")]
        [Validation(Required=false)]
        public List<SearchMediaByHybridResponseBodyMediaList> MediaList { get; set; }
        public class SearchMediaByHybridResponseBodyMediaList : TeaModel {
            [NameInMap("ClipInfo")]
            [Validation(Required=false)]
            public List<SearchMediaByHybridResponseBodyMediaListClipInfo> ClipInfo { get; set; }
            public class SearchMediaByHybridResponseBodyMediaListClipInfo : TeaModel {
                [NameInMap("From")]
                [Validation(Required=false)]
                public double? From { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("To")]
                [Validation(Required=false)]
                public double? To { get; set; }

            }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
