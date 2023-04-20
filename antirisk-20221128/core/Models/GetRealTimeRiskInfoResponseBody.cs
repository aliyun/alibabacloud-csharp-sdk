// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antirisk20221128.Models
{
    public class GetRealTimeRiskInfoResponseBody : TeaModel {
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRealTimeRiskInfoResponseBodyData Data { get; set; }
        public class GetRealTimeRiskInfoResponseBodyData : TeaModel {
            [NameInMap("appChannel")]
            [Validation(Required=false)]
            public string AppChannel { get; set; }

            [NameInMap("fakeDevice")]
            [Validation(Required=false)]
            public string FakeDevice { get; set; }

            [NameInMap("idfa")]
            [Validation(Required=false)]
            public string Idfa { get; set; }

            [NameInMap("oaid")]
            [Validation(Required=false)]
            public string Oaid { get; set; }

            [NameInMap("proxyDevice")]
            [Validation(Required=false)]
            public string ProxyDevice { get; set; }

            [NameInMap("riskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            [NameInMap("riskScore")]
            [Validation(Required=false)]
            public string RiskScore { get; set; }

            [NameInMap("zid")]
            [Validation(Required=false)]
            public string Zid { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
