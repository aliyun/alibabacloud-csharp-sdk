// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class TranslateCertificateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TranslateCertificateResponseBodyData Data { get; set; }
        public class TranslateCertificateResponseBodyData : TeaModel {
            [NameInMap("TranslatedValues")]
            [Validation(Required=false)]
            public List<TranslateCertificateResponseBodyDataTranslatedValues> TranslatedValues { get; set; }
            public class TranslateCertificateResponseBodyDataTranslatedValues : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("KeyTranslation")]
                [Validation(Required=false)]
                public string KeyTranslation { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("ValueTranslation")]
                [Validation(Required=false)]
                public string ValueTranslation { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
