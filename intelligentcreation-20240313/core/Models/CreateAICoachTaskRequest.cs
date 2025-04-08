// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateAICoachTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>541E7123-2E8A-5BA2-AC38-665650C84129</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scriptRecordId")]
        [Validation(Required=false)]
        public string ScriptRecordId { get; set; }

        [NameInMap("studentAudioUrl")]
        [Validation(Required=false)]
        public string StudentAudioUrl { get; set; }

        [NameInMap("studentId")]
        [Validation(Required=false)]
        public string StudentId { get; set; }

    }

}
