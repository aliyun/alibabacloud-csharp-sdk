// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetTableGenerationResponseBody : TeaModel {
        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7B7D598-B080-5C8E-AA35-D43EC0D5F886</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result returned.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTableGenerationResponseBodyResult Result { get; set; }
        public class GetTableGenerationResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>generationId</para>
            /// 
            /// <b>Example:</b>
            /// <para>1708674867</para>
            /// </summary>
            [NameInMap("generationId")]
            [Validation(Required=false)]
            public long? GenerationId { get; set; }

            /// <summary>
            /// <para>starting, building, ready, stopped, failed</para>
            /// 
            /// <b>Example:</b>
            /// <para>ready</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
