// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDDoSStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The current DDoS status.</para>
        /// </summary>
        [NameInMap("DDoSStatus")]
        [Validation(Required=false)]
        public List<DescribeDDoSStatusResponseBodyDDoSStatus> DDoSStatus { get; set; }
        public class DescribeDDoSStatusResponseBodyDDoSStatus : TeaModel {
            /// <summary>
            /// <para>The name of the event type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>defense: DDoS traffic scrubbing event.</para>
            /// </description></item>
            /// <item><description><para>blackhole: DDoS blackhole filtering event.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>blackhole</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The DDoS status:</para>
            /// <para><b>doing</b>: Under DDoS attack.</para>
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
