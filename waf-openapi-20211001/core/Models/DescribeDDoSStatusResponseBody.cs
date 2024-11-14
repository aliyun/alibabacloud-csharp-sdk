// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDDoSStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether DDoS attacks occur on specific domain names.</para>
        /// </summary>
        [NameInMap("DDoSStatus")]
        [Validation(Required=false)]
        public List<DescribeDDoSStatusResponseBodyDDoSStatus> DDoSStatus { get; set; }
        public class DescribeDDoSStatusResponseBodyDDoSStatus : TeaModel {
            /// <summary>
            /// <para>The type of events that are triggered by DDoS attacks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>defense: traffic scrubbing events.</description></item>
            /// <item><description>blackhole: blackhole filtering events.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>blackhole</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>Indicates whether DDoS attacks occur on specific domain names. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>doing</b>: DDoS attacks occur on specific domain names.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>doing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
