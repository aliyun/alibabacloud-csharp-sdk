// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class Layer : TeaModel {
        [NameInMap("acl")]
        [Validation(Required=false)]
        public string Acl { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public OutputCodeLocation Code { get; set; }

        [NameInMap("codeChecksum")]
        [Validation(Required=false)]
        public string CodeChecksum { get; set; }

        [NameInMap("codeSize")]
        [Validation(Required=false)]
        public long? CodeSize { get; set; }

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

        [NameInMap("layerVersionArn")]
        [Validation(Required=false)]
        public string LayerVersionArn { get; set; }

        [NameInMap("license")]
        [Validation(Required=false)]
        public string License { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
