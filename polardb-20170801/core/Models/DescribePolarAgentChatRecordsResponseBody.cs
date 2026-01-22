// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarAgentChatRecordsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribePolarAgentChatRecordsResponseBodyData> Data { get; set; }
        public class DescribePolarAgentChatRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FeedbackType")]
            [Validation(Required=false)]
            public string FeedbackType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>Query ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>sq202506261002hz8b24fe80067683</para>
            /// </summary>
            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>44dcdf31-04cd-4a44-9bae-834dd6657e29</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A7E6A8FD-C50B-46B2-BA85-D8B8D3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
