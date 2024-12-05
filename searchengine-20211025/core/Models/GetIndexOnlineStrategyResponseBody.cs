// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetIndexOnlineStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE03180A-0E29-5474-8A86-33F0683294A4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetIndexOnlineStrategyResponseBodyResult Result { get; set; }
        public class GetIndexOnlineStrategyResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The index change rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("changeRate")]
            [Validation(Required=false)]
            public int? ChangeRate { get; set; }

        }

    }

}
