// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListResourceGroupsRequest : TeaModel {
        [NameInMap("BizExtKey")]
        [Validation(Required=false)]
        public string BizExtKey { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("ResourceGroupType")]
        [Validation(Required=false)]
        public int? ResourceGroupType { get; set; }

        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListResourceGroupsRequestTags> Tags { get; set; }
        public class ListResourceGroupsRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
