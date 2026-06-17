// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInvadeEventNameListResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of anomalous activity names.</para>
        /// </summary>
        [NameInMap("EventNameList")]
        [Validation(Required=false)]
        public List<DescribeInvadeEventNameListResponseBodyEventNameList> EventNameList { get; set; }
        public class DescribeInvadeEventNameListResponseBodyEventNameList : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the vulnerability event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CActivity</para>
            /// </summary>
            [NameInMap("EventKey")]
            [Validation(Required=false)]
            public string EventKey { get; set; }

            /// <summary>
            /// <para>The name of the vulnerability event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Suspicious central control communication</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

        }

        /// <summary>
        /// <para>A list of vulnerability names.</para>
        /// </summary>
        [NameInMap("NameList")]
        [Validation(Required=false)]
        public List<string> NameList { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6ABAA264-E7B5-5D66-8FC3-9253100****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
