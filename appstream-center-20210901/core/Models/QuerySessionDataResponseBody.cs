// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QuerySessionDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NO_DATA</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IndexData")]
        [Validation(Required=false)]
        public List<QuerySessionDataResponseBodyIndexData> IndexData { get; set; }
        public class QuerySessionDataResponseBodyIndexData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Hh")]
            [Validation(Required=false)]
            public string Hh { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Mi")]
            [Validation(Required=false)]
            public string Mi { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("SessionCntMi")]
            [Validation(Required=false)]
            public long? SessionCntMi { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20261106</para>
            /// </summary>
            [NameInMap("StatDate")]
            [Validation(Required=false)]
            public string StatDate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The parameter DateFormat is invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D4A13D91-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
