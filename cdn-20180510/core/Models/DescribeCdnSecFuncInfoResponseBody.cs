// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnSecFuncInfoResponseBody : TeaModel {
        /// <summary>
        /// Queried data.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeCdnSecFuncInfoResponseBodyContent> Content { get; set; }
        public class DescribeCdnSecFuncInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// The tag.
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// The value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatus")]
        [Validation(Required=false)]
        public string HttpStatus { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The HTTP request response code.
        /// 
        /// *   0: OK.
        /// *   Values other than 0: an error.
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public string RetCode { get; set; }

    }

}
