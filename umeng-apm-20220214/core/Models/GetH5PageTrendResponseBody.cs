// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class GetH5PageTrendResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetH5PageTrendResponseBodyData> Data { get; set; }
        public class GetH5PageTrendResponseBodyData : TeaModel {
            [NameInMap("analyzeDOM")]
            [Validation(Required=false)]
            public double? AnalyzeDOM { get; set; }

            [NameInMap("appCache")]
            [Validation(Required=false)]
            public double? AppCache { get; set; }

            [NameInMap("contentTrans")]
            [Validation(Required=false)]
            public double? ContentTrans { get; set; }

            [NameInMap("dns")]
            [Validation(Required=false)]
            public double? Dns { get; set; }

            [NameInMap("domReady")]
            [Validation(Required=false)]
            public double? DomReady { get; set; }

            [NameInMap("fcp")]
            [Validation(Required=false)]
            public double? Fcp { get; set; }

            [NameInMap("firstByte")]
            [Validation(Required=false)]
            public double? FirstByte { get; set; }

            [NameInMap("fiveSecondRate")]
            [Validation(Required=false)]
            public double? FiveSecondRate { get; set; }

            [NameInMap("fp")]
            [Validation(Required=false)]
            public double? Fp { get; set; }

            [NameInMap("loadEvent")]
            [Validation(Required=false)]
            public double? LoadEvent { get; set; }

            [NameInMap("loadFinish")]
            [Validation(Required=false)]
            public double? LoadFinish { get; set; }

            [NameInMap("loadResource")]
            [Validation(Required=false)]
            public double? LoadResource { get; set; }

            [NameInMap("logCnt")]
            [Validation(Required=false)]
            public long? LogCnt { get; set; }

            [NameInMap("oneSecondRate")]
            [Validation(Required=false)]
            public double? OneSecondRate { get; set; }

            [NameInMap("redirect")]
            [Validation(Required=false)]
            public double? Redirect { get; set; }

            [NameInMap("ssl")]
            [Validation(Required=false)]
            public double? Ssl { get; set; }

            [NameInMap("tcp")]
            [Validation(Required=false)]
            public double? Tcp { get; set; }

            [NameInMap("timePoint")]
            [Validation(Required=false)]
            public string TimePoint { get; set; }

            [NameInMap("ttfb")]
            [Validation(Required=false)]
            public double? Ttfb { get; set; }

            [NameInMap("tti")]
            [Validation(Required=false)]
            public double? Tti { get; set; }

            [NameInMap("twoSecondRate")]
            [Validation(Required=false)]
            public double? TwoSecondRate { get; set; }

            [NameInMap("unload")]
            [Validation(Required=false)]
            public double? Unload { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
