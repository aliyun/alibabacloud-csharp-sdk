// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CostCenterQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<CostCenterQueryResponseBodyModule> Module { get; set; }
        public class CostCenterQueryResponseBodyModule : TeaModel {
            [NameInMap("alipay_no")]
            [Validation(Required=false)]
            public string AlipayNo { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("disable")]
            [Validation(Required=false)]
            public long? Disable { get; set; }

            [NameInMap("entity_d_o_s")]
            [Validation(Required=false)]
            public List<CostCenterQueryResponseBodyModuleEntityDOS> EntityDOS { get; set; }
            public class CostCenterQueryResponseBodyModuleEntityDOS : TeaModel {
                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("entity_id")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                [NameInMap("entity_type")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("user_num")]
                [Validation(Required=false)]
                public int? UserNum { get; set; }

            }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            /// <summary>
            /// rule code
            /// </summary>
            [NameInMap("rule_code")]
            [Validation(Required=false)]
            public long? RuleCode { get; set; }

            [NameInMap("scope")]
            [Validation(Required=false)]
            public long? Scope { get; set; }

            [NameInMap("thirdpart_id")]
            [Validation(Required=false)]
            public string ThirdpartId { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("more_page")]
        [Validation(Required=false)]
        public bool? MorePage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
