// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SetDomainRecordStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the DNS record.
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public string RecordId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the DNS record.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
