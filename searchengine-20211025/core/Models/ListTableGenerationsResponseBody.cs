// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListTableGenerationsResponseBody : TeaModel {
        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6E3D968-529C-5C40-AFDD-133A8B8FD930</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListTableGenerationsResponseBodyResult> Result { get; set; }
        public class ListTableGenerationsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ID of the full index version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1708674867</para>
            /// </summary>
            [NameInMap("generationId")]
            [Validation(Required=false)]
            public long? GenerationId { get; set; }

        }

    }

}
