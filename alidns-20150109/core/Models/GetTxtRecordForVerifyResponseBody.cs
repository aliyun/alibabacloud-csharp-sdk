// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class GetTxtRecordForVerifyResponseBody : TeaModel {
        /// <summary>
        /// The domain name.
        /// 
        /// >  If you do not specify this parameter, it is not returned.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The host record.
        /// </summary>
        [NameInMap("RR")]
        [Validation(Required=false)]
        public string RR { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The value of the DNS record.
        /// 
        /// >  The validity period is three days.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
