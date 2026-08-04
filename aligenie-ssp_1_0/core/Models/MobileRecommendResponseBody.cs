// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class MobileRecommendResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code of the invocation</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>If an error occurs, the error message will be output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C5809B4-F465-52E0-9A8B-61396F9E593B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Request result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<MobileRecommendResponseBodyResult> Result { get; set; }
        public class MobileRecommendResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Author information</para>
            /// </summary>
            [NameInMap("Authors")]
            [Validation(Required=false)]
            public List<string> Authors { get; set; }

            /// <summary>
            /// <para>Album thumbnail image</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://img4.kuwo.cn/star/albumcover/120/78/77/1688821132.jpg">http://img4.kuwo.cn/star/albumcover/120/78/77/1688821132.jpg</a></para>
            /// </summary>
            [NameInMap("Cover")]
            [Validation(Required=false)]
            public string Cover { get; set; }

            /// <summary>
            /// <para>Third-party ID of the content</para>
            /// 
            /// <b>Example:</b>
            /// <para>550144364</para>
            /// </summary>
            [NameInMap("RawId")]
            [Validation(Required=false)]
            public string RawId { get; set; }

            /// <summary>
            /// <para>Source of the content</para>
            /// 
            /// <b>Example:</b>
            /// <para>KG</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>Content title</para>
            /// 
            /// <b>Example:</b>
            /// <para>稻香</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
