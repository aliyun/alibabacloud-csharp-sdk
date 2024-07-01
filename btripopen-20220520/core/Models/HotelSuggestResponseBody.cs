// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelSuggestResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelSuggestResponseBodyModule Module { get; set; }
        public class HotelSuggestResponseBodyModule : TeaModel {
            [NameInMap("guess_suggest_infos")]
            [Validation(Required=false)]
            public List<KeywordSuggestInfo> GuessSuggestInfos { get; set; }

            [NameInMap("keyword_suggest_infos")]
            [Validation(Required=false)]
            public List<KeywordSuggestInfo> KeywordSuggestInfos { get; set; }

            [NameInMap("popular_suggest_infos")]
            [Validation(Required=false)]
            public List<HotelSuggestResponseBodyModulePopularSuggestInfos> PopularSuggestInfos { get; set; }
            public class HotelSuggestResponseBodyModulePopularSuggestInfos : TeaModel {
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("popular_infos")]
                [Validation(Required=false)]
                public List<HotelSuggestResponseBodyModulePopularSuggestInfosPopularInfos> PopularInfos { get; set; }
                public class HotelSuggestResponseBodyModulePopularSuggestInfosPopularInfos : TeaModel {
                    [NameInMap("display_name")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("tips")]
            [Validation(Required=false)]
            public string Tips { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
