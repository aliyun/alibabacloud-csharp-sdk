// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdatePrivateNetworkWhiteIpsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6DEBE5EE-0368-4757-8F82-EF9C3972****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdatePrivateNetworkWhiteIpsResponseBodyResult Result { get; set; }
        public class UpdatePrivateNetworkWhiteIpsResponseBodyResult : TeaModel {
            [NameInMap("privateNetworkIpWhiteList")]
            [Validation(Required=false)]
            public List<string> PrivateNetworkIpWhiteList { get; set; }

        }

    }

}
