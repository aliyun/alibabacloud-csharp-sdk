// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListWarningConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>oapi.dingtalk.com/robot/send?access_token=c55628f700eb9ad2a3ca</para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public long? ConfigId { get; set; }

                [NameInMap("ConfigName")]
                [Validation(Required=false)]
                public string ConfigName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-10-29T15:30Z</para>
                /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>33452</para>
                        /// </summary>
                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public long? Rid { get; set; }

                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-10-29T17:24Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>82C91484-B2D5-4D2A-A21F-A6D73F4D55C6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
