// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class GetAsrConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAsrConfigResponseBodyData Data { get; set; }
        public class GetAsrConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>your-app-key</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>The acoustic model ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3b1d3031-8b6e-460a-8640-d330f2ca50b8</para>
            /// </summary>
            [NameInMap("AsrAcousticModelId")]
            [Validation(Required=false)]
            public string AsrAcousticModelId { get; set; }

            /// <summary>
            /// <para>The ASR class vocabulary ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3b1d3031-8b6e-460a-8640-d330f2ca50b8</para>
            /// </summary>
            [NameInMap("AsrClassVocabularyId")]
            [Validation(Required=false)]
            public string AsrClassVocabularyId { get; set; }

            /// <summary>
            /// <para>The customization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3b1d3031-8b6e-460a-8640-d330f2ca50b8</para>
            /// </summary>
            [NameInMap("AsrCustomizationId")]
            [Validation(Required=false)]
            public string AsrCustomizationId { get; set; }

            [NameInMap("AsrOverrides")]
            [Validation(Required=false)]
            public string AsrOverrides { get; set; }

            /// <summary>
            /// <para>The vocabulary ID. You can view the ID on the <a href="https://aiccs.console.aliyun.com/sentence/vocab?spm=a2c4g.11186623.0.0.7f9bf965IKBpsi">ASR Vocabulary Management page</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3b1d3031-8b6e-460a-8640-d330f2ca50b8</para>
            /// </summary>
            [NameInMap("AsrVocabularyId")]
            [Validation(Required=false)]
            public string AsrVocabularyId { get; set; }

            /// <summary>
            /// <para>The speech engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ali</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>Parameters for the iFLYTEK engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EngineXufei</para>
            /// </summary>
            [NameInMap("EngineXufei")]
            [Validation(Required=false)]
            public string EngineXufei { get; set; }

            /// <summary>
            /// <para>The NLS service type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Authorized</para>
            /// </summary>
            [NameInMap("NlsServiceType")]
            [Validation(Required=false)]
            public string NlsServiceType { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Not Found</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14C39896-AE6D-4643-9C9A-E0566B2C2DDD</para>
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
