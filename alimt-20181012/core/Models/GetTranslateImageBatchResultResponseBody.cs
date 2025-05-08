// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetTranslateImageBatchResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTranslateImageBatchResultResponseBodyData Data { get; set; }
        public class GetTranslateImageBatchResultResponseBodyData : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetTranslateImageBatchResultResponseBodyDataResult> Result { get; set; }
            public class GetTranslateImageBatchResultResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://example.com/example.jpg">https://example.com/example.jpg</a></para>
                /// </summary>
                [NameInMap("FinalImageUrl")]
                [Validation(Required=false)]
                public string FinalImageUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://example.com/example.jpg">https://example.com/example.jpg</a></para>
                /// </summary>
                [NameInMap("InPaintingUrl")]
                [Validation(Required=false)]
                public string InPaintingUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://example.com/example.jpg">https://example.com/example.jpg</a></para>
                /// </summary>
                [NameInMap("SourceImageUrl")]
                [Validation(Required=false)]
                public string SourceImageUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;TemplateJson&quot;: &quot;Editor Template Json String	&quot;}</para>
                /// </summary>
                [NameInMap("TemplateJson")]
                [Validation(Required=false)]
                public string TemplateJson { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DACD263C-C068-5116-83EC-117245AA35CF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
