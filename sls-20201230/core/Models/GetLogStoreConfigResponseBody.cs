// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogStoreConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of header keys used to extract the client IP address when data is written to the Logstore. The keys are case-insensitive, but their order in the array is significant. For this feature to work, enable the <c>appendMeta</c> option on the Logstore. Log Service searches the request headers for these keys in the specified order and adds the first valid IP address it finds as a log tag.</para>
        /// </summary>
        [NameInMap("clientIpHeaders")]
        [Validation(Required=false)]
        public List<string> ClientIpHeaders { get; set; }

    }

}
