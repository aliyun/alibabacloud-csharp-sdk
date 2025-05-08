// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetDetectLanguageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("DetectedLanguage")]
        [Validation(Required=false)]
        public string DetectedLanguage { get; set; }

        [NameInMap("LanguageProbabilities")]
        [Validation(Required=false)]
        public string LanguageProbabilities { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0C5EC1EC-1A06-4D60-97E6-4D41350945E4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
