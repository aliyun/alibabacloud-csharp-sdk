// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CountTextResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6C9CB64D-E2D3-5BF2-A9E6-2445F952F178</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("countTextCmdList")]
        [Validation(Required=false)]
        public List<CountTextResponseBodyCountTextCmdList> CountTextCmdList { get; set; }
        public class CountTextResponseBodyCountTextCmdList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RED_BOOK</para>
            /// </summary>
            [NameInMap("theme")]
            [Validation(Required=false)]
            public string Theme { get; set; }

        }

    }

}
