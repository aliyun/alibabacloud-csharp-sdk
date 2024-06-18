// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class RequestPayDemandRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Price")]
        [Validation(Required=false)]
        public float? Price { get; set; }

        [NameInMap("ProduceType")]
        [Validation(Required=false)]
        public int? ProduceType { get; set; }

    }

}
