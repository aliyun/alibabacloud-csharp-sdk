// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class MedicalKnowledgeRequest : TeaModel {
        /// <summary>
        /// <para>The query conditions for the health graph.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public MedicalKnowInput Body { get; set; }

    }

}
