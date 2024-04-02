// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeBizTypeSettingResponseBody : TeaModel {
        [NameInMap("Ad")]
        [Validation(Required=false)]
        public DescribeBizTypeSettingResponseBodyAd Ad { get; set; }
        public class DescribeBizTypeSettingResponseBodyAd : TeaModel {
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

        }

        [NameInMap("Antispam")]
        [Validation(Required=false)]
        public DescribeBizTypeSettingResponseBodyAntispam Antispam { get; set; }
        public class DescribeBizTypeSettingResponseBodyAntispam : TeaModel {
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

        }

        [NameInMap("Live")]
        [Validation(Required=false)]
        public DescribeBizTypeSettingResponseBodyLive Live { get; set; }
        public class DescribeBizTypeSettingResponseBodyLive : TeaModel {
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

        }

        [NameInMap("Porn")]
        [Validation(Required=false)]
        public DescribeBizTypeSettingResponseBodyPorn Porn { get; set; }
        public class DescribeBizTypeSettingResponseBodyPorn : TeaModel {
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Terrorism")]
        [Validation(Required=false)]
        public DescribeBizTypeSettingResponseBodyTerrorism Terrorism { get; set; }
        public class DescribeBizTypeSettingResponseBodyTerrorism : TeaModel {
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

        }

    }

}
