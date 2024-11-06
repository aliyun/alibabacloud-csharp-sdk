// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSecFuncInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The parameters required by the code.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeDcdnSecFuncInfoResponseBodyContent> Content { get; set; }
        public class DescribeDcdnSecFuncInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The language (Chinese or English).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ai_defense</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The options in the drop-down list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ai_defense</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The description of HTTP responses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatus")]
        [Validation(Required=false)]
        public string HttpStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30A3A25A-86B3-4C1D-BAA8-12B8607A5CFD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return value for HTTP requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: OK.</description></item>
        /// <item><description>Values other than 0: an error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public string RetCode { get; set; }

    }

}
