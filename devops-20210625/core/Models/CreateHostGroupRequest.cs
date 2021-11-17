/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateHostGroupRequest : TeaModel {
        [NameInMap("aliyunRegion")]
        [Validation(Required=false)]
        public string AliyunRegion { get; set; }

        [NameInMap("ecsLabelKey")]
        [Validation(Required=false)]
        public string EcsLabelKey { get; set; }

        [NameInMap("ecsLabelValue")]
        [Validation(Required=false)]
        public string EcsLabelValue { get; set; }

        [NameInMap("ecsType")]
        [Validation(Required=false)]
        public string EcsType { get; set; }

        [NameInMap("envId")]
        [Validation(Required=false)]
        public string EnvId { get; set; }

        [NameInMap("machineInfos")]
        [Validation(Required=false)]
        public string MachineInfos { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("serviceConnectionId")]
        [Validation(Required=false)]
        public long? ServiceConnectionId { get; set; }

        [NameInMap("tagIds")]
        [Validation(Required=false)]
        public string TagIds { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
