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

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWarningConfigResponseBodyData Data { get; set; }
        public class ListWarningConfigResponseBodyData : TeaModel {
            [NameInMap("WarningConfigInfo")]
            [Validation(Required=false)]
            public List<ListWarningConfigResponseBodyDataWarningConfigInfo> WarningConfigInfo { get; set; }
            public class ListWarningConfigResponseBodyDataWarningConfigInfo : TeaModel {
                [NameInMap("Channels")]
                [Validation(Required=false)]
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

                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                [NameInMap("ConfigName")]
                [Validation(Required=false)]
                public string ConfigName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("RidList")]
                [Validation(Required=false)]
                public ListWarningConfigResponseBodyDataWarningConfigInfoRidList RidList { get; set; }
                public class ListWarningConfigResponseBodyDataWarningConfigInfoRidList : TeaModel {
                    [NameInMap("RidList")]
                    [Validation(Required=false)]
                    public List<string> RidList { get; set; }

                }

                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public ListWarningConfigResponseBodyDataWarningConfigInfoRuleList RuleList { get; set; }
                public class ListWarningConfigResponseBodyDataWarningConfigInfoRuleList : TeaModel {
                    [NameInMap("WarningRule")]
                    [Validation(Required=false)]
                    public List<ListWarningConfigResponseBodyDataWarningConfigInfoRuleListWarningRule> WarningRule { get; set; }
                    public class ListWarningConfigResponseBodyDataWarningConfigInfoRuleListWarningRule : TeaModel {
                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public long? Rid { get; set; }

                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                    }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
