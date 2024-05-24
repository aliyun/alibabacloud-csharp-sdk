// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class InfraStackStatus : TeaModel {
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("observedGeneration")]
        [Validation(Required=false)]
        public int? ObservedGeneration { get; set; }

        [NameInMap("observedTime")]
        [Validation(Required=false)]
        public string ObservedTime { get; set; }

        [NameInMap("phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("resourceState")]
        [Validation(Required=false)]
        public InfraStackResourceState ResourceState { get; set; }

        [NameInMap("templateOutputs")]
        [Validation(Required=false)]
        public Dictionary<string, object> TemplateOutputs { get; set; }

        [NameInMap("templateStatus")]
        [Validation(Required=false)]
        public InfraStackStatusTemplateStatus TemplateStatus { get; set; }
        public class InfraStackStatusTemplateStatus : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("outputs")]
            [Validation(Required=false)]
            public List<TerraformOutputValue> Outputs { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("variables")]
            [Validation(Required=false)]
            public List<TerraformInputVariable> Variables { get; set; }

        }

    }

}
