// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TravelStandardQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TravelStandardQueryResponseBodyModule Module { get; set; }
        public class TravelStandardQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The service categories activated for the enterprise.</para>
            /// </summary>
            [NameInMap("activated_service_type_list")]
            [Validation(Required=false)]
            public List<string> ActivatedServiceTypeList { get; set; }

            /// <summary>
            /// <para>The travel standard information, which consists of the main travel standard information and module configuration information.</para>
            /// </summary>
            [NameInMap("reserve_rule")]
            [Validation(Required=false)]
            public TravelStandardQueryResponseBodyModuleReserveRule ReserveRule { get; set; }
            public class TravelStandardQueryResponseBodyModuleReserveRule : TeaModel {
                /// <summary>
                /// <para>The main travel standard information.</para>
                /// </summary>
                [NameInMap("main_reserve_rule")]
                [Validation(Required=false)]
                public TravelStandardQueryResponseBodyModuleReserveRuleMainReserveRule MainReserveRule { get; set; }
                public class TravelStandardQueryResponseBodyModuleReserveRuleMainReserveRule : TeaModel {
                    /// <summary>
                    /// <para>The enabled service categories.</para>
                    /// </summary>
                    [NameInMap("open_service_type_list")]
                    [Validation(Required=false)]
                    public List<string> OpenServiceTypeList { get; set; }

                    /// <summary>
                    /// <para>The travel standard code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2006517149</para>
                    /// </summary>
                    [NameInMap("rule_code")]
                    [Validation(Required=false)]
                    public long? RuleCode { get; set; }

                    /// <summary>
                    /// <para>The description of the travel standard.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>普通员工规则的描述</para>
                    /// </summary>
                    [NameInMap("rule_desc")]
                    [Validation(Required=false)]
                    public string RuleDesc { get; set; }

                    /// <summary>
                    /// <para>The ID of the main travel standard.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6517149</para>
                    /// </summary>
                    [NameInMap("rule_id")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                    /// <summary>
                    /// <para>The name of the travel standard.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>普通员工规则</para>
                    /// </summary>
                    [NameInMap("rule_name")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                }

                /// <summary>
                /// <para>The module configuration information.</para>
                /// </summary>
                [NameInMap("module_config_list")]
                [Validation(Required=false)]
                public List<TravelStandardQueryResponseBodyModuleReserveRuleModuleConfigList> ModuleConfigList { get; set; }
                public class TravelStandardQueryResponseBodyModuleReserveRuleModuleConfigList : TeaModel {
                    /// <summary>
                    /// <para>The code of the control item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FLIGHT_ADVANCE_BUY_DAY</para>
                    /// </summary>
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The value selected by the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
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
        /// <para>210bcc3a16583004579056128d33d7</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
