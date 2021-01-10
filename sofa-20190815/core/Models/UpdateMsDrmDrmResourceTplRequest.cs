// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateMsDrmDrmResourceTplRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public string Attributes { get; set; }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("HasInstance")]
        [Validation(Required=false)]
        public bool? HasInstance { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("TplId")]
        [Validation(Required=false)]
        public long? TplId { get; set; }

    }

}
