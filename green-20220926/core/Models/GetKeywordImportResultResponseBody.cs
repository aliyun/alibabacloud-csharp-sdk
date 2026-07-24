// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetKeywordImportResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetKeywordImportResultResponseBodyData Data { get; set; }
        public class GetKeywordImportResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The internationalization key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("I18nKey")]
            [Validation(Required=false)]
            public string I18nKey { get; set; }

            /// <summary>
            /// <para>The list of keywords that are too long or too short.</para>
            /// </summary>
            [NameInMap("IllegalLengthKeywords")]
            [Validation(Required=false)]
            public List<string> IllegalLengthKeywords { get; set; }

            /// <summary>
            /// <para>The number of invalid keywords.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InvalidCount")]
            [Validation(Required=false)]
            public int? InvalidCount { get; set; }

            /// <summary>
            /// <para>The list of invalid keywords.</para>
            /// </summary>
            [NameInMap("InvalidKeywords")]
            [Validation(Required=false)]
            public List<string> InvalidKeywords { get; set; }

            /// <summary>
            /// <para>The keyword library ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customxx_xxx</para>
            /// </summary>
            [NameInMap("LibId")]
            [Validation(Required=false)]
            public string LibId { get; set; }

            /// <summary>
            /// <para>The task progress percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The number of duplicate keywords.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RepeatCount")]
            [Validation(Required=false)]
            public int? RepeatCount { get; set; }

            /// <summary>
            /// <para>The list of duplicate keywords.</para>
            /// </summary>
            [NameInMap("RepeatKeywords")]
            [Validation(Required=false)]
            public List<string> RepeatKeywords { get; set; }

            /// <summary>
            /// <para>The number of successfully imported keywords.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            /// <summary>
            /// <para>The prompt information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Tips")]
            [Validation(Required=false)]
            public string Tips { get; set; }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The description of the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
