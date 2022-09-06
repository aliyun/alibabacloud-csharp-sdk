// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetSpeechVoiceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSpeechVoiceResponseBodyData Data { get; set; }
        public class GetSpeechVoiceResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<GetSpeechVoiceResponseBodyDataItems> Items { get; set; }
            public class GetSpeechVoiceResponseBodyDataItems : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("VoiceList")]
                [Validation(Required=false)]
                public GetSpeechVoiceResponseBodyDataItemsVoiceList VoiceList { get; set; }
                public class GetSpeechVoiceResponseBodyDataItemsVoiceList : TeaModel {
                    [NameInMap("Items")]
                    [Validation(Required=false)]
                    public List<GetSpeechVoiceResponseBodyDataItemsVoiceListItems> Items { get; set; }
                    public class GetSpeechVoiceResponseBodyDataItemsVoiceListItems : TeaModel {
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
