// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class SendDocumentAskQuestionRequest : TeaModel {
        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
