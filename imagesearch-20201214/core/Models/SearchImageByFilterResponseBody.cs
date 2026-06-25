// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class SearchImageByFilterResponseBody : TeaModel {
        /// <summary>
        /// <para>The product description information returned.</para>
        /// </summary>
        [NameInMap("Auctions")]
        [Validation(Required=false)]
        public List<SearchImageByFilterResponseBodyAuctions> Auctions { get; set; }
        public class SearchImageByFilterResponseBodyAuctions : TeaModel {
            /// <summary>
            /// <para>The image category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8888888</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public int? CategoryId { get; set; }

            /// <summary>
            /// <para>The user-defined content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zidingyi</para>
            /// </summary>
            [NameInMap("CustomContent")]
            [Validation(Required=false)]
            public string CustomContent { get; set; }

            /// <summary>
            /// <para>The integer type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IntAttr")]
            [Validation(Required=false)]
            public int? IntAttr { get; set; }

            /// <summary>
            /// <para>The integer type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IntAttr2")]
            [Validation(Required=false)]
            public int? IntAttr2 { get; set; }

            /// <summary>
            /// <para>The integer type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IntAttr3")]
            [Validation(Required=false)]
            public int? IntAttr3 { get; set; }

            /// <summary>
            /// <para>The integer type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IntAttr4")]
            [Validation(Required=false)]
            public int? IntAttr4 { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2092061_1.jpg</para>
            /// </summary>
            [NameInMap("PicName")]
            [Validation(Required=false)]
            public string PicName { get; set; }

            /// <summary>
            /// <para>The product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2092061_1</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The string type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("StrAttr")]
            [Validation(Required=false)]
            public string StrAttr { get; set; }

            /// <summary>
            /// <para>The string type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("StrAttr2")]
            [Validation(Required=false)]
            public string StrAttr2 { get; set; }

            /// <summary>
            /// <para>The string type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("StrAttr3")]
            [Validation(Required=false)]
            public string StrAttr3 { get; set; }

            /// <summary>
            /// <para>The string type attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("StrAttr4")]
            [Validation(Required=false)]
            public string StrAttr4 { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description>0: success.</description></item>
        /// <item><description>Non-zero: failure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B3137727-7D6E-488C-BA21-0E034C38A879</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
