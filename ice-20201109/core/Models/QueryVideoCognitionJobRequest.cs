// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryVideoCognitionJobRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to include the full algorithm results in the response.</para>
        /// </summary>
        [NameInMap("IncludeResults")]
        [Validation(Required=false)]
        public QueryVideoCognitionJobRequestIncludeResults IncludeResults { get; set; }
        public class QueryVideoCognitionJobRequestIncludeResults : TeaModel {
            /// <summary>
            /// <para>Specifies whether to include Automatic Speech Recognition (ASR) results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedAsr")]
            [Validation(Required=false)]
            public bool? NeedAsr { get; set; }

            /// <summary>
            /// <para>Specifies whether to include Optical Character Recognition (OCR) results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedOcr")]
            [Validation(Required=false)]
            public bool? NeedOcr { get; set; }

            /// <summary>
            /// <para>Specifies whether to include the URL to the raw output of the algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedProcess")]
            [Validation(Required=false)]
            public bool? NeedProcess { get; set; }

        }

        /// <summary>
        /// <para>The ID of the task to query. It is returned when you call the <a href="https://help.aliyun.com/document_detail/478786.html">SubmitSmarttagJob</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>Additional request parameters, provided as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

    }

}
