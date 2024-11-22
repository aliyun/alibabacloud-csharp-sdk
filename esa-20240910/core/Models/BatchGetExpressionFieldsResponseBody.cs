// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchGetExpressionFieldsResponseBody : TeaModel {
        /// <summary>
        /// <para>The fields that match the regular expressions.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<BatchGetExpressionFieldsResponseBodyFields> Fields { get; set; }
        public class BatchGetExpressionFieldsResponseBodyFields : TeaModel {
            /// <summary>
            /// <para>The fields that match the regular expression.</para>
            /// </summary>
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<string> Fields { get; set; }

            /// <summary>
            /// <para>The ID of the regular expression, which corresponds to the expression ID in the request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
