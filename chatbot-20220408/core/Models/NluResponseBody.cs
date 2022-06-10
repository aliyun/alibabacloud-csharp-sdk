// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class NluResponseBody : TeaModel {
        /// <summary>
        /// 本条语言理解应答消息的ID
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// 消息的列表
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<NluResponseBodyMessages> Messages { get; set; }
        public class NluResponseBodyMessages : TeaModel {
            /// <summary>
            /// 对话中控的nlu信息
            /// </summary>
            [NameInMap("DialogHubNluInfo")]
            [Validation(Required=false)]
            public NluResponseBodyMessagesDialogHubNluInfo DialogHubNluInfo { get; set; }
            public class NluResponseBodyMessagesDialogHubNluInfo : TeaModel {
                [NameInMap("GlobalDictList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDialogHubNluInfoGlobalDictList> GlobalDictList { get; set; }
                public class NluResponseBodyMessagesDialogHubNluInfoGlobalDictList : TeaModel {
                    public string StandardWord { get; set; }
                    public string Word { get; set; }
                }
                [NameInMap("GlobalSensitiveWordList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDialogHubNluInfoGlobalSensitiveWordList> GlobalSensitiveWordList { get; set; }
                public class NluResponseBodyMessagesDialogHubNluInfoGlobalSensitiveWordList : TeaModel {
                    public string StandardWord { get; set; }
                    public string Word { get; set; }
                }
            };

            /// <summary>
            /// 对话工厂的nlu信息
            /// </summary>
            [NameInMap("DsNluInfo")]
            [Validation(Required=false)]
            public NluResponseBodyMessagesDsNluInfo DsNluInfo { get; set; }
            public class NluResponseBodyMessagesDsNluInfo : TeaModel {
                [NameInMap("EntityList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDsNluInfoEntityList> EntityList { get; set; }
                public class NluResponseBodyMessagesDsNluInfoEntityList : TeaModel {
                    public string Name { get; set; }
                    public string Origin { get; set; }
                    public string Type { get; set; }
                    public string Value { get; set; }
                }
                [NameInMap("IntentList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDsNluInfoIntentList> IntentList { get; set; }
                public class NluResponseBodyMessagesDsNluInfoIntentList : TeaModel {
                    public long? IntentId { get; set; }
                    public string MatchDetail { get; set; }
                    public string MatchType { get; set; }
                    public string Name { get; set; }
                    public double? Score { get; set; }
                    public List<NluResponseBodyMessagesDsNluInfoIntentListSlotList> SlotList { get; set; }
                    public class NluResponseBodyMessagesDsNluInfoIntentListSlotList : TeaModel {
                        public string Name { get; set; }
                        public string Origin { get; set; }
                        public string Type { get; set; }
                        public string Value { get; set; }
                    }
                }
            };

        }

        /// <summary>
        /// 请求id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
