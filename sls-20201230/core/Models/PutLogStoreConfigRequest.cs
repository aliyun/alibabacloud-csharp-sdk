// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class PutLogStoreConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies a list of header keys from which to extract the client IP address during log ingestion. Simple Log Service (SLS) searches these headers in the specified order and uses the first valid IP address that it finds. The key names are case-insensitive, but their order is significant. To use this feature, you must also enable the <c>appendMeta</c> setting for the Logstore. This setting adds the extracted IP address as a log tag.</para>
        /// </summary>
        [NameInMap("clientIpHeaders")]
        [Validation(Required=false)]
        public List<string> ClientIpHeaders { get; set; }

    }

}
