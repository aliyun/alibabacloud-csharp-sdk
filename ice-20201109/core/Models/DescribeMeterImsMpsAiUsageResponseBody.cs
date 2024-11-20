// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeMeterImsMpsAiUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The usage statistics of IMS on AI processing of MPS.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterImsMpsAiUsageResponseBodyData> Data { get; set; }
        public class DescribeMeterImsMpsAiUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The usage duration, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>644</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The beginning time of usage. The value is a 10-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1656950400</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <para>The AI type. Valid values:</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0622C702-41BE-467E-AF2E-883D4517962E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
