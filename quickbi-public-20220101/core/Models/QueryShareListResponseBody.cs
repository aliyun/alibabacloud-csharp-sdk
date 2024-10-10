// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryShareListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DC4E1E63-B337-44F8-8C22-6F00DF67E2C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryShareListResponseBodyResult> Result { get; set; }
        public class QueryShareListResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthPoint")]
            [Validation(Required=false)]
            public int? AuthPoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1640102400000</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public long? ExpireDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6b407e50-e774-406b-9956-da2425c2****</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0ab9659e-29cf-47d7-a364-3a91553b****</para>
            /// </summary>
            [NameInMap("ShareId")]
            [Validation(Required=false)]
            public string ShareId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>95296e95-ca89-4c7d-8af9-dedf0ad0****</para>
            /// </summary>
            [NameInMap("ShareToId")]
            [Validation(Required=false)]
            public string ShareToId { get; set; }

            [NameInMap("ShareToName")]
            [Validation(Required=false)]
            public string ShareToName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ShareToType")]
            [Validation(Required=false)]
            public int? ShareToType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
