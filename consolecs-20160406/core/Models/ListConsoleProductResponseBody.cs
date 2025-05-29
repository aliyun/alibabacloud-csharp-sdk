// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Consolecs20160406.Models
{
    public class ListConsoleProductResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListConsoleProductResponseBodyData> Data { get; set; }
        public class ListConsoleProductResponseBodyData : TeaModel {
            [NameInMap("BelongedCategory")]
            [Validation(Required=false)]
            public string BelongedCategory { get; set; }

            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            [NameInMap("ChannelLinks")]
            [Validation(Required=false)]
            public List<string> ChannelLinks { get; set; }

            [NameInMap("DocId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            [NameInMap("Names")]
            [Validation(Required=false)]
            public string Names { get; set; }

            [NameInMap("Pinyin")]
            [Validation(Required=false)]
            public string Pinyin { get; set; }

            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            [NameInMap("RelatedConsoleAppId")]
            [Validation(Required=false)]
            public string RelatedConsoleAppId { get; set; }

            [NameInMap("RelatedPipId")]
            [Validation(Required=false)]
            public string RelatedPipId { get; set; }

            [NameInMap("ShowInNav")]
            [Validation(Required=false)]
            public bool? ShowInNav { get; set; }

            [NameInMap("SupportedAccounts")]
            [Validation(Required=false)]
            public List<string> SupportedAccounts { get; set; }

            [NameInMap("SupportedChannels")]
            [Validation(Required=false)]
            public List<string> SupportedChannels { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("TagExpireTime")]
            [Validation(Required=false)]
            public string TagExpireTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
