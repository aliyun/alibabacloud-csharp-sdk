// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DataInterpretationRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        [NameInMap("PromptForceOverride")]
        [Validation(Required=false)]
        public bool? PromptForceOverride { get; set; }

        [NameInMap("UserPrompt")]
        [Validation(Required=false)]
        public string UserPrompt { get; set; }

        [NameInMap("UserQuestion")]
        [Validation(Required=false)]
        public string UserQuestion { get; set; }

    }

}
