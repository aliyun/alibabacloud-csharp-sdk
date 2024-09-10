// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GenerateDynamicDictResponseBody : TeaModel {
        /// <summary>
        /// The custom weak passwords.
        /// </summary>
        [NameInMap("KeywordList")]
        [Validation(Required=false)]
        public List<string> KeywordList { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
