// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CreateDrdsDBPreviewResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public CreateDrdsDBPreviewResponseBodyItems Items { get; set; }
        public class CreateDrdsDBPreviewResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<CreateDrdsDBPreviewResponseBodyItemsItem> Item { get; set; }
            public class CreateDrdsDBPreviewResponseBodyItemsItem : TeaModel {
                public string DbInstanceId { get; set; }
                public CreateDrdsDBPreviewResponseBodyItemsItemDbNames DbNames { get; set; }
                public class CreateDrdsDBPreviewResponseBodyItemsItemDbNames : TeaModel {
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public List<string> DbName { get; set; }

                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
