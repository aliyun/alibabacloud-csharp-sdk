// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDSRecordResponseBody : TeaModel {
        [NameInMap("DSRecordList")]
        [Validation(Required=false)]
        public List<QueryDSRecordResponseBodyDSRecordList> DSRecordList { get; set; }
        public class QueryDSRecordResponseBodyDSRecordList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public int? Algorithm { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f58fa917424383934c7b0cf1a90f61d692745680fa06f5ecdbe0924e86de9598</para>
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DigestType")]
            [Validation(Required=false)]
            public int? DigestType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("KeyTag")]
            [Validation(Required=false)]
            public int? KeyTag { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>814B2AF0-ED6F-4C13-B41C-8AC0B1023583</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
