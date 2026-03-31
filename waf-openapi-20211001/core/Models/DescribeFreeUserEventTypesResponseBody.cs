// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeFreeUserEventTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The types of security events on which basic detection is performed.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeFreeUserEventTypesResponseBodyData> Data { get; set; }
        public class DescribeFreeUserEventTypesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of security events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("EventNum")]
            [Validation(Required=false)]
            public string EventNum { get; set; }

            /// <summary>
            /// <para>The type of the security event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SMSInterfaceAbuse</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B9D6AD11-DD3D-5A27-B1D9-8A37F7777196</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
