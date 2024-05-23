// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20180807.Models
{
    public class MachineTranslateGeneralRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContentFormat")]
        [Validation(Required=false)]
        public string ContentFormat { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceText")]
        [Validation(Required=false)]
        public string SourceText { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

    }

}
