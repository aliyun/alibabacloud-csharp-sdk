// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class BatchCreateAICoachTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7915125A-0D96-5A25-A54B-D3B739A86AFC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("scriptRecordId")]
        [Validation(Required=false)]
        public string ScriptRecordId { get; set; }

        [NameInMap("studentIds")]
        [Validation(Required=false)]
        public List<string> StudentIds { get; set; }

        [NameInMap("studentList")]
        [Validation(Required=false)]
        public List<BatchCreateAICoachTaskRequestStudentList> StudentList { get; set; }
        public class BatchCreateAICoachTaskRequestStudentList : TeaModel {
            [NameInMap("studentAudioUrl")]
            [Validation(Required=false)]
            public string StudentAudioUrl { get; set; }

            [NameInMap("studentId")]
            [Validation(Required=false)]
            public string StudentId { get; set; }

        }

    }

}
