// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CostCenterQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
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
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:a@alipay.com">a@alipay.com</a></para>
            /// </summary>
            [NameInMap("alipay_no")]
            [Validation(Required=false)]
            public string AlipayNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding12345678</para>
            /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>ding1234567</para>
                /// </summary>
                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("entity_id")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("entity_type")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default_bus</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("user_num")]
                [Validation(Required=false)]
                public int? UserNum { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7232</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            /// <summary>
            /// <para>rule code</para>
            /// 
            /// <b>Example:</b>
            /// <para>500578154</para>
            /// </summary>
            [NameInMap("rule_code")]
            [Validation(Required=false)]
            public long? RuleCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public long? Scope { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("thirdpart_id")]
            [Validation(Required=false)]
            public string ThirdpartId { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("more_page")]
        [Validation(Required=false)]
        public bool? MorePage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
