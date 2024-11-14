// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeFreeUserEventCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the security events that are detected by using the basic detection feature.</para>
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public DescribeFreeUserEventCountResponseBodyEvent Event { get; set; }
        public class DescribeFreeUserEventCountResponseBodyEvent : TeaModel {
            /// <summary>
            /// <para>The number of high-risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EventHigh")]
            [Validation(Required=false)]
            public long? EventHigh { get; set; }

            /// <summary>
            /// <para>The number of low-risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("EventLow")]
            [Validation(Required=false)]
            public long? EventLow { get; set; }

            /// <summary>
            /// <para>The number of medium-risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("EventMedium")]
            [Validation(Required=false)]
            public long? EventMedium { get; set; }

            /// <summary>
            /// <para>The total number of security events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("EventTotal")]
            [Validation(Required=false)]
            public long? EventTotal { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D9FB3BC-0DE9-58A8-9663-ACE56F24F405</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
