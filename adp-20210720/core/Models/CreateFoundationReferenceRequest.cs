// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class CreateFoundationReferenceRequest : TeaModel {
        [NameInMap("clusterConfig")]
        [Validation(Required=false)]
        public string ClusterConfig { get; set; }

        [NameInMap("componentConfigs")]
        [Validation(Required=false)]
        public List<CreateFoundationReferenceRequestComponentConfigs> ComponentConfigs { get; set; }
        public class CreateFoundationReferenceRequestComponentConfigs : TeaModel {
            [NameInMap("componentVersionUID")]
            [Validation(Required=false)]
            public string ComponentVersionUID { get; set; }

            [NameInMap("orchestrationValues")]
            [Validation(Required=false)]
            public string OrchestrationValues { get; set; }

        }

        [NameInMap("foundationReferenceConfigs")]
        [Validation(Required=false)]
        public List<CreateFoundationReferenceRequestFoundationReferenceConfigs> FoundationReferenceConfigs { get; set; }
        public class CreateFoundationReferenceRequestFoundationReferenceConfigs : TeaModel {
            [NameInMap("componentReleaseName")]
            [Validation(Required=false)]
            public string ComponentReleaseName { get; set; }

            [NameInMap("configType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("foundationVersionUID")]
        [Validation(Required=false)]
        public string FoundationVersionUID { get; set; }

        [NameInMap("originFoundationReferenceUID")]
        [Validation(Required=false)]
        public string OriginFoundationReferenceUID { get; set; }

    }

}
