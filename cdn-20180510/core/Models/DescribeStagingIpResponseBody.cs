// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeStagingIpResponseBody : TeaModel {
        /// <summary>
        /// <para>IPv4 addresses.</para>
        /// </summary>
        [NameInMap("IPV4s")]
        [Validation(Required=false)]
        public DescribeStagingIpResponseBodyIPV4s IPV4s { get; set; }
        public class DescribeStagingIpResponseBodyIPV4s : TeaModel {
            [NameInMap("IPV4")]
            [Validation(Required=false)]
            public List<string> IPV4 { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1B9E0E83-24AC-49F4-9EE0-BF5EB03E8381</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
