// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class CreateVocabResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateVocabResponseBodyData Data { get; set; }
        public class CreateVocabResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>f3d82*******7</para>
            /// </summary>
            [NameInMap("vocabularyId")]
            [Validation(Required=false)]
            public string VocabularyId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>968A8634-FA2C-5381-9B3E-*******F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
