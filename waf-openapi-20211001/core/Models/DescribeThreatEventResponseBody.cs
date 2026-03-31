// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeThreatEventResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>98106632-6865-5600-A834-3D909***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ThreatEvents")]
        [Validation(Required=false)]
        public List<DescribeThreatEventResponseBodyThreatEvents> ThreatEvents { get; set; }
        public class DescribeThreatEventResponseBodyThreatEvents : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("BlockRate")]
            [Validation(Required=false)]
            public string BlockRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1768406400000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f439994c8ab39f84eced33490f0c4388</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3.3.3.3</para>
            /// </summary>
            [NameInMap("EventSrc")]
            [Validation(Required=false)]
            public string EventSrc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Event_InternalLoginWeakPasswd</para>
            /// </summary>
            [NameInMap("EventTag")]
            [Validation(Required=false)]
            public string EventTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test.aliyundemo.com-waf</para>
            /// </summary>
            [NameInMap("EventTarget")]
            [Validation(Required=false)]
            public string EventTarget { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
