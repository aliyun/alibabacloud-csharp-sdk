// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GenerateDynamicDictRequest : TeaModel {
        /// <summary>
        /// The keyword of the dictionary.
        /// </summary>
        [NameInMap("ArgKeywords")]
        [Validation(Required=false)]
        public string ArgKeywords { get; set; }

        /// <summary>
        /// The domain name for custom weak passwords.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public string Domains { get; set; }

        /// <summary>
        /// The company name for custom weak passwords.
        /// </summary>
        [NameInMap("Names")]
        [Validation(Required=false)]
        public string Names { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
