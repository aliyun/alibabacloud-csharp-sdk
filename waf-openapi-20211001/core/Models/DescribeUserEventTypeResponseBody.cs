// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserEventTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The types and statistics of security events.</para>
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public List<DescribeUserEventTypeResponseBodyEvent> Event { get; set; }
        public class DescribeUserEventTypeResponseBodyEvent : TeaModel {
            /// <summary>
            /// <para>The code of the security event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Event_LoginCollision</para>
            /// </summary>
            [NameInMap("EventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            /// <summary>
            /// <para>The number of events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public long? EventCount { get; set; }

            /// <summary>
            /// <para>The parent type of the security event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EventType_Account</para>
            /// </summary>
            [NameInMap("EventParentType")]
            [Validation(Required=false)]
            public string EventParentType { get; set; }

            /// <summary>
            /// <para>The type of the security event.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~DescribeApisecRules~~">DescribeApisecRules</a> operation to query the supported types of security events.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Event_AbnormalFrequency</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>177BA739-6512-5470-98C6-E***0BAA3D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
