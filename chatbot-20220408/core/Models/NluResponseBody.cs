// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class NluResponseBody : TeaModel {
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<NluResponseBodyMessages> Messages { get; set; }
        public class NluResponseBodyMessages : TeaModel {
            [NameInMap("DialogHubNluInfo")]
            [Validation(Required=false)]
            public NluResponseBodyMessagesDialogHubNluInfo DialogHubNluInfo { get; set; }
            public class NluResponseBodyMessagesDialogHubNluInfo : TeaModel {
                [NameInMap("GlobalDictList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDialogHubNluInfoGlobalDictList> GlobalDictList { get; set; }
                public class NluResponseBodyMessagesDialogHubNluInfoGlobalDictList : TeaModel {
                    [NameInMap("StandardWord")]
                    [Validation(Required=false)]
                    public string StandardWord { get; set; }

                    [NameInMap("Word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                }

                [NameInMap("GlobalSensitiveWordList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDialogHubNluInfoGlobalSensitiveWordList> GlobalSensitiveWordList { get; set; }
                public class NluResponseBodyMessagesDialogHubNluInfoGlobalSensitiveWordList : TeaModel {
                    [NameInMap("StandardWord")]
                    [Validation(Required=false)]
                    public string StandardWord { get; set; }

                    [NameInMap("Word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                }

            }

            [NameInMap("DsNluInfo")]
            [Validation(Required=false)]
            public NluResponseBodyMessagesDsNluInfo DsNluInfo { get; set; }
            public class NluResponseBodyMessagesDsNluInfo : TeaModel {
                [NameInMap("EntityList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDsNluInfoEntityList> EntityList { get; set; }
                public class NluResponseBodyMessagesDsNluInfoEntityList : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Origin")]
                    [Validation(Required=false)]
                    public string Origin { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("IntentList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDsNluInfoIntentList> IntentList { get; set; }
                public class NluResponseBodyMessagesDsNluInfoIntentList : TeaModel {
                    [NameInMap("IntentId")]
                    [Validation(Required=false)]
                    public long? IntentId { get; set; }

                    [NameInMap("MatchDetail")]
                    [Validation(Required=false)]
                    public string MatchDetail { get; set; }

                    [NameInMap("MatchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public double? Score { get; set; }

                    [NameInMap("SlotList")]
                    [Validation(Required=false)]
                    public List<NluResponseBodyMessagesDsNluInfoIntentListSlotList> SlotList { get; set; }
                    public class NluResponseBodyMessagesDsNluInfoIntentListSlotList : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Origin")]
                        [Validation(Required=false)]
                        public string Origin { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
