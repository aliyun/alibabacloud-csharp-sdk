// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateLayerVersionResponseBody : TeaModel {
        [NameInMap("acl")]
        [Validation(Required=false)]
        public int? Acl { get; set; }

        [NameInMap("arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public OutputCodeLocation Code { get; set; }

        [NameInMap("codeChecksum")]
        [Validation(Required=false)]
        public string CodeChecksum { get; set; }

        [NameInMap("codesize")]
        [Validation(Required=false)]
        public long? Codesize { get; set; }

        [NameInMap("compatibleRuntime")]
        [Validation(Required=false)]
        public List<string> CompatibleRuntime { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("layerName")]
        [Validation(Required=false)]
        public string LayerName { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
