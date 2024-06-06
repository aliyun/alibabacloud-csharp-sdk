// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class TranslateGeneralVpcResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public TranslateGeneralVpcResponseBodyData Data { get; set; }
        public class TranslateGeneralVpcResponseBodyData : TeaModel {
            [NameInMap("DetectedLanguage")]
            [Validation(Required=false)]
            public string DetectedLanguage { get; set; }

            [NameInMap("Translated")]
            [Validation(Required=false)]
            public string Translated { get; set; }

            [NameInMap("WordCount")]
            [Validation(Required=false)]
            public string WordCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
