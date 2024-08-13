// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCsrRequest : TeaModel {
        /// <summary>
        /// The algorithm. Valid values: RSA, ECC, and SM2.
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// The keyword.
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 50.
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

    }

}
