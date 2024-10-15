// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TravelStandardQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public TravelStandardQueryResponseBodyModule Module { get; set; }
        public class TravelStandardQueryResponseBodyModule : TeaModel {
            [NameInMap("activated_service_type_list")]
            [Validation(Required=false)]
            public List<string> ActivatedServiceTypeList { get; set; }

            [NameInMap("reserve_rule")]
            [Validation(Required=false)]
            public TravelStandardQueryResponseBodyModuleReserveRule ReserveRule { get; set; }
            public class TravelStandardQueryResponseBodyModuleReserveRule : TeaModel {
                [NameInMap("main_reserve_rule")]
                [Validation(Required=false)]
                public TravelStandardQueryResponseBodyModuleReserveRuleMainReserveRule MainReserveRule { get; set; }
                public class TravelStandardQueryResponseBodyModuleReserveRuleMainReserveRule : TeaModel {
                    [NameInMap("open_service_type_list")]
                    [Validation(Required=false)]
                    public List<string> OpenServiceTypeList { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2006517149</para>
                    /// </summary>
                    [NameInMap("rule_code")]
                    [Validation(Required=false)]
                    public long? RuleCode { get; set; }

                    [NameInMap("rule_desc")]
                    [Validation(Required=false)]
                    public string RuleDesc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>6517149</para>
                    /// </summary>
                    [NameInMap("rule_id")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                    [NameInMap("rule_name")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                }

                [NameInMap("module_config_list")]
                [Validation(Required=false)]
                public List<TravelStandardQueryResponseBodyModuleReserveRuleModuleConfigList> ModuleConfigList { get; set; }
                public class TravelStandardQueryResponseBodyModuleReserveRuleModuleConfigList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>FLIGHT_ADVANCE_BUY_DAY</para>
                    /// </summary>
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
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
        /// <para>210bcc3a16583004579056128d33d7</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
