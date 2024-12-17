// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateIndividuationTextTaskRequest : TeaModel {
        [NameInMap("crowdPack")]
        [Validation(Required=false)]
        public List<List<string>> CrowdPack { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>840015278620459008</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
