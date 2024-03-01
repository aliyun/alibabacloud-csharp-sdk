// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class GetMainDomainNameRequest : TeaModel {
        /// <summary>
        /// The string. The string can be up to 128 characters in length.
        /// </summary>
        [NameInMap("InputString")]
        [Validation(Required=false)]
        public string InputString { get; set; }

        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
