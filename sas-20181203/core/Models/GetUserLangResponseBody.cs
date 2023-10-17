// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetUserLangResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The language settings.
        /// </summary>
        [NameInMap("SasUserLang")]
        [Validation(Required=false)]
        public GetUserLangResponseBodySasUserLang SasUserLang { get; set; }
        public class GetUserLangResponseBodySasUserLang : TeaModel {
            /// <summary>
            /// The language specified for log analysis. Valid values:
            /// 
            /// *   zh: Chinese
            /// *   en: English
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

        }

    }

}
