// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TravelStandardListQueryResponseBody : TeaModel {
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

                    [NameInMap("rule_code")]
                    [Validation(Required=false)]
                    public long? RuleCode { get; set; }

                    [NameInMap("rule_desc")]
                    [Validation(Required=false)]
                    public string RuleDesc { get; set; }

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

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("scope")]
                [Validation(Required=false)]
                public int? Scope { get; set; }

            }

            [NameInMap("total_size")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

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
