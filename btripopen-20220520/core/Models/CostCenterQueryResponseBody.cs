// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CostCenterQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Remarks. Additional notes about the result, such as a description of the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The cost center query results. Returns an empty array [] when no results are found. Returns null when an exception occurs.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<CostCenterQueryResponseBodyModule> Module { get; set; }
        public class CostCenterQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The bound Alipay account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:a@alipay.com">a@alipay.com</a></para>
            /// </summary>
            [NameInMap("alipay_no")]
            [Validation(Required=false)]
            public string AlipayNo { get; set; }

            /// <summary>
            /// <para>The business travel enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ding12345678</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>Indicates whether the cost center is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Not disabled.</description></item>
            /// <item><description><b>1</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("disable")]
            [Validation(Required=false)]
            public long? Disable { get; set; }

            /// <summary>
            /// <para>The cost center result objects.</para>
            /// </summary>
            [NameInMap("entity_d_o_s")]
            [Validation(Required=false)]
            public List<CostCenterQueryResponseBodyModuleEntityDOS> EntityDOS { get; set; }
            public class CostCenterQueryResponseBodyModuleEntityDOS : TeaModel {
                /// <summary>
                /// <para>The business travel enterprise ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ding1234567</para>
                /// </summary>
                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>The user, department, or role ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("entity_id")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The member type. Valid values: 1: user. 2: department. 3: role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("entity_type")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <para>The user, department, or role name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default_bus</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of employees under the role or department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("user_num")]
                [Validation(Required=false)]
                public int? UserNum { get; set; }

            }

            /// <summary>
            /// <para>The business travel cost center ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7232</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The cost center number.</para>
            /// 
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
            /// <para>The applicable scope. Valid values: 1: all members. 2: partial members.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public long? Scope { get; set; }

            /// <summary>
            /// <para>The third-party cost center ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("thirdpart_id")]
            [Validation(Required=false)]
            public string ThirdpartId { get; set; }

            /// <summary>
            /// <para>The cost center name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>运营商</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The pagination flag. Set by the server. Indicates whether more data is available on the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("more_page")]
        [Validation(Required=false)]
        public bool? MorePage { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The success flag. Set by the server. Set to false when an exception occurs or the result is null.</para>
        /// 
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
