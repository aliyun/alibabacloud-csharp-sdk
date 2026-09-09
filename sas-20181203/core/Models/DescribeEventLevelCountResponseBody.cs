// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEventLevelCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The value <b>200</b> indicates success. Any other value indicates failure. You can use this field to determine the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The statistics of security alerts by severity level.</para>
        /// </summary>
        [NameInMap("EventLevels")]
        [Validation(Required=false)]
        public DescribeEventLevelCountResponseBodyEventLevels EventLevels { get; set; }
        public class DescribeEventLevelCountResponseBodyEventLevels : TeaModel {
            /// <summary>
            /// <para>The number of security alerts with the Reminder severity level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Remind")]
            [Validation(Required=false)]
            public int? Remind { get; set; }

            /// <summary>
            /// <para>The number of security alerts with the Urgent severity level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Serious")]
            [Validation(Required=false)]
            public int? Serious { get; set; }

            /// <summary>
            /// <para>The number of security alerts with the Suspicious severity level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Suspicious")]
            [Validation(Required=false)]
            public int? Suspicious { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE8CA5EA-24EF-5D41-B735-53ACE7XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
