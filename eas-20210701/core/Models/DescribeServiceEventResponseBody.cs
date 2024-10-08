// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The events.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeServiceEventResponseBodyEvents> Events { get; set; }
        public class DescribeServiceEventResponseBodyEvents : TeaModel {
            /// <summary>
            /// <para>The returned message. The message is formatted and returned in the JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;versionId\&quot;:1,\&quot;message\&quot;:\&quot;Stage scale complete\&quot;,\&quot;availableInstance\&quot;:1,\&quot;unavailableInstance\&quot;:0}</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The cause of the event. The information about the change in the service status is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Updating</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The time when the event occurred. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-09 06:30:00</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The event type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal</description></item>
            /// <item><description>Warning</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D491C94-6239-5318-B4B4-799D859***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public long? TotalPageNum { get; set; }

    }

}
