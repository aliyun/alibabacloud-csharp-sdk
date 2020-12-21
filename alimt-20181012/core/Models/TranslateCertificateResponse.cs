// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class TranslateCertificateResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public TranslateCertificateResponseData Data { get; set; }
        public class TranslateCertificateResponseData : TeaModel {
            [NameInMap("TranslatedValues")]
            [Validation(Required=true)]
            public List<TranslateCertificateResponseDataTranslatedValues> TranslatedValues { get; set; }
            public class TranslateCertificateResponseDataTranslatedValues : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
                public string ValueTranslation { get; set; }
                public string KeyTranslation { get; set; }
            }
        };

    }

}
