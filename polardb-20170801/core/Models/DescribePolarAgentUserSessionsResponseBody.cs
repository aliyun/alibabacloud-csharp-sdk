// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarAgentUserSessionsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribePolarAgentUserSessionsResponseBodyData> Data { get; set; }
        public class DescribePolarAgentUserSessionsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>01IC17MLISBB98SL345H7B5AES1E8VB1</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SessionStatus")]
            [Validation(Required=false)]
            public long? SessionStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>content</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E2FDB684-751D-424D-98B9-704BEA******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
