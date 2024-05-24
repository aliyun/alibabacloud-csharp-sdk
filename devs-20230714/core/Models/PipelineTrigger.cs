// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class PipelineTrigger : TeaModel {
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("deletionTime")]
        [Validation(Required=false)]
        public string DeletionTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("generation")]
        [Validation(Required=false)]
        public int? Generation { get; set; }

        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("resourceVersion")]
        [Validation(Required=false)]
        public int? ResourceVersion { get; set; }

        [NameInMap("spec")]
        [Validation(Required=false)]
        public PipelineTriggerSpec Spec { get; set; }

        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
