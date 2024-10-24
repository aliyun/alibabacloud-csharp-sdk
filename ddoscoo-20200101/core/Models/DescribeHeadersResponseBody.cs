// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeHeadersResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the custom header.</para>
        /// </summary>
        [NameInMap("CustomHeader")]
        [Validation(Required=false)]
        public DescribeHeadersResponseBodyCustomHeader CustomHeader { get; set; }
        public class DescribeHeadersResponseBodyCustomHeader : TeaModel {
            /// <summary>
            /// <para>The domain name of the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.aliyundoc.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The header of the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;X-Forwarded-ClientSrcPort&quot;:&quot;&quot;,&quot;header1&quot;:&quot;hLeLele&quot;}</para>
            /// </summary>
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public string Headers { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48BC7BA5-69BE-5C31-A080-AFF2431AE48D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
