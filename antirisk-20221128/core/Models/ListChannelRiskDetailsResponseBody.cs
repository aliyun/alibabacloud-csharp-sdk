// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antirisk20221128.Models
{
    public class ListChannelRiskDetailsResponseBody : TeaModel {
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListChannelRiskDetailsResponseBodyData Data { get; set; }
        public class ListChannelRiskDetailsResponseBodyData : TeaModel {
            [NameInMap("riskDetails")]
            [Validation(Required=false)]
            public List<ListChannelRiskDetailsResponseBodyDataRiskDetails> RiskDetails { get; set; }
            public class ListChannelRiskDetailsResponseBodyDataRiskDetails : TeaModel {
                [NameInMap("an")]
                [Validation(Required=false)]
                public string An { get; set; }

                [NameInMap("av")]
                [Validation(Required=false)]
                public string Av { get; set; }

                [NameInMap("bn")]
                [Validation(Required=false)]
                public string Bn { get; set; }

                [NameInMap("c")]
                [Validation(Required=false)]
                public string C { get; set; }

                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("fd")]
                [Validation(Required=false)]
                public string Fd { get; set; }

                [NameInMap("idfa")]
                [Validation(Required=false)]
                public string Idfa { get; set; }

                [NameInMap("jb")]
                [Validation(Required=false)]
                public string Jb { get; set; }

                [NameInMap("oaid")]
                [Validation(Required=false)]
                public string Oaid { get; set; }

                [NameInMap("py")]
                [Validation(Required=false)]
                public string Py { get; set; }

                [NameInMap("rl")]
                [Validation(Required=false)]
                public string Rl { get; set; }

                [NameInMap("rs")]
                [Validation(Required=false)]
                public string Rs { get; set; }

                [NameInMap("zid")]
                [Validation(Required=false)]
                public string Zid { get; set; }

            }

            [NameInMap("riskSumary")]
            [Validation(Required=false)]
            public List<ListChannelRiskDetailsResponseBodyDataRiskSumary> RiskSumary { get; set; }
            public class ListChannelRiskDetailsResponseBodyDataRiskSumary : TeaModel {
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("riskZidEmuDistinctNew")]
                [Validation(Required=false)]
                public string RiskZidEmuDistinctNew { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
