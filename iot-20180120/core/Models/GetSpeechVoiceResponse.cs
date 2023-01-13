// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetSpeechVoiceResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetSpeechVoiceResponseData Data { get; set; }
        public class GetSpeechVoiceResponseData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=true)]
            public List<GetSpeechVoiceResponseDataItems> Items { get; set; }
            public class GetSpeechVoiceResponseDataItems : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=true)]
                public string Label { get; set; }

                [NameInMap("Value")]
                [Validation(Required=true)]
                public string Value { get; set; }

                [NameInMap("VoiceList")]
                [Validation(Required=true)]
                public GetSpeechVoiceResponseDataItemsVoiceList VoiceList { get; set; }
                public class GetSpeechVoiceResponseDataItemsVoiceList : TeaModel {
                    [NameInMap("Items")]
                    [Validation(Required=true)]
                    public List<GetSpeechVoiceResponseDataItemsVoiceListItems> Items { get; set; }
                    public class GetSpeechVoiceResponseDataItemsVoiceListItems : TeaModel {
                        [NameInMap("Label")]
                        [Validation(Required=true)]
                        public string Label { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=true)]
                        public string Value { get; set; }

                    }

                }

            }

        }

    }

}
