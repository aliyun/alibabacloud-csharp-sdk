// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeCallbacksResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of subscribed events for the application.</para>
        /// </summary>
        [NameInMap("Callbacks")]
        [Validation(Required=false)]
        public List<DescribeCallbacksResponseBodyCallbacks> Callbacks { get; set; }
        public class DescribeCallbacksResponseBodyCallbacks : TeaModel {
            /// <summary>
            /// <para>The callback code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RecordEvent</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The callback validation status. 0 indicates validating. 1 indicates validation successful. 2 indicates validation failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public string CheckStatus { get; set; }

            /// <summary>
            /// <para>The callback validation code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RESPONSE_INVALID</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The webhook address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Conf")]
            [Validation(Required=false)]
            public string Conf { get; set; }

            /// <summary>
            /// <para>The callback validation message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>The callback status. 0 indicates enabled. 1 indicates disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The sub-events. For more information, see Callback overview.
            /// Recording events:</para>
            /// <list type="bullet">
            /// <item><description><para><b>2010</b>: The service status of the recording changes.</para>
            /// </description></item>
            /// <item><description><para><b>2011</b>: The status of the recording audio stream changes.</para>
            /// </description></item>
            /// <item><description><para><b>2012</b>: The status of the recording video stream changes.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("SubEvent")]
            [Validation(Required=false)]
            public List<int?> SubEvent { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
