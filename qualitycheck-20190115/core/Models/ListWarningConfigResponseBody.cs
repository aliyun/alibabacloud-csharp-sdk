// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListWarningConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWarningConfigResponseBodyData Data { get; set; }
        public class ListWarningConfigResponseBodyData : TeaModel {
            [NameInMap("WarningConfigInfo")]
            [Validation(Required=false)]
            public List<ListWarningConfigResponseBodyDataWarningConfigInfo> WarningConfigInfo { get; set; }
            public class ListWarningConfigResponseBodyDataWarningConfigInfo : TeaModel {
                public int? Status { get; set; }
                public string ConfigName { get; set; }
                public string UpdateTime { get; set; }
                public long? ConfigId { get; set; }
                public string CreateTime { get; set; }
                public ListWarningConfigResponseBodyDataWarningConfigInfoRuleList RuleList { get; set; }
                public class ListWarningConfigResponseBodyDataWarningConfigInfoRuleList : TeaModel {
                    [NameInMap("WarningRule")]
                    [Validation(Required=false)]
                    public List<ListWarningConfigResponseBodyDataWarningConfigInfoRuleListWarningRule> WarningRule { get; set; }
                    public class ListWarningConfigResponseBodyDataWarningConfigInfoRuleListWarningRule : TeaModel {
                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public long? Rid { get; set; }

                    }

                }
                public ListWarningConfigResponseBodyDataWarningConfigInfoChannels Channels { get; set; }
                public class ListWarningConfigResponseBodyDataWarningConfigInfoChannels : TeaModel {
                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public List<ListWarningConfigResponseBodyDataWarningConfigInfoChannelsChannel> Channel { get; set; }
                    public class ListWarningConfigResponseBodyDataWarningConfigInfoChannelsChannel : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                }
                public ListWarningConfigResponseBodyDataWarningConfigInfoRidList RidList { get; set; }
                public class ListWarningConfigResponseBodyDataWarningConfigInfoRidList : TeaModel {
                    [NameInMap("RidList")]
                    [Validation(Required=false)]
                    public List<string> RidList { get; set; }

                }
            }
        };

    }

}
