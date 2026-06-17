// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePageDocumentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of documents.</para>
        /// </summary>
        [NameInMap("Docs")]
        [Validation(Required=false)]
        public List<DescribePageDocumentsResponseBodyDocs> Docs { get; set; }
        public class DescribePageDocumentsResponseBodyDocs : TeaModel {
            /// <summary>
            /// <para>The title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The URL of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://notify-center-test.ybaobx.com/webhook/arms">https://notify-center-test.ybaobx.com/webhook/arms</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The URL of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/tfs/TB1E4FCAuT2gK0jSZFvXXXnFXXa-3399-662.png">https://img.alicdn.com/tfs/TB1E4FCAuT2gK0jSZFvXXXnFXXa-3399-662.png</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The application module.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg_server</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        /// <summary>
        /// <para>Additional information.</para>
        /// </summary>
        [NameInMap("More")]
        [Validation(Required=false)]
        public DescribePageDocumentsResponseBodyMore More { get; set; }
        public class DescribePageDocumentsResponseBodyMore : TeaModel {
            /// <summary>
            /// <para>The title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The URL of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://zjysfy.womanhospital.cn/pub/hos/0/noneBackGround.png">https://zjysfy.womanhospital.cn/pub/hos/0/noneBackGround.png</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C81E1AD-08C0-5E09-853B-FDC77B90****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
