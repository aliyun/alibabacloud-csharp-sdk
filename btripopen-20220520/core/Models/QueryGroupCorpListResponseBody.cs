// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryGroupCorpListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>A3F8DCAB-8301-5770-BD9F-71B0BF9E1A6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<QueryGroupCorpListResponseBodyModule> Module { get; set; }
        public class QueryGroupCorpListResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>corp1</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("trace_id")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
