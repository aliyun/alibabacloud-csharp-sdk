// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TravelStandardListQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public TravelStandardListQueryResponseBodyModule Module { get; set; }
        public class TravelStandardListQueryResponseBodyModule : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<TravelStandardListQueryResponseBodyModuleItems> Items { get; set; }
            public class TravelStandardListQueryResponseBodyModuleItems : TeaModel {
                [NameInMap("main_reserve_rule")]
                [Validation(Required=false)]
                public TravelStandardListQueryResponseBodyModuleItemsMainReserveRule MainReserveRule { get; set; }
                public class TravelStandardListQueryResponseBodyModuleItemsMainReserveRule : TeaModel {
                    [NameInMap("open_service_type_list")]
                    [Validation(Required=false)]
                    public List<string> OpenServiceTypeList { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2006516571</para>
                    /// </summary>
                    [NameInMap("rule_code")]
                    [Validation(Required=false)]
                    public long? RuleCode { get; set; }

                    [NameInMap("rule_desc")]
                    [Validation(Required=false)]
                    public string RuleDesc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>6516571</para>
                    /// </summary>
                    [NameInMap("rule_id")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                    [NameInMap("rule_name")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                }

                [NameInMap("reserve_rule_desc")]
                [Validation(Required=false)]
                public List<TravelStandardListQueryResponseBodyModuleItemsReserveRuleDesc> ReserveRuleDesc { get; set; }
                public class TravelStandardListQueryResponseBodyModuleItemsReserveRuleDesc : TeaModel {
                    [NameInMap("data_list")]
                    [Validation(Required=false)]
                    public List<TravelStandardListQueryResponseBodyModuleItemsReserveRuleDescDataList> DataList { get; set; }
                    public class TravelStandardListQueryResponseBodyModuleItemsReserveRuleDescDataList : TeaModel {
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>flight</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("scope")]
                [Validation(Required=false)]
                public int? Scope { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("total_size")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>05F9C201-1B53-5905-94AB-0D7444D8466A</para>
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
        /// <para>21041aa317070996148671005d0a0b</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
