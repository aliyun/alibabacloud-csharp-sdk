// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListResourceGroupsRequest : TeaModel {
        [NameInMap("ResourceGroupType")]
        [Validation(Required=false)]
        public int? ResourceGroupType { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("BizExtKey")]
        [Validation(Required=false)]
        public string BizExtKey { get; set; }

    }

}
