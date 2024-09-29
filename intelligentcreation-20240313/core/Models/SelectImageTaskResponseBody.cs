// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class SelectImageTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Failed to proxy flink ui request, message: An error occurred: Invalid UUID string: jobsn</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("failed")]
        [Validation(Required=false)]
        public string Failed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PLATFORM</para>
        /// </summary>
        [NameInMap("generationSource")]
        [Validation(Required=false)]
        public string GenerationSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("imageInfos")]
        [Validation(Required=false)]
        public List<SelectImageTaskResponseBodyImageInfos> ImageInfos { get; set; }
        public class SelectImageTaskResponseBodyImageInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.ali.com">www.ali.com</a></para>
            /// </summary>
            [NameInMap("customImageUrl")]
            [Validation(Required=false)]
            public string CustomImageUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("imageH")]
            [Validation(Required=false)]
            public string ImageH { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("imageW")]
            [Validation(Required=false)]
            public string ImageW { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0E8B1746-AE35-5C4B-A3A8-345B274AE32C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successed</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("subtaskProcessing")]
        [Validation(Required=false)]
        public string SubtaskProcessing { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
