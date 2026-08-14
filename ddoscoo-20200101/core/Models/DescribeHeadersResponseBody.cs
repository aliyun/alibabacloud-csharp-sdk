// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeHeadersResponseBody : TeaModel {
        [NameInMap("CustomHeader")]
        [Validation(Required=false)]
        public DescribeHeadersResponseBodyCustomHeader CustomHeader { get; set; }
        public class DescribeHeadersResponseBodyCustomHeader : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Headers")]
            [Validation(Required=false)]
            public string Headers { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;X-Client-IP&quot;:true,&quot;X-True-IP&quot;:true,&quot;Web-Server-Type&quot;:true,&quot;WL-Proxy-Client-IP&quot;:true,&quot;X-Forwarded-Proto&quot;:true}</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("EmbeddedHeaders")]
        [Validation(Required=false)]
        public string EmbeddedHeaders { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
