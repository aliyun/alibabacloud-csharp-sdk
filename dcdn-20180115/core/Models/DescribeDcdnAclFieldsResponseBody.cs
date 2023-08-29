// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnAclFieldsResponseBody : TeaModel {
        /// <summary>
        /// The details about the rules.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeDcdnAclFieldsResponseBodyContent> Content { get; set; }
        public class DescribeDcdnAclFieldsResponseBodyContent : TeaModel {
            /// <summary>
            /// The rules and policies that were configured. The JSON string is decoded.
            /// </summary>
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public string Fields { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
