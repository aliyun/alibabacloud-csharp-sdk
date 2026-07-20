// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TravelStandardListQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

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
        /// <para>The response data. Returned by the server. An empty value is returned if no results are found or an exception occurs.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TravelStandardListQueryResponseBodyModule Module { get; set; }
        public class TravelStandardListQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of travel standards.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<TravelStandardListQueryResponseBodyModuleItems> Items { get; set; }
            public class TravelStandardListQueryResponseBodyModuleItems : TeaModel {
                /// <summary>
                /// <para>The primary travel standard information.</para>
                /// </summary>
                [NameInMap("main_reserve_rule")]
                [Validation(Required=false)]
                public TravelStandardListQueryResponseBodyModuleItemsMainReserveRule MainReserveRule { get; set; }
                public class TravelStandardListQueryResponseBodyModuleItemsMainReserveRule : TeaModel {
                    /// <summary>
                    /// <para>The list of enabled service categories.</para>
                    /// </summary>
                    [NameInMap("open_service_type_list")]
                    [Validation(Required=false)]
                    public List<string> OpenServiceTypeList { get; set; }

                    /// <summary>
                    /// <para>The personnel rule code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2006516571</para>
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
                    /// <para>The ID of the primary travel standard.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6516571</para>
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
                /// <para>The description of the travel standard.</para>
                /// </summary>
                [NameInMap("reserve_rule_desc")]
                [Validation(Required=false)]
                public List<TravelStandardListQueryResponseBodyModuleItemsReserveRuleDesc> ReserveRuleDesc { get; set; }
                public class TravelStandardListQueryResponseBodyModuleItemsReserveRuleDesc : TeaModel {
                    /// <summary>
                    /// <para>The description of the travel standard.</para>
                    /// </summary>
                    [NameInMap("data_list")]
                    [Validation(Required=false)]
                    public List<TravelStandardListQueryResponseBodyModuleItemsReserveRuleDescDataList> DataList { get; set; }
                    public class TravelStandardListQueryResponseBodyModuleItemsReserveRuleDescDataList : TeaModel {
                        /// <summary>
                        /// <para>The travel standard description item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>舱等</para>
                        /// </summary>
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the travel standard description item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>经济舱,超级经济舱,公务舱,头等舱</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The title of the travel standard detail.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>普通员工规则</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <para>The category of the travel standard detail.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>flight</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The applicable personnel scope of the travel standard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("scope")]
                [Validation(Required=false)]
                public int? Scope { get; set; }

            }

            /// <summary>
            /// <para>The total number of travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("total_size")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05F9C201-1B53-5905-94AB-0D7444D8466A</para>
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
        /// <para>21041aa317070996148671005d0a0b</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
