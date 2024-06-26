// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeTransactionFor2CBrowserRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlipayAuthCode")]
        [Validation(Required=false)]
        public string AlipayAuthCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Bizid")]
        [Validation(Required=false)]
        public string Bizid { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Hash")]
        [Validation(Required=false)]
        public string Hash { get; set; }

    }

}
