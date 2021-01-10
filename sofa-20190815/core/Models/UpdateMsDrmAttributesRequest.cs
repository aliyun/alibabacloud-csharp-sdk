// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateMsDrmAttributesRequest : TeaModel {
        [NameInMap("AttributeName")]
        [Validation(Required=false)]
        public string AttributeName { get; set; }

        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Parent")]
        [Validation(Required=false)]
        public string Parent { get; set; }

        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

    }

}
