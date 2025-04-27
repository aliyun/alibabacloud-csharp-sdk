// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdatePublicWhiteIpsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>C82758DD-282F-4D48-934F-92170A33****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdatePublicWhiteIpsResponseBodyResult Result { get; set; }
        public class UpdatePublicWhiteIpsResponseBodyResult : TeaModel {
            [NameInMap("publicIpWhitelist")]
            [Validation(Required=false)]
            public List<string> PublicIpWhitelist { get; set; }

        }

    }

}
