// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class GetAsrConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAsrConfigResponseBodyData Data { get; set; }
        public class GetAsrConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3b1d3031-8b6e-460a-8640-d330f2ca50b8</para>
            /// </summary>
            [NameInMap("AsrAcousticModelId")]
            [Validation(Required=false)]
            public string AsrAcousticModelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3b1d3031-8b6e-460a-8640-d330f2ca50b8</para>
            /// </summary>
            [NameInMap("AsrClassVocabularyId")]
            [Validation(Required=false)]
            public string AsrClassVocabularyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3b1d3031-8b6e-460a-8640-d330f2ca50b8</para>
            /// </summary>
            [NameInMap("AsrCustomizationId")]
            [Validation(Required=false)]
            public string AsrCustomizationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3b1d3031-8b6e-460a-8640-d330f2ca50b8</para>
            /// </summary>
            [NameInMap("AsrVocabularyId")]
            [Validation(Required=false)]
            public string AsrVocabularyId { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("EngineXufei")]
            [Validation(Required=false)]
            public string EngineXufei { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Not Found</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>14C39896-AE6D-4643-9C9A-E0566B2C2DDD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
